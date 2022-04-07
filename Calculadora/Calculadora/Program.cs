using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à Calculadora!");
            Console.WriteLine("Deseja ligar? (s/n) ");
            string ligar = Console.ReadLine();
                        
                while (ligar == "s")
                {
                                
                    Console.WriteLine("Digite o primeiro número: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o operador: ");
                    string op = Console.ReadLine();
                    Console.WriteLine("Digite o segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case "+":
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                            break;
                        case "-":
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                            break;
                        case "*":
                            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                            break;
                        case "/":
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                            break;
                        default:
                            Console.WriteLine("Operador incorreto.");
                            break;

                    }
                
                    Console.WriteLine("Deseja continuar? (s/n) ");
                    string desligar = Console.ReadLine();

                if (desligar != "s")
                {
                    break;
                }

                }

            Console.WriteLine("Até a próxima!");

        }
    }
}
