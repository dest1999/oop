using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder
{
    internal  class Alphabeth
    {
        public static readonly string[] Symbols = new string[]
        {//и сюда отдельным массивом кладём хоть традиционные китайские
             "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
             "abcdefghijklmnopqrstuvwxyz",
             "АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ",
             "абвшдеёжзиклмнопрстуфхцчшщъыьэюя",
             "0123456789"
        };
    }
}
