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
        public int _id=-1; // Permet au joueur de choisir facilement un de ses Pokemon. Static ??? public ???
        protected int _pv;
        public readonly string _type;
        public int _puissance;
        protected readonly string _faiblesse;
        protected bool isActif;
        protected bool isKo;

        public Pokemon (string nom, int pv, int puissance, string type, string faiblesse)
        {
            _nom = nom;
            _pv = pv;
            _puissance = puissance;
            _type = type;
            _faiblesse = faiblesse;
            isActif = false;
            isKo = false;
            _id++;
        }

        /// <summary>
        ///attaquer : Procédure permettant à un Pokemon d'attaquer un adversaire. Prend en paramètre le Pokemon adversaire
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public void attaquer(Pokemon p)
        {
            int degat = _puissance;
            if (p._faiblesse==_faiblesse)
            {
                degat *= 2;
            }
            if (degat <= p._pv)
            {
                p._pv -= degat;
                Console.WriteLine("{0} attaque ... outch - {1} PV pour {2} qui est maintenant à {3} PV ", _nom, degat, p._nom, p._pv);
            }
            else
            {
                p.isKo = true;
                p._pv = 0;
                Console.WriteLine(p._nom + "est Ko!");
            }
        }

        public bool verifKo()
        {
            return isKo;
        }

        /// <summary>
        /// Réinitialise les pv d'un pokemon une fois celui-ci Ko (une fois match terminé)
        /// </summary>
        public void reinitialiser()
        {

        }

        public void activer()
        {
            isActif = true;
        }

    }
}
