using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Title
    {
        public string _title;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_title);
        }
    }
}
