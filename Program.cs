using System;
using System.IO;

namespace praktyki_apka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb fibonaciego chcesz uzyskać");
            string liczba = Console.ReadLine();
            Console.WriteLine("Ciąg fibonaciego:");
            int x = 0;
            int y = 1;
            int wynik;
            for (int i=0;i<Int16.Parse(liczba);i++){
                wynik = x + y;
                Console.WriteLine(wynik);
                x = y;
                y = wynik;
            }
        }
    }
}
