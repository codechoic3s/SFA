using SFA;
using SFA.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAEditor.Managers
{
    public sealed class ManagedManager : Manager
    {
        public override ulong Count => (ulong)_ManagedFiles.Count;

        private List<ManagedFile> _ManagedFiles;
        private Header _Header;

        public override Header Header => _Header;

        public ManagedManager(Editor editor) : base(editor)
        {
        }

        private void UpdateHeader()
        {
            var mco = Count;
            var hfs = new HeaderFile[mco];
            for (ulong i = 0; i < mco; i++)
            {
                var mf = _ManagedFiles[(int)i];
                hfs[i] = new HeaderFile(0, (ulong)mf.Data.LongLength, mf.Path, mf.Name);
            }
            _Header.Files = hfs;
        }

        public override bool InitNewSFA()
        {
            _ManagedFiles = new List<ManagedFile>();
            _Header = new Header(null);
            return true;
        }

        public override bool OpenSFA()
        {
            bool stable = SFAStream.ReadMeta(out Meta meta);
            if (!stable)
                return false;
            stable = SFAStream.ReadHeader(Encoding, meta, out _Header);
            if (!stable)
                return false;
            stable = SFAStream.ReadStorageFiles(_Header, out ManagedFile[] mfs);
            if (!stable)
                return false;
            _ManagedFiles = new List<ManagedFile>(mfs);
            return true;
        }

        public override bool GetManagedFile(string path, out ManagedFile mf)
        {
            var mco = _ManagedFiles.Count;
            for (int i = 0; i < mco; i++)
            {
                var mff = _ManagedFiles[i];
                if (mff.Path == path)
                {
                    mf = mff;
                    UpdateHeader();
                    return true;
                }    
            }
            mf = null;
            return false;
        }

        /// <summary>
        /// On Managed goes with zeros: Pointer, Length.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="hf"></param>
        /// <returns></returns>
        public override bool GetHeaderFile(string path, out HeaderFile hf)
        {
            var mco = _ManagedFiles.Count;
            for (var i = 0; i < mco; i++)
            {
                var mff = _ManagedFiles[i];
                if (mff.Path == path)
                {
                    hf = new HeaderFile(0, 0, mff.Path, mff.Name);
                    UpdateHeader();
                    return true;
                }
            }
            hf = default;
            return false;
        }

        public override bool GetStorageFile(HeaderFile hf, out StorageFile sf)
        {
            var mco = _ManagedFiles.Count;
            for (var i = 0; i < mco; i++)
            {
                var mff = _ManagedFiles[i];
                if (mff.Path == hf.Path && mff.Name == hf.Name)
                {
                    sf = new StorageFile(mff.Data);
                    UpdateHeader();
                    return true;
                }
            }
            sf = default;
            return false;
        }

        public override bool SetManagedFile(ManagedFile fm)
        {
            var mco = _ManagedFiles.Count;
            for (var i = 0; i < mco; i++)
            {
                var mff = _ManagedFiles[i];
                if (mff.Name == fm.Name && mff.Path == fm.Path)
                {
                    _ManagedFiles[i] = fm;
                    UpdateHeader();
                    return true;
                }
            }
            return false;
        }

        public override bool SetManagedFile(ManagedFile fm, string path)
        {
            var mco = _ManagedFiles.Count;
            for (var i = 0; i < mco; i++)
            {
                var mff = _ManagedFiles[i];
                if (mff.Path == path)
                {
                    _ManagedFiles[i] = fm;
                    UpdateHeader();
                    return true;
                }
            }
            return false;
        }

        public override bool SetFile(HeaderFile hf, StorageFile sf, string path)
        {
            var mco = _ManagedFiles.Count;
            for (var i = 0; i < mco; i++)
            {
                var mff = _ManagedFiles[i];
                if (mff.Path == path)
                {
                    mff.Name = hf.Name;
                    mff.Path = hf.Path;
                    mff.Data = sf.Data;
                    UpdateHeader();
                    return true;
                }
            }
            return false;
        }

        public override bool SetFile(HeaderFile hf, StorageFile sf)
        {
            var mco = _ManagedFiles.Count;
            for (var i = 0; i < mco; i++)
            {
                var mff = _ManagedFiles[i];
                if (mff.Path == hf.Path && mff.Name == hf.Name)
                {
                    mff.Name = hf.Name;
                    mff.Path = hf.Path;
                    mff.Data = sf.Data;
                    UpdateHeader();
                    return true;
                }
            }
            return false;
        }

        public override void CommitChanges()
        {
            SFAStream.Flush();
            SFAStream.WriteManagedFiles(0, Encoding, _ManagedFiles.ToArray());
        }

        public override bool AddManagedFile(ManagedFile mf)
        {
            _ManagedFiles.Add(mf);
            UpdateHeader();
            return true;
        }

        public override bool AddFile(HeaderFile hf, StorageFile sf)
        {
            _ManagedFiles.Add(new ManagedFile(hf.Name, hf.Path, sf.Data));
            UpdateHeader();
            return true;
        }

        public override bool RemoveManagedFile(ManagedFile mf)
        {
            var state = _ManagedFiles.Remove(mf);
            UpdateHeader();
            return state;
        }

        public override bool RemoveFile(HeaderFile hf)
        {
            var mco = _ManagedFiles.Count;
            for (var i = 0; i < mco; i++)
            {
                var mff = _ManagedFiles[i];
                if (mff.Name == hf.Name && mff.Path == hf.Path)
                {
                    _ManagedFiles.RemoveAt(i);
                    UpdateHeader();
                    return true;
                }
            }
            return false;
        }
    }
}
