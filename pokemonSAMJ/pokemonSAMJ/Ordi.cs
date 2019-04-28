using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonSAMJ
{
    class Ordi : Joueur
    {
        public Ordi(string nom) : base(nom) { }
        public override void ChoisirPokemon()
        {
            Random R = new Random();
            int choix = R.Next(0, 3);

            foreach (Pokemon pokemon in _equipe)
            {
                if (pokemon._id == choix && pokemon.verifKo())
                    pokemon.activer();
                // si le pokemon sélectionné est ko, on recommence  boucle while mais je ne sais comment réintroduire le foreach sans redondance
                else
                {
                    R = new Random();
                    choix = R.Next(0, 3);
                }
            }
        }
    }
}
