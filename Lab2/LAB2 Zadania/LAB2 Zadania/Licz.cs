using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_Zadania
{
    class Licz
    {
        private double value;

        private double Dodaj(double a)
        {
            return value += a;
        }
        private double Odejmij(double a)
        {
            return value -= a;
        }

        public Licz(double value)
        {
            this.value = value;
        }

        public void View(double a)
        {
            Console.WriteLine($"Wartość początkowa: {value}\nWartość po dodaniu: {Dodaj(a)}\nWartość po odejmowaniu: {Odejmij(a)}\n");
        }
        public void showValue()
        {
            Console.WriteLine(value);
        }
    }
}
