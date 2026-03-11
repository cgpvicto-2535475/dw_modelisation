using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque_Modelisation
{
    /// <summary>
    /// Classe de tenue, crée une tenue selon une liste de vêtements, et lui attribue un score selon des facteurs
    /// </summary>
    public class Tenue
    {
        private List<Vetement> _vetements;
        private int _score;

        /// <summary>
        /// TODO faire le summary
        /// </summary>
        /// <param name="vetements"></param>
        /// <exception cref="Exception"></exception>
        public Tenue(List<Vetement> vetements)
        { 
            //on vérifie si il y a du papier toilette
            if (!ValiderTenue())
            {
                //sinon je ne commence pas la job
                throw new Exception("Vos vêtements ne constitue pas une tenue");
            }

            Vetements = vetements;
            Score = CalculerScore();
        }

        /// <summary>
        /// Cette méthode calcule le score d'une tenue
        /// On fait toute les paires possible de vêtement.
        /// pour chacune des paires :
        /// si la paire de vetements sont de la meme saison on donne un score de +1
        /// si la paire de vetements sont de la meme catégorie on donne un score de +1
        /// </summary>
        /// <returns>On retourne le total de toute les combinaisons</returns>
        private int CalculerScore()
        {
            int score = 0;

            for (int i = 0; i < Vetements.Count; i++)
            {
                for (int j = i + 1; j < Vetements.Count - i; j++)
                {
                    if (Vetements[i].Saison == Vetements[j].Saison)
                    {
                        score += 1;
                    }
                    if (Vetements[i].Categorie == Vetements[j].Categorie)
                    {
                        score += 1;
                    }
                }
            }
            return score;
        }

        /// <summary>
        /// Cette méthode permet de valider si une tenue est adéquate,
        /// Elle vérifie chaque vêtement dans une tenue
        /// </summary>
        /// <returns>Vrai si la tenue est valide, faux sinon</returns>
        private bool ValiderTenue()
        {
            bool haut = false;
            bool bas = false;
            bool chaussure = false;
            bool valide = false;

            for (int i = 0; i < Vetements.Count; i++)
            {
                if (Vetements[i].Type == Type.HAUT)
                {
                    haut = true;
                }
            }

            for (int i = 0; i < Vetements.Count; i++)
            {
                if (Vetements[i].Type == Type.BAS)
                {
                    bas = true;
                }
            }

            for (int i = 0; i < Vetements.Count; i++)
            {
                if (Vetements[i].Type == Type.CHAUSSURE)
                {
                    chaussure = true;
                }
            }

            if (haut && bas && chaussure)
                valide = true;

            return valide;
        }

        /// <summary>
        /// Accesseur de vêtement
        /// </summary>
        private List<Vetement> Vetements
        {
            get => _vetements;
            set
            {
                _vetements = value;
            }
        }

        /// <summary>
        /// Accesseur du score
        /// </summary>
        public int Score
        {
            get => _score;
            private set
            {
                value = CalculerScore();
                _score = value;
            }
        }
    }
}
