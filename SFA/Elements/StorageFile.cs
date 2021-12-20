using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA.Elements
{
    public struct StorageFile
    {
        public byte[] Data;

        public StorageFile(byte[] data)
        {
            Data = data;
        }
    }
}
