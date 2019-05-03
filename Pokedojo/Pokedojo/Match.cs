using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Match
    {
        #region Construct
        public Match(Joueur j1, Joueur j2)
        {
            _j1 = j1; _j2 = j2;
        }
        /*public Match(Ordi j1, Humain j2)
        {
            _j1 = j1; _j2 = j2;
        }
        public Match(Ordi j1, Ordi j2)
        {
            _j1 = j1; _j2 = j2;
        }
        public Match(Humain j1, Ordi j2)
        {
            _j1 = j1; _j2 = j2;
        }*/
        #endregion

        #region Attributes
        private Joueur _j1;
        private Joueur _j2;
        internal Joueur _joueurCourant;
        internal Joueur _joueurPassif;
        #endregion

        #region Methods
        public Joueur Jouer()
        {
            InitMatch();
            while (!_joueurCourant.equipe.IsKo())
            {
                if (_joueurCourant.pokeCourant._isKo) _joueurCourant.ChoosePoke();
                _joueurCourant.pokeCourant.Attaquer(_joueurPassif.pokeCourant);
                SwitchPlayers();
            }
            return _joueurPassif;
        }
        public void InitMatch()
        {
            //rendre ca aléatoire ou au choix !
            _joueurCourant = _j2;
            _joueurPassif = _j1;
            _joueurCourant.ChoosePoke();
            _joueurPassif.ChoosePoke();
        }
        public void SwitchPlayers()
        {
            Joueur temp = _joueurCourant;
            _joueurCourant = _joueurPassif;
            _joueurPassif = temp;
        }
        #endregion
    }
}
