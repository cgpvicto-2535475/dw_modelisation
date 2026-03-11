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

        public Tenue(List<Vetement> vetements)
        {
            Vetements = vetements;
            if (ValiderTenue())
                Score = CalculerScore();
            else
                throw new Exception("Vos vêtements ne constitue pas une tenue");

        }
        
        
        /// <summary>
        /// Cette méthode calcule le score d'une tenue
        /// Elle effectue toutes les paires possible de vêtement
        /// pour chacune des paires :
        /// si la paire de vetements sont de la meme saison, on donne un score de +1 
        /// si la paire de vetements sont de la meme catégorie, ondonne un score de =1
        /// </summary>
        /// <returns>le score obtenu</returns>
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
                if (!ValiderTenue())
                    throw new ArgumentException("Vos vêtements ne constituent pas une tenue");
                else
                {
                    _vetements = value; 
                    Score = CalculerScore();
                }
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
