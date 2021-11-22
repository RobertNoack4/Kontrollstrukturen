using System;
using System.Diagnostics;
using System.Text;

namespace Kontrollstrukturen
{
    internal class Program
    {   
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine();
            
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    if (i != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            
            Console.WriteLine();

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            int maxZahl;
            int counter;
            Console.WriteLine("Bitte geben sie die Zahl ein bis zu der sie alle Primzahlen wissen möchten!");
            maxZahl = Convert.ToInt32(Console.ReadLine());
            counter = 0;
            for (int i = 2; i <= maxZahl; i++)
            {
                if (IstPrim(i) == true)
                {
                    Console.WriteLine(i);
                    counter += 1;
                }
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Anzahl aller Primzahlen:");
            Console.WriteLine(counter);
            
            Console.WriteLine();

            string binary = " ";
            int input;
            StringBuilder builder = new StringBuilder();
            decimal test = 0;
            
            Console.WriteLine("geben sie die Zahl ein welche sie als Binaerzahl haben moechten!");
            input = Convert.ToInt32(Console.ReadLine());

            while (input != 1)
            {
                if (input % 2 == 0)
                {
                    builder.Append(0);
                    input = input / 2;
                }
                else
                {
                    builder.Append(1);
                    test = input / 2;
                    input = Convert.ToInt32(Math.Floor(test));
                }
            }

            builder.Append(1);
            int length = builder.Length;

            while (length > 0)
            {
                binary = binary + builder[length - 1];
                length = length - 1;
            }
            Console.WriteLine(binary);  
        }

        static bool IstPrim(int zahl)
        {
            if (zahl == 2)
            {
                return true;
            }

            if (zahl % 2 == 0)
            {
                return false;
            }

            var grenze = Math.Floor(Math.Sqrt(zahl));
            
            for (int i = 3; i <= grenze; i+= 2)
                if (zahl % i == 0)
                {
                    return false;
                }

            return true;
        }
    }
}