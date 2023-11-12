using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LABY_3
{
    internal class Student:Osoba
    {
        public string NrAlbumu { get; set; }

        public Student(string firstName, string lastName, int age, string NrAlbumu):base(firstName, lastName, age)
        {
            this.NrAlbumu = NrAlbumu;
        }
        public override string? ToString()
        {
            return base.ToString() + $"\nNumer albumu: {NrAlbumu}";
        }
    }
}
