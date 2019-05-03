using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Equipe
    {
        #region Construct
        public Equipe()
        {
            for(int _ = 0; _ < 3; _++)
            {
                _equipe.Add(new Pokemon());
            }
        }
        #endregion

        #region Attributes
        public List<Pokemon> _equipe = new List<Pokemon>();
        #endregion
        
        #region Methods
        public bool IsKo()
        {
            foreach(Pokemon p in _equipe)
            {
                if (p._isKo == false) return false;
            }
            return true;
        }
        #endregion
    }
}
