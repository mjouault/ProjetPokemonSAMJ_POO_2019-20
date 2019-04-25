using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonSAMJ
{
    class Pokemon
    {
        public readonly string _nom;
        protected int _pv;
        public readonly string _type;
        protected readonly string _faiblesse;
        protected bool isActif;
        protected bool isKo;

        public Pokemon (string nom, int pv, string type, string faiblesse)
        {
            _nom = nom;
            _pv = pv;
            _type = type;
            _faiblesse = faiblesse;
            isActif = false;
            isKo = false;
        }

        public bool attaquer()
        {
            bool attaque = false;

            return attaque;
        }

        public bool verifKo()
        {
            if (_pv == 0)
            {
                isKo = true;
                return true;
            }
            else return false;
        }

    }
}
