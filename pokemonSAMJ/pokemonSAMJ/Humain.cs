using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonSAMJ
{
    class Humain : Joueur
    {
        public Humain(string nom) : base(nom) { }

        /// <summary>
        /// ChoisirPokemon : procédure permettant au joueur de choisir un pokemon dans son équipe
        /// </summary>
        public override void ChoisirPokemon()
        {
            Console.WriteLine("Choisir un Pokemon :");
            foreach (Pokemon pokemon in _equipe)
            {
                Console.WriteLine("\n{1} : {2}", pokemon._id, pokemon._nom);
            }
            int choix= int.Parse(Console.ReadLine());
            foreach (Pokemon pokemon in _equipe)
            {
                if (pokemon._id == choix && pokemon.verifKo())
                    pokemon.activer();
            }
        }
    }

}
