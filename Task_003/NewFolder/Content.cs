using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Content
    {
        public string _content;

        public void Show() 
        { 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" " + $"{_content}" + " ");
        }
    }
}
