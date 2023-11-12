using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Iga", "Świątek", 32);
            osoba.View();


            //1 sposób
            Osoba[] osobyArray = new Osoba[3];
            osobyArray[0] = new Osoba("Robert", "Lewandowski", 31);
            osobyArray[1] = new Osoba("Andrzej", "Dudu", 45);
            osobyArray[2] = new Osoba("Jarosław", "Kaczyński", 55);

            foreach(Osoba item in osobyArray)
            {
                //item.View();
            }
            //2 sposób
            Osoba[] osobyArray1 = new Osoba[]
            {
                new Osoba("Jan", "Kowalski", 25),
                new Osoba("Jan", "Śpiewak", 40),
            };
            //3 sposób
            Osoba[] osobyArray2 = new Osoba[3];
            string[] firstName = { "Jan", "Jan" };
            string[] lastName = { "Kowalski", "Śpiewak" };
            int[] age = { 23, 40 };
            for (int i = 0; i < osobyArray2.Length; i++)
            {
                osobyArray2[i] = new Osoba(firstName[i], lastName[i], age[i]);
            }
            foreach(Osoba item in osobyArray2)
            {
                item.View();
            }
        }
    }
}
