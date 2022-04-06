using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do {n}: ");

            for (int x = 1; x <=10 ; x++)
            {
                Console.WriteLine($"{n} x {x} = {n*x}");
              
            }
        }
    }
}
