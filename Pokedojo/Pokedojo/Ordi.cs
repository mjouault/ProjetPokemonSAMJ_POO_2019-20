using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Ordi : Joueur
    {
        #region Construct
        public Ordi()
        {

        }
        #endregion

        #region Methods
        public override void ChoosePoke()
        {
            Random r = new Random();
            int ind = r.Next(3);
            while (pokeCourant == null || pokeCourant._isKo)
            {
                ind = r.Next(3);
                if (ind < 3 && equipe._equipe[ind]._isKo == false) pokeCourant = equipe._equipe[ind]; // Dans le futur rentre indexable le type equipe et rendre private l'equipe liste !!!!
            }
            Console.WriteLine("L'ordi à choisi un poke");
        }
        #endregion
    }
}
