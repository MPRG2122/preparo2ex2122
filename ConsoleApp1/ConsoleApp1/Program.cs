using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0;
            int menor = 0;
            Console.WriteLine("Introduce un número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("-------");

            if (num1 > num2)
            {
                mayor = num2;
                menor = num1;
            }
            else
            {
                mayor = num1;
                menor = num2;
            }
            Console.WriteLine("El mayor es:" + mayor + "\nEl menor es: " + menor);
            Console.ReadKey();
        }
    }
}
