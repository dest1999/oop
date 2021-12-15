using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder
{
    public class BCoder : ICoder
    {
        public string Encode(string flatString)
        {
            StringBuilder sb = new();
            int index;
            bool symbolFound;
            foreach (char item in flatString)
            {
                symbolFound = false;
                for (int i = 0; i < Alphabeth.Symbols.Length; i++)
                {
                    if (Alphabeth.Symbols[i].Contains(item))
                    {
                        index = Alphabeth.Symbols[i].IndexOf(item);
                        sb.Append(Alphabeth.Symbols[i][^++index]);
                        symbolFound = true;
                        break;
                    }
                }

                if (!symbolFound)
                { 
                    sb.Append(item); 
                }
            }

            return sb.ToString();
        }

        public string Decode(string codedString)
        {
            return Encode(codedString);
        }
    }
}
