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
                    new Leao("Leao do Proerd", "Laranja", "Terrestre"),
                    new Ave("Ave do mato", "Amarelo", "Aéreo"),
                    new Peixe("Peixe Dori", "Vermelho", "Aquático"),
                    new Cachorro("Cachorro Coragem", "Rosa", "Terrestre")
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Nome == "Leao do Proerd")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor} e é um animal {animal.Classificacao}");
                    animal.Comunicar("Ensinando a dizer não!");
                }
                else if (animal.Nome == "Ave do mato")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor} e é um animal {animal.Classificacao}");
                    animal.Comunicar("piu-piu piopio pipio!");
                }
                else if (animal.Nome == "Peixe Dori")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor} e é um animal {animal.Classificacao}");
                    animal.Comunicar("Continue a nadar....");
                }
                else if (animal.Nome == "Cachorro Coragem")
                {
                    Console.WriteLine($"{animal.Nome} tem a cor {animal.Cor} e é um animal {animal.Classificacao}");
                    animal.Comunicar("Murieeel!");
                }
            }
            
            

        }
    }
}
