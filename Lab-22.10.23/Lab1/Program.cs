using System.Threading.Channels;
using System.Xml.Schema;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        ViewMenu:
            Console.WriteLine("===================Kalkulator===================");
            Console.WriteLine("=================== 1. Suma ===================");
            Console.WriteLine("=================== 2. Różnica ===================");
            Console.WriteLine("=================== 3. Iloczyn ===================");
            Console.WriteLine("=================== 4. Iloraz ===================");
            Console.WriteLine("=================== 5. Potęga ===================");
            Console.WriteLine("=================== 6. Pierwiastek ===================");
            Console.WriteLine("=================== 7. Funkcje trygonomatryczne dla zadanego kąta ===================");
            Console.WriteLine("=================== 8. Wyjście ===================");
            Console.WriteLine("Twój wybór: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1: Suma();
                    break;
                case 2: Roznica();
                    break;
                case 3: Iloczyn();
                    break;
                case 4: Iloraz();
                    break;
                case 5: Potega();
                    break;
                case 6: Pierwiastek();
                    break;
                case 7: Trygonomatria();
                    break;
                case 8: Zamknij();
                    break;
                default: 
                    Console.WriteLine("Błędny wybór, spróbuj ponownie");
                    goto ViewMenu;
            }
        }
        static void Zamknij()
        {
            System.Environment.Exit(1);
        }
        static void Suma()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            Console.WriteLine($"\nSuma: {a + b}");
        }
        static void Roznica()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            Console.WriteLine($"\nRóżnica: {a - b}");
        }
        static void Iloczyn()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            Console.WriteLine($"\nIloczyn: {a * b}");
        }
        static void Iloraz()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            if (b == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0");
            }
            else
            {
                Console.WriteLine($"\nIloraz: {a / b}");
            }
        }
        static void Potega()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            Console.WriteLine($"\nSuma: {Math.Pow(a, b)}");
        }
        static void Pierwiastek()
        {
            double a = DoubleInput('A'); 
            Console.WriteLine($"\nSuma: {Math.Sqrt(a)}");
        }
        static void Trygonomatria()
        {
            double a  = DoubleInput('A');
            double radiany = (a * Math.PI) / 180;
            Console.WriteLine("Cosinus "+a+": " + Math.Cos(radiany));
            Console.WriteLine("Sinus " + a + ": " + Math.Sin(radiany));
            Console.WriteLine("Tangens " + a + ": " + Math.Tan(radiany));
            Console.WriteLine("Cotangens " + a + ": " + 1/Math.Tan(radiany));
        }

        static void Zadanie1()
        {
            double a = DoubleInput('a');
            double b = DoubleInput('b');
            double c = DoubleInput('c');
            double delta, x1, x2;
            if (a == b)
            {
                Console.WriteLine("To nie jest równanie kwadratowe");
            }
            else
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiązań w zbiorze liczb rzeczywistych");
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine(x1);
                }
                else
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2);
                }

            }
        }
        static double DoubleInput(char n)
        {
            Console.WriteLine("Podaj wartość " + n + ": ");
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }
    }
}