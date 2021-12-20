using SFA.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAEditor.Managers
{
    public sealed class UnmanagedManager : Manager
    {
        public UnmanagedManager(Editor editor) : base(editor)
        {
        }

        public override bool AddFile(HeaderFile hf, StorageFile sf)
        {
            throw new NotImplementedException();
        }

        public override bool AddManagedFile(ManagedFile mf)
        {
            throw new NotImplementedException();
        }

        public override void CommitChanges()
        {
            throw new NotImplementedException();
        }

        public override bool GetHeaderFile(string path, out HeaderFile hf)
        {
            throw new NotImplementedException();
        }

        public override bool GetManagedFile(string path, out ManagedFile mf)
        {
            throw new NotImplementedException();
        }

        public override bool GetStorageFile(HeaderFile hf, out StorageFile sf)
        {
            throw new NotImplementedException();
        }

        public override bool InitNewSFA()
        {
            throw new NotImplementedException();
        }

        public override bool OpenSFA()
        {
            throw new NotImplementedException();
        }

        public override bool RemoveFile(HeaderFile hf)
        {
            throw new NotImplementedException();
        }

        public override bool RemoveManagedFile(ManagedFile mf)
        {
            throw new NotImplementedException();
        }

        public override bool SetFile(HeaderFile hf, StorageFile sf, string path)
        {
            throw new NotImplementedException();
        }

        public override bool SetFile(HeaderFile hf, StorageFile sf)
        {
            throw new NotImplementedException();
        }

        public override bool SetManagedFile(ManagedFile fm)
        {
            throw new NotImplementedException();
        }

        public override bool SetManagedFile(ManagedFile fm, string path)
        {
            throw new NotImplementedException();
        }
    }
}
