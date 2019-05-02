using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonSAMJ
{
    //Match opposant 2 joueurs jusqu'à ce que l'un perdent ses 3 pokemons (Ko)
    abstract class Match
    {
        #region Constructor
        public Match(Humain j1, Ordi j2)
        {
            _j1 = j1; _j2 = j2;
        }

        public Match(Ordi j1, Ordi j2)
        {
            _j1 = j1; _j2 = j2;
        }
        #endregion

        #region Attributes
        Joueur _j1;
        Joueur _j2;
        Joueur currentJoueur;
        Joueur standByJoueur;
        #endregion

        #region Methods
        /*
        public Joueur jouer(){
            
            choisir qui commence celui la devient le joueur courant.
            on fait aussi choisir des poke au deux joueur pour initialiser 
            les pokemon courrant en gros les premiers à agir...

            tant que(l'équipe du joueur courant n'est pas KO){
                
                if(joueurCourant.PokeCourant isKO ou is null){
                    joueur.ChoisirPoke();
                }

                currentJoueur.currentPoke.attaque(standByJoueur.currentPoke);
 
                switchPlayers(); On change le joueur actif avant de continuer la boucle
            }

            return standByJoueur();

            c'est forcément lui qui gagne car si on sors de la boucle ca veux dire
            que l'équipe du joueur courant est KO entiérement car c'est la condition
            du while.
        }

       Cette fonction permet de switcher le joueur courant tout au long du match

        public Joueur switchPlayers(){
            Joueur tempo = currentJoueur;
            currentJoueur = standByJoueur;
            standByJoueur = tempo;
        }

            Pareil voila ce que je pens epeut aller dans le corps du match après
            évidemment c'est cette partie la du code qui va s'étoffer lorsque l'on
            va rajouter les règles supplémentaires. Mais du coup en vrai on à pas
            besoin de grand chose pour que ca marche, il faut :
            - Un joueur qui possède deux chose: 
                - Une équipe
                - Un pokemonCourant ou actif n'importe.
            - Une équipe:
                - Avec un méthode pour savoir quand elle est hors jeu (3 Poke KO)
            - Un pokémon:
                - Avec les data de la base de donnée (je me met à cette partie demain)
                - Une méthode pour attaquer d'autre poke
                - Un moyen de savoir quand il est KO
        
        En vrai il ne faut que ca dans ce jeu je pense, c'est le stricte minimum pour
        implémenter le tournoi avec les règles de bases et si tu veux on commence par
        rendre ça fonctionnel si on arrive à se trouver une créneaux on peut rendre
        ca fct en deux trois heures je pense et après on pourra ajouter les règles
        supplémentaires et l'interface.
             
          */
        #endregion


        public Joueur Choisir1er()
        {
            Random R = new Random();
            int choix1er = R.Next(0, 2); ;

            if (choix1er == 1)
                Console.WriteLine(_joueurs[0]._nom + "commence !");
            else
                Console.WriteLine(_joueurs[1]._nom + "commence !");
            //return j1 ou j2 en fct de qui commence
        }
    }


}
