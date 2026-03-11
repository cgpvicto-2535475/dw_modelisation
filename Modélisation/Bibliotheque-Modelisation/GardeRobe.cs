using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque_Modelisation
{
    /// <summary>
    /// Classe de garde-robe, contient les vetements, le nombre de hauts dans le garde-robe, 
    /// le nombre de bas dans le garde-robe,le nombre de chaussures, 
    /// le nombre de vestes et le nombre d'accessoires
    /// </summary>
    public class GardeRobe
    {
        private List<Vetement> _vetements;
        private int _nombreHauts;
        private int _nombreBas;
        private int _nombreChaussures;
        private int _nombreVestes;
        private int _nombreAcccessoires;

        /// <summary>
        /// Constructeur du garde-robe, avec tous les vêtements,
        /// </summary>
        /// <param name="vetements">la liste de vêtements</param>
        public GardeRobe(
            List<Vetement> vetements, int nombreHauts, int nombreBas, 
            int nombreChaussures, int nombreVestes, int nombreAcccessoires
            )
        {
            Vetements = vetements;
        }

        

        /// <summary>
        /// Cette méthode ajoute un vêtement au gardde-robe
        /// </summary>
        /// <param name="vetement">le vêtement à ajouter</param>
        public void AjouterVetement(Vetement vetement)
        {
            Vetements.Add(vetement);
        }
        
        /// <summary>
        /// Méthode qui compte l'inventaire d'un type spécifique de vêtements
        /// </summary>
        /// <param name="type">le type de vêtement recherché</param>
        /// <returns>lewe nombre de vêtement du type en paramètre 
        /// retrouvé dans le garde-robe</returns>
        public int CompterInventaire(Type type)
        {
            int inventaire = 0;
            for (int i = 0; i < Vetements.Count; i++)
            {
               
                if (Vetements[i].Type == type)
                {
                    inventaire++;
                }
            }
            return inventaire;
        }
        /// <summary>
        /// Constructeur des vetements
        /// </summary>
        public List<Vetement> Vetements 
        {
            get => _vetements;
            private set
            {
                _vetements = value;
            }
        }
        
        /// <summary>
        /// Constructeur du nombre de hauts
        /// </summary>
        public int NombreHauts 
        { 
            get => _nombreHauts;
            private set
            {
                value = CompterInventaire(Type.HAUT);
                _nombreHauts = value;
            }
        }

        /// <summary>
        /// Constructeur du nombre de bas
        /// </summary>
        public int NombreBas 
        { 
            get => _nombreBas;
            private set 
            {
                value = CompterInventaire(Type.BAS);
                _nombreBas = value;
            }
        }
        /// <summary>
        /// Constructeur du nombre de chaussures, calculé dynamiquement avec la fonction CompterInventaire
        /// </summary>
        public int NombreChaussures 
        { 
            get => _nombreChaussures;
            private set 
            {
                value = CompterInventaire(Type.CHAUSSURE);
                _nombreChaussures = value; 
            }
        }

        /// <summary>
        /// Constructeur du nombre de vestes, calculé dynamiquement avec la fonction CompterInventaire
        /// </summary>
        public int NombreVestes 
        { 
            get => _nombreVestes;
            private set
            {
                value = CompterInventaire(Type.VESTE);
                _nombreVestes = value;
            }
        }

        /// <summary>
        /// Constructeur du nombre d'accessoires, calculé dynamiquement avec la fonction CompterInventaire
        /// </summary>
        public int NombreAcccessoires 
        {
            get => _nombreAcccessoires;
            private set
            {
                value = CompterInventaire(Type.ACCESSOIRE);
                _nombreAcccessoires = value;
            }
        }
    }
}
