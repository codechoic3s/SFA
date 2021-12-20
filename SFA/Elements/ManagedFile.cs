using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA.Elements
{
    public class ManagedFile
    {
        public string Name;
        public string Path;
        public virtual byte[] Data { get; set; }

        public ManagedFile(string name, string path, byte[] data)
        {
            Name = name;
            Path = path;
            Data = data;
        }

        public static ManagedFile FromRaw(HeaderFile hf, byte[] data)
        {
            return new ManagedFile(hf.Name, hf.Path, data);
        }
    }
}
