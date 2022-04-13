using System;
using Matematica.src;
using System.Collections.Generic;


namespace Matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

                                    
            Forma Triangulo = new Triangulo("Triângulo", 12, 2);
            Forma Quadrado = new Quadrado("Quadrado", 5, 5 );
            Forma Retangulo = new Retangulo("Retângulo", 23, 15);

           
            Console.WriteLine("Digite a forma geométrica: ");

            string fGeo = Console.ReadLine();

            if (fGeo == "triangulo")
            {
                Console.WriteLine($"O {Triangulo.Nome} tem uma base de {Triangulo.Base} com altura de {Triangulo.Altura} e sua área é {Triangulo.Area()}");
            }
            else if (fGeo == "quadrado")
            {
                Console.WriteLine($"O {Quadrado.Nome} tem uma base de {Quadrado.Base} com altura de {Quadrado.Altura} e sua área é {Quadrado.Area()}");
            }
            else if (fGeo == "retangulo")
            {
                Console.WriteLine($"O {Retangulo.Nome} tem uma base de {Retangulo.Base} com altura de {Retangulo.Altura} e sua área é({Retangulo.Area()}");
            }
            else
            {
                Console.WriteLine("Forma Geométrica não adicionada.");
            }
            
            
            


        }
    }
}
