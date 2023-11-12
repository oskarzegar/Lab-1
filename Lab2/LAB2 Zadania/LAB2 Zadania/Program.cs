using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Licz[] licz = new Licz[]
            {
                new Licz(1),
                new Licz(2),
                new Licz(3)
            };

        foreach(Licz item in licz)
            {
                item.View(2);
                item.showValue();
            }
        }

    }
}
