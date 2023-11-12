using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_Zadania
{
    class Sumator
    {
        int[] Liczby;

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        private double Suma()
        {
            double suma = 0;
            foreach(int item in Liczby)
            {
                suma += item;
            }
            return suma;
        }

        private double SumaPodziel2()
        {
            double suma = 0;
            foreach(int item in Liczby)
            {
                if (item % 2 == 0) suma += item; 
            }
            return suma;
        }
        private int IleElementów()
        {
            return Liczby.Length;
        }

        private void View()
        {
            foreach(int item in Liczby)
            {
                Console.WriteLine(item+", ");
            }
        }
        private void Wypisz(int lowIndex, int highIndex)
        {
            if(lowIndex < 0 || highIndex > Liczby.Length)
            {
                View();
            }
            else
            {
                for(int i = lowIndex; i < highIndex; i++)
                {
                    Console.WriteLine(Liczby[i] + ", ");
                }
            }
        }
    }
}
