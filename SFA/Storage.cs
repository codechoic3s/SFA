using SFA.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA
{
    public class Storage
    {
        public StorageFile[] StorageFiles;

        public Storage(StorageFile[] storage)
        {
            StorageFiles = storage;
        }
    }
}
