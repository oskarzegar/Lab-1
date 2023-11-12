using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Osoba
    {
        //pola klasy
        string firstName, lastName;
        public int age;

        //konstruktor
        public Osoba(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //metoda klasy
        public void View() => Console.WriteLine($"Imię: {firstName} \nNazwisko: {lastName} \nWiek:{age}");
    }
}
