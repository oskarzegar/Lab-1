using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABY_3
{
    internal class Osoba
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public Osoba() { }

        public Osoba(string firstName, string lastName, int age) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string? ToString() 
        {
            return($"Imię: {firstName}\nNazwisko: {lastName}\nWiek: {age}");
        }
    }
}
