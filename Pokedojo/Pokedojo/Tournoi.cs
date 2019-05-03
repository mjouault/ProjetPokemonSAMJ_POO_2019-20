using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedojo
{
    class Tournoi
    {
        #region Construct
        public Tournoi()
        {
            _joueursEnJeu = InitJoueurs();
        }
        #endregion

        #region Attributes
        List<Joueur> _joueursEnJeu = new List<Joueur>();
        List<Match> _matchsRestants = new List<Match>();
        List<Joueur> _gagnants = new List<Joueur>();
        #endregion

        #region Methods
        List<Joueur> InitJoueurs()
        {
            List<Joueur> _joueurs = new List<Joueur>();
            for (int _ = 0; _ < 15; _++)
            {
                _joueurs.Add(new Ordi());
            }
            _joueurs.Add(new Humain());
            return _joueurs;
        }
        List<Match> FaireMatch()
        {
            List<Match> _matchs = new List<Match>();
            for(int i = 0; i < _joueursEnJeu.Count; i+=2)
            {
                _matchs.Add(new Match(_joueursEnJeu[i], _joueursEnJeu[i + 1]));
            }
            return _matchs;
        }
        public void Jouer()
        {
            Console.WriteLine("Il reste : " + _joueursEnJeu.Count + " joueurs");
            _matchsRestants = FaireMatch();
            Console.WriteLine("qui s'affronte en : " + _matchsRestants.Count + " matchs");
            foreach (Match match in _matchsRestants)
            {
                _gagnants.Add(match.Jouer());
            }
            _joueursEnJeu = _gagnants;
            _gagnants = new List<Joueur>();
            foreach (Joueur j in _joueursEnJeu) j.ResetTeam();
        }
        #endregion
    }
}
