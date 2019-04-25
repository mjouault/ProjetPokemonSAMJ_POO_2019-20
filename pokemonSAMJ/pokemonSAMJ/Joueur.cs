using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonSAMJ
{
    class Joueur
    {
        public readonly string _nom;
        protected List<Pokemon> _equipe;

        public Joueur(string nom)
        {
            _nom = nom;
            _equipe = new List<Pokemon>();

        }

        public List<Pokemon> GenererEqu()
        {
            List<Pokemon> equipe = new List<Pokemon>();
            return equipe;
        }

        public bool GagnerCombat()
        {
            return true;
        }

        virtual public void ChoisirPokemon()
        {
        }
    }



}
