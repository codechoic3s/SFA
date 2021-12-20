using SFA;
using SFA.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAEditor
{
    public abstract class Manager
    {
        private Editor _Editor;
        protected SFAStream SFAStream => _Editor.SFAStream;
        protected Encoding Encoding => _Editor.Encoding;

        public virtual Header Header { get; }

        protected Manager(Editor editor)
        {
            _Editor = editor;
        }

        public virtual ulong Count { get; }

        /// <summary>
        /// Initialising sfa stream.
        /// </summary>
        /// <returns>State.</returns>
        public abstract bool OpenSFA();
        public abstract bool InitNewSFA();
        public abstract bool GetManagedFile(string path, out ManagedFile mf);
        public abstract bool GetHeaderFile(string path, out HeaderFile hf);
        public abstract bool GetStorageFile(HeaderFile hf, out StorageFile sf);

        public abstract bool SetManagedFile(ManagedFile fm);
        public abstract bool SetManagedFile(ManagedFile fm, string path);
        public abstract bool SetFile(HeaderFile hf, StorageFile sf, string path);
        public abstract bool SetFile(HeaderFile hf, StorageFile sf);

        public abstract bool AddManagedFile(ManagedFile mf);
        public abstract bool AddFile(HeaderFile hf, StorageFile sf);

        public abstract bool RemoveManagedFile(ManagedFile mf);
        public abstract bool RemoveFile(HeaderFile hf);

        public abstract void CommitChanges();
    }
}
