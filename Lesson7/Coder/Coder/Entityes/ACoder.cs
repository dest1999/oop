using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder
{
    public class ACoder : ICoder
    {
        public string Encode(string flatString)
        {
            return ConvertMethod(flatString, true);
        }
        public string Decode(string codedString)
        {
            return ConvertMethod(codedString, false);
        }

        private string ConvertMethod(string inputString, bool needToEncode)
        {
            StringBuilder sb = new();
            int index;
            bool symbolFound;
            foreach (char currentSymbol in inputString)
            {
                symbolFound = false;
                for (int i = 0; i < Alphabeth.Symbols.Length; i++)
                {
                    if (Alphabeth.Symbols[i].Contains(currentSymbol))
                    {
                        index = Alphabeth.Symbols[i].IndexOf(currentSymbol);

                        if (needToEncode && (++index > Alphabeth.Symbols[i].Length - 1))
                        {
                            index = 0;
                        }
                        else if (!needToEncode && (--index < 0))
                        {
                            index = Alphabeth.Symbols[i].Length - 1;
                        }

                        sb.Append(Alphabeth.Symbols[i][index]);
                        symbolFound = true;
                        break;
                    }
                }
                if (!symbolFound)
                {
                    sb.Append(currentSymbol);
                }
            }

            return sb.ToString();
        }
    }
}
