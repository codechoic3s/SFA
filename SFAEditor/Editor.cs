using SFA;
using SFAEditor.Managers;
using System;
using System.IO;
using System.Text;

namespace SFAEditor
{
    public class Editor
    {
        internal SFAStream SFAStream;
        public Encoding Encoding { get; private set; }

        public Editor()
        {

        }

        private ManagingType _ManagingType;

        public ManagingType ManagingType
        {
            get => _ManagingType;
            set
            {
                var val = value;
                if (val == ManagingType.Managed)
                    Manager = new ManagedManager(this);
                else
                    Manager = new UnmanagedManager(this);
                _ManagingType = val;
            }
        }

        public Manager Manager { get; private set; }

        public void SetStringEncoding(Encoding enc)
        {
            Encoding = enc;
        }

        public bool LoadSFA(string filepath, ManagingType mt)
        {
            if (SFAStream != null)
            {
                UnloadSFA();
            }

            SFAStream = new SFAStream(File.Open(filepath, FileMode.OpenOrCreate));
            ManagingType = mt;

            return true;
        }

        public bool UnloadSFA()
        {
            Manager = null;
            if (SFAStream != null)
            {
                SFAStream.Dispose();
                return true;
            }
            return false;
        }
    }
}
