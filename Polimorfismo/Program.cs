using System;
using System.Collections.Generic;
using Polimorfismo.src;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animais!");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Leao("Leão", "Laranja", "Terrestre"),
                    new Ave("Ave", "Amarelo", "Aéreo"),
                    new Peixe("Peixe", "Vermelho", "Aquático"),
                    new Cachorro("Cachorro", "Marrom", "Terrestre")
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Nome == "Leão")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor} e é um animal {animal.Classificacao}");
                    animal.Comunicar("ROAAAAAAR..");
                }
                else if (animal.Nome == "Ave")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor} e é um animal {animal.Classificacao}");
                    animal.Comunicar("piu-piu piopio pipio!");
                }
                else if (animal.Nome == "Peixe")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor} e é um animal {animal.Classificacao}");
                    animal.Comunicar("glub glub...");
                }
                else if (animal.Nome == "Cachorro")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor} e é um animal {animal.Classificacao}");
                    animal.Comunicar("Au au au!");
                }
            }
            
            

        }
    }
}
