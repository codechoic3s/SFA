using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA
{
    internal interface InternalSFAStream
    {
        public Task<bool> ReadAsync(ulong ptr, ref byte[] buffer);
    }
}
