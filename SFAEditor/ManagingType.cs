using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAEditor
{
    public enum ManagingType : byte
    {
        /// <summary>
        /// Slow load.
        /// </summary>
        Managed,

        /// <summary>
        /// Fast load.
        /// </summary>
        Unmanaged,
    }
}
