using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LABY_3
{
    internal class Person
    {
        public string FirstName, LastName;
        public int wiek;

        public Person(string FirstName, string LastName, int wiek)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.wiek = wiek;
        }
        public void View()
        {
            Console.WriteLine($"Imię: {FirstName}\nNazwisko: {LastName}\nWiek: {wiek}");
        }
    }
}
