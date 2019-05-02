using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonSAMJ
{
    class Tournoi
    {
        // J'ai écrit ca rapidement j'ai gérer aucune sécurité et propreté c'est juste pour que tu ai l'idée et que tu me donne ton avis dessus !
        public Tournoi()
        {
            joueursActifs = null;// La on met la liste des 16 joueurs
        }

        List<Joueur> joueursActifs = new List<Joueur>();
        List<Joueur> joueursTemporaires = new List<Joueur>();
        List<Match> matchsRestants = new List<Match>();
        //La grâce au joueur on rempli la liste avec le constructeur de Match qui à 2 surcharges

        /*
        IniTtournoi(){
            prend les joueurs deux par deux dans l'orde et crée à chaque
            fois un nouveau match et l'ajoute à la liste des matchs restants
        }
        
        PlayRound(){
            pour chaque match on appelle la fonction jouer qui réalise le match
            : match.jouer();
        }

        Pour moi on peut se contenter de ca dans la classe tournoi.
        Comme ca après ds le code du jeu on crée un objet tournoi
        on fait le myTournoi.InitTournoi();
        puis tant qu'il reste des match à jouer on 
        myTournoi.PlayRound();




        */
    }
}
