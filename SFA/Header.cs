using SFA.Elements;
using System;

namespace SFA
{
    public class Header
    {
        public HeaderFile[] Files;

        public Header(HeaderFile[] fs)
        {
            Files = fs;
        }
    }
}
