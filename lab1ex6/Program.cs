using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program care va afisa in ordine descrescatoare 3 numere de la tastatura.*/

            int n1;
            int n2;
            int n3;

            Console.WriteLine("Introduceti primul numar:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar:");
            n3 = int.Parse(Console.ReadLine());



            if (n1 > n2 && n2 > n3 && n3 < n1)
            {
                Console.WriteLine("\n" + n1 + " " + n2 + " " + n3);
            }



            else if (n1 > n2 && n2 < n3 && n3 < n1)
            {
                Console.WriteLine("\n" + n1 + " " + n3 + " " + n2);
            }



            else if (n1 > n2 && n2 < n3 && n3 > n1)
            {
                Console.WriteLine("\n" + n3 + " " + n1 + " " + n2);
            }



            else if (n1 < n2 && n2 < n3 && n3 > n1)
            {
                Console.WriteLine("\n" + n3 + " " + n2 + " " + n1);
            }



            else if (n1 < n2 && n2 > n3 && n3 > n1)
            {
                Console.WriteLine("\n" + n2 + " " + n3 + " " + n1);
            }



            else if (n1 < n2 && n2 > n3 && n3 < n1)
            {
                Console.WriteLine("\n" + n2 + " " + n1 + " " + n3);
            }

            else if (n1 == n2 && n2 == n3 && n3 == n1)
            {
                Console.WriteLine("\n" +"Toate cele 3 numere sunt egale: " + n1 + "=" + n2 + "=" + n3);
            }
        }
    }
}
