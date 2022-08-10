using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Author
    {
        public string _author;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{_author}\n");
        }
    }
}
