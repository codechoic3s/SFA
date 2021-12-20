using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA.Elements
{
    public struct HeaderFile
    {
        public ulong Pointer;
        public ulong Length;
        public string Path;
        public string Name;

        public HeaderFile(ulong ptr, ulong len, string path, string name)
        {
            Pointer = ptr;
            Length = len;
            Path = path;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Path}{Name} -> {Pointer} [{Length}]";
        }
        public string ToStringPath()
        {
            return $"{Name} ({Path}) -> {Pointer} [{Length}]";
        }

        internal byte[] GetAsBytes(Encoding enc)
        {
            List<byte> data = new List<byte>(16);

            data.AddRange(BitConverter.GetBytes(Pointer));
            data.AddRange(BitConverter.GetBytes(Length));

            var sdata = enc.GetBytes(Path);
            var slen = (ulong)sdata.LongLength;
            data.AddRange(BitConverter.GetBytes(slen));
            data.AddRange(sdata);

            sdata = enc.GetBytes(Name);
            slen = (ulong)sdata.LongLength;
            data.AddRange(BitConverter.GetBytes(slen));
            data.AddRange(enc.GetBytes(Name));

            return data.ToArray();
        }
    }
}
