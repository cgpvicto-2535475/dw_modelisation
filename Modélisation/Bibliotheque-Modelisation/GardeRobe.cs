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

        /// <summary>
        /// Constructeur du garde-robe, avec tous les vêtements,
        /// </summary>
        /// <param name="vetements">la liste de vêtements</param>
        public GardeRobe(List<Vetement> vetements)
        {
            Vetements = vetements;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========Garde-Robe=======");

            for (int i = 0; i < Vetements.Count; i++)
            {
                sb.AppendLine(Vetements[i].ToString());
            }
            sb.AppendLine($"Nombre de hauts : {NombreHauts}");
            sb.AppendLine($"Nombre de bas : {NombreBas}");
            sb.AppendLine($"Nombre de chaussures : {NombreChaussures}");
            sb.AppendLine($"Nombre de vestes : {NombreVestes}");
            sb.AppendLine($"Nombre d'accessoires :{NombreAcccessoires}");
            sb.AppendLine($"========================");

            return base.ToString();
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
        /// Cette méthode permet de retirer un vêtement du garde robe en appelant son nom
        /// </summary>
        /// <param name="nom">le nom du vêtement à enlever</param>
        public void RetirerVetement(string nom)
        {
            for (int i = 0; i < Vetements.Count; i++)
            {
                if(nom == Vetements[i].Nom)
                {
                    Vetements.RemoveAt(i);
                    return;
                }
            }
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
        /// Accesseur des vetements
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
        /// Accesseur du nombre de hauts, calculé dynamiquement avec la fonction CompterInventaire
        /// </summary>
        public int NombreHauts 
        { 
            get => CompterInventaire(Type.HAUT);
        }

        /// <summary>
        /// Accesseur du nombre de bas, calculé dynamiquement avec la fonction CompterInventaire
        /// </summary>
        public int NombreBas 
        {
            get => CompterInventaire(Type.BAS);
        }
        /// <summary>
        /// Accesseur du nombre de chaussures, calculé dynamiquement avec la fonction CompterInventaire
        /// </summary>
        public int NombreChaussures 
        { 
            get => CompterInventaire(Type.CHAUSSURE);
        }

        /// <summary>
        /// Accesseur du nombre de vestes, calculé dynamiquement avec la fonction CompterInventaire
        /// </summary>
        public int NombreVestes 
        { 
            get => CompterInventaire(Type.VESTE);
           
        }

        /// <summary>
        /// Accesseur du nombre d'accessoires, calculé dynamiquement avec la fonction CompterInventaire
        /// </summary>
        public int NombreAcccessoires 
        {
            get => CompterInventaire(Type.ACCESSOIRE);
        }
    }
}
