using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABY_3
{
    internal class Book
    {
        public string title;
        public Person author;
        public int dataWydania;

        public Book(string title, Person author, int dataWydania)
        {
            this.title = title;
            this.author = author;
            this.dataWydania = dataWydania;
        }
        public void View()
        {
            Console.WriteLine($"Tytuł: {title}\n");
            author.View();
            Console.WriteLine($"Data wydania {dataWydania}");
        }
    }
}
