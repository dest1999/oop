using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder
{
    internal interface ICoder
    {
        string Encode(string flatString);
        string Decode(string codedString);

    }
}
