using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Pokemon
    {
        #region Construct
        public Pokemon()
        {
            _nom = "pikachu";
            _ptVie = 20;
            _startPv = _ptVie;
            _force = 20;
            _type = "elec";
            _faiblesse = "eau";
            _isKo = false;
        }
        #endregion

        #region Attributes
        string _nom;
        int _ptVie;
        int _startPv;
        int _force;
        string _type;
        string _faiblesse;
        internal bool _isKo;

        internal void ResetStats()
        {
            _ptVie = _startPv;
        }
        #endregion

        #region Properties
        public int PtVie
        {
            get { return _ptVie; }
            set { _ptVie = value < 0 ? 0 : value; }
        }
        #endregion

        #region Methods
        public void Attaquer(Pokemon p)
        {
            Console.WriteLine("un poke attaque");
            p.PtVie -= this._force;
            if (p.PtVie == 0) p._isKo = true;
        }
        #endregion
    }
}
