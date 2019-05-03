using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Humain : Joueur
    {
        #region Construct
        public Humain()
        {

        }
        #endregion

        #region Methods
        public override void ChoosePoke()
        {
            int ind = 0;
            Console.WriteLine("Choisir un poke");
            while (pokeCourant == null || pokeCourant._isKo)
            {
                ind = int.Parse(Console.ReadLine());
                if (ind < 3 && equipe._equipe[ind]._isKo == false) pokeCourant = equipe._equipe[ind]; // Dans le futur rentre indexable le type equipe et rendre private l'equipe liste !!!!
            }
        }
        #endregion
    }
}
