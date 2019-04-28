using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonSAMJ
{
    /// <summary>
    /// Classe Combat : combat opposant deux Joueurs jusqu'à ce que l'un d'eux perdent ses 3 Pokemons
    /// </summary>
    class Combat
    {
        protected List<Joueur> _joueurs = new List<Joueur>();

        public static void Choisir1er()
        {
            Random R = new Random();
            int choix1er = R.Next(0, 2); ;

            if (choix1er == 1)
                Console.WriteLine(_joueurs[0]._nom + "commence !");
            else
                Console.WriteLine(_joueurs[1]._nom + "commence !");
        }
    }
}
