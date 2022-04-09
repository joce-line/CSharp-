using PersonagensHP.src;
using System;

namespace PersonagensHP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem harry = new Personagem("Harry Potter", "Grifinória", "cervo");
            Personagem hermione = new Personagem("Hermione Granger", "Grifinória", "lontra");
            Personagem rony = new Personagem("Rony Weasley", "Grifinória", "cachorro terrier");
            Personagem severo = new Personagem("Severo Snape", "Sonserina", "corça");

            Console.WriteLine($"{harry.Nome} é da casa de {harry.CasaHogwarts}, seu patrono é {harry.Patrono}.");
            Console.WriteLine($"{hermione.Nome} é da casa de {hermione.CasaHogwarts}, seu patrono é {hermione.Patrono}.");
            Console.WriteLine($"{rony.Nome} é da casa de {rony.CasaHogwarts}, seu patrono é {rony.Patrono}.");
            Console.WriteLine($"{severo.Nome} é da casa de {severo.CasaHogwarts}, seu patrono é {severo.Patrono}.");

            harry.Defender("Expelliarmus");
            hermione.Atacar("Petrificus Totalus");
            severo.Atacar("Sectumsempra");
            rony.Mover();
            rony.Pegar();
        }
    }
}
