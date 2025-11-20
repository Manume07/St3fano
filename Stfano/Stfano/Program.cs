using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stfano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();
            Persona persona = new Persona(nome, cognome);
            persona.StampaNomeCompleto();
        }
    }
}
