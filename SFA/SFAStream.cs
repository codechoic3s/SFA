using SFA.Elements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace SFA
{
    public class SFAStream : IDisposable
    {
        private Stream Stream;
        private long _LastHeaderPointer;

        public SFAStream(Stream stream)
        {
            Stream = stream;
        }

        public bool ReadMeta(out Meta meta)
        {
            meta = default;
            var state = ReadULong(0, (ulong)Stream.Length, out ulong count);
            if (state)
                meta = new Meta(count);
            return state;
        }
        public bool ReadHeader(Encoding enc, Meta meta, out Header header)
        {
            var fco = meta.Count;
            var hs = new HeaderFile[fco];
            header = new Header(hs);

            var alllength = (ulong)Stream.Length;

            bool stable = true;

            for (ulong i = 0; i < fco; i++)
            {
                stable = ReadULong((ulong)Stream.Position, alllength, out ulong position);
                if (!stable || position > (ulong)Stream.Length)
                    break;
                stable = ReadULong((ulong)Stream.Position, alllength, out ulong length);
                if (!stable || position + length > (ulong)Stream.Length)
                    break;
                stable = ReadString((ulong)Stream.Position, alllength, enc, out ulong readed, out string path);
                if (!stable)
                    break;
                stable = ReadString((ulong)Stream.Position, alllength, enc, out readed, out string name);
                if (!stable)
                    break;
                var hf = new HeaderFile(position, length, path, name);
                hs[i] = hf;
            }
            if (!stable)
                return false;
            _LastHeaderPointer = Stream.Position;

            return true;
        }

        public bool ReadStorageFile(HeaderFile headerFile, out byte[] data)
        {
            return ReadData(headerFile.Pointer, headerFile.Length, (ulong)Stream.Length, out data);
        }
        public bool ReadStorageFiles(Header header, out List<ValueTuple<HeaderFile, byte[]>> datas)
        {
            datas = new List<ValueTuple<HeaderFile, byte[]>>();
            var files = header.Files;
            var fco = files.LongLength;
            bool stable;
            for (long i = 0; i < fco; i++)
            {
                var hf = files[i];
                stable = ReadStorageFile(hf, out byte[] data);
                if (!stable)
                    return false;
                datas.Add((hf, data));
            }
            return true;
        }
        public bool ReadStorageFiles(Header header, out ManagedFile[] mfs)
        {
            mfs = null;
            var stable = ReadStorageFiles(header, out List<ValueTuple<HeaderFile, byte[]>> datas);
            if (!stable)
                return false;
            var adatas = datas.ToArray();
            var aco = (ulong)adatas.LongLength;
            mfs = new ManagedFile[aco];
            for (ulong i = 0; i < aco; i++)
            {
                var adata = adatas[i];
                mfs[i] = ManagedFile.FromRaw(adata.Item1, adata.Item2);
            }

            return true;
        }       

        public void WriteManagedFiles(ulong uptr, Encoding enc, ManagedFile[] mfs)
        {
            Stream.Position = (long)uptr;
            var mco = (ulong)mfs.LongLength;
            Stream.Write(BitConverter.GetBytes(mco));

            ulong ptr = (ulong)Stream.Position;

            var hfs = new ValueTuple<ulong, HeaderFile, byte[]>[mco];

            for (ulong i = 0; i < mco; i++) // filing header
            {
                var file = mfs[i];
                var hf = new HeaderFile(0, 0, file.Path, file.Name); // filling with zeros
                var unmanaged = hf.GetAsBytes(enc); // get as unmanaged type
                hfs[i] = (ptr, hf, unmanaged); // reserve unmanaged type
                ptr += (ulong)unmanaged.LongLength;
            }

            var sfs = new StorageFile[mco];

            for (ulong i = 0; i < mco; i++) // filling storage
            {
                var file = mfs[i];
                var data = file.Data;
                var dlen = (ulong)data.LongLength;

                hfs[i].Item2.Pointer = ptr;
                hfs[i].Item2.Length = dlen;

                sfs[i] = new StorageFile(data);

                ptr += dlen;
            }

            for (ulong i = 0; i < mco; i++) // writing memory
            {
                var sf = sfs[i];
                var sfdata = sf.Data;

                var hf = hfs[i];
                var h = hf.Item2;

                var data = hf.Item3;

                var pdata = new byte[][] { BitConverter.GetBytes(h.Pointer), BitConverter.GetBytes(h.Length) };

                ulong pptr = 8;

                for (ulong u = 0; u < 2; u++) 
                {
                    var pd = pdata[u];
                    var pdlen = (ulong)pd.LongLength;
                    var pltr = pptr * u;
                    for (ulong o = 0; o < pdlen; o++)
                    {
                        data[pltr + o] = pd[o];
                    }
                }

                Stream.Position = (long)hf.Item1;
                Stream.Write(data);

                Stream.Position = (long)h.Pointer;
                Stream.Write(sfdata, 0, (int)h.Length);
            }
        }
        
        private bool ReadString(ulong ptr, ulong alllength, Encoding enc, out ulong readedbytes, out string str)
        {
            readedbytes = 0;
            str = null;

            var stable = ReadULong(ptr, alllength, out ulong len);
            if (!stable)
                return false;

            stable = ReadData(ptr + 8, len, alllength, out byte[] data);
            if (!stable)
                return false;

            readedbytes = len;
            str = enc.GetString(data);

            return true;
        }
        private bool ReadULong(ulong ptr, ulong alllength, out ulong result)
        {
            result = 0;
            var len = sizeof(ulong);
            if (!IsSafeRead(ptr, (ulong)len, alllength))
                return false;

            var buf = new byte[len];
            var state = Read(ptr, ref buf);
            if (state)
                result = BitConverter.ToUInt64(buf);
            return state;
        }
        private bool ReadData(ulong ptr, ulong length, ulong alllength, out byte[] data)
        {
            data = null;
            if (!IsSafeRead(ptr, length, alllength))
                return false;

            var buf = new byte[length];
            var state = Read(ptr, ref buf);
            if (state)
                data = buf;
            return state;
        }

        private bool IsSafeRead(ulong ptr, ulong length, ulong alllength)
        {
            if (ptr + length > alllength)
                return false;
            return true;
        }
        private bool Read(ulong ptr, ref byte[] buffer)
        {
            Stream.Position = (long)ptr;
            var len = buffer.Length;
            var readed = Stream.Read(buffer, 0, len);
            if (len != readed)
                return false;
            return true;
        }

        public void Flush() => Stream.Flush();
        public void Dispose()
        {
            Stream.Close();
            Stream.Dispose();
        }
    }
}
