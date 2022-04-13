using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.src
{
    internal class Gato : Animal
    {
        public Gato() { }

        public Gato(string nome, string cor, string classificacao ) : base  (nome, cor, classificacao) { }

        public override void Comunicar(string comunicacao)
        {
            
            Console.WriteLine ($"{Nome} diz {comunicacao}");
        }
    }
}
