using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournoi turnament = new Tournoi();

            turnament.Jouer();
            Console.WriteLine("Round Ended");
            turnament.Jouer();
            Console.WriteLine("Round Ended");
            turnament.Jouer();
            Console.WriteLine("Round Ended");
            turnament.Jouer();
            Console.WriteLine("Tournoi Ended");
        }
    }
}
