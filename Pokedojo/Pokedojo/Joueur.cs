using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    abstract class Joueur
    {
        #region Attributes
        public Equipe equipe = new Equipe();
        public Pokemon pokeCourant;
        #endregion

        #region Methods
        public abstract void ChoosePoke();

        internal void ResetTeam()
        {
            //Rendre equipe enum et enlever l'accès à equipe et la relettre en privée
            foreach(Pokemon p in equipe._equipe)
            {
                p.ResetStats();
            }
        }
        #endregion
    }
}
