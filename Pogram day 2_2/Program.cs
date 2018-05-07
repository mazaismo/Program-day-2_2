using System;

namespace Pogram_day_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String gads;

            String menesis;

            String diena;

            
            string jaut1 = "juusu dzimsanas gads?";

            string jaut2 = "juusu dzimsanas menesis?";

            string jaut3 = "juusu dzimsanas diena?";


            Console.WriteLine(jaut1);


            gads = Console.ReadLine();

            Console.WriteLine(jaut2);

            menesis = Console.ReadLine();

            Console.WriteLine(jaut3);

            diena = Console.ReadLine();


            Console.WriteLine("dzimsanas gads " + gads);

            Console.WriteLine("dzimsanas menesis " + menesis);

            Console.WriteLine("dzimsanas diena " + diena);

            Console.ReadLine();

        }
    }
}
