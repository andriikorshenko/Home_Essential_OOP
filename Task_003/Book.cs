using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Book
    {
        public void BookInitializer(string title, string content, string author)
        {
            Title title1 = new Title();
            title1._title = title;
            title1.Show();

            Content content1 = new Content();
            content1._content = content;
            content1.Show(); 

            Author author1 = new Author();
            author1._author = author;
            author1.Show();
        }
    }
}
