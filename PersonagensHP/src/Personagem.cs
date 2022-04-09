using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonagensHP.src
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string CasaHogwarts { get; set; }
        public string Patrono { get; set; }
        

        public Personagem(string _nome, string _casahogwarts, string _patrono)
        {
            Nome = _nome;
            CasaHogwarts = _casahogwarts;
            Patrono = _patrono;
            
        }
        public void Defender (string defesa)
        {
            Console.WriteLine($"{defesa}");
        }
        public void Atacar (string ataque)
        {
            Console.WriteLine($"{ataque}!");
        }
        public void Mover ()
        {
            Console.WriteLine("Para onde ir? ");
            string lugar = Console.ReadLine();
            Console.WriteLine($"Vou aparatar para {lugar}...");
        }
        public  void Pegar()
        {
            Console.WriteLine("O que quer pegar?");
            string objeto = Console.ReadLine();
            Console.WriteLine($"Accio {objeto}!");
        }
        


    }
}
