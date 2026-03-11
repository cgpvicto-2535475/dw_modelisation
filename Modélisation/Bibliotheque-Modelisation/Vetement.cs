using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;

namespace Bibliotheque_Modelisation
{
    /// <summary>
    /// Classe d'un vêtement.
    /// Chaque vêtement a sa propre catégorie (casual, formel, street, sportif, minimaliste),
    /// Son propre type (haut, bas, veste, chaussure, accessoire)
    /// Son nom (string qui ne peut pas être null ou vide),
    /// Sa couleur (string qui ne peut pas être null ou vide),
    /// et son niveau de formalité (calculé dynamiquement)
    /// </summary>
    public class Vetement
    {
        private Categorie _categorie;
        private Type _type;
        private Saison _saison;
        private string _nom;
        private string _couleur;
        //private int _niveauFormalite;

        /// <summary>
        /// Constructeur d'un vêtement 
        /// </summary>
        /// <param name="categorie">la catégorie du vêtement, casual, formel, street, sportif, ou minimaliste</param>
        /// <param name="type">le type du vêtement, haut, bas, chaussure, veste, ou accessoire</param>
        /// <param name="saison">la saison du vêtement</param>
        /// <param name="nom">le nom du vêtement, en string qui ne peut pas être null ou vide</param>
        /// <param name="couleur">la couleur du vêtement, en string qui ne peut pas être null ou vide </param>
        public Vetement(Categorie categorie, Type type, Saison saison, string nom, string couleur)
        {
            Categorie = categorie;
            Type = type;
            Saison = saison;
            Nom = nom;
            Couleur = couleur;
        }

        /// <summary>
        /// Pour chacune des catégorie on a un niveau de formalité associé.
        /// </summary>
        /// <param name="value">le </param>
        /// <returns></returns>
        private int CalculerNiveauFormalite()
        {
            int value = 0;
            if (Categorie is Categorie.CASUAL)
                value = 1;
            if (Categorie is Categorie.FORMEL)
                value = 5;
            if (Categorie is Categorie.STREET)
                value = 2;
            if (Categorie is Categorie.SPORTIF)
                value = 1;
            if (Categorie is Categorie.MINIMALISTE)
                value = 3;
            return value;
        }

        /// <summary>
        /// Méthode d'affichage de vêtement
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=======Vêtement========");
            sb.AppendLine($"Nom : {Nom}");
            sb.AppendLine($"Categorie : {Categorie}");
            sb.AppendLine($"Type : {Type}");
            sb.AppendLine($"Saison : {Saison}");
            sb.AppendLine($"Couleur : {Couleur}");
            sb.AppendLine($"Niveau de formalité : {NiveauFormalite}");
            sb.AppendLine("=======================");
            return sb.ToString();
        }
       
        /// <summary>
        /// Vérifie si un string contient un nombre
        /// </summary>
        /// <param name="nom">le string à analyser</param>
        /// <returns>vrai s'il contient des nombres, faux sinon</returns>
        private static bool ContientNombre(string nom) 
        {
            foreach(char c in nom)
            {
                if(char.IsDigit(c))
                {
                    return true;
                }
            }

            return false;
        } 

        /// <summary>
        /// Constructeur de la saison d'un vêtement
        /// </summary>
        public Saison Saison 
        { 
            get => _saison;
            private set
            {
                _saison = value;
            }
        }

        

        /// <summary>
        /// Constructeur du nom du vêtement
        /// </summary>
        public string Nom 
        { 
            get => _nom;
            private set
            {
                ArgumentException.ThrowIfNullOrEmpty(value, "Votre nom ne peut pas être vide ou être null");
                
                if (ContientNombre(value))
                    throw new ArgumentException("Votre nom ne peut pas contenir de nombre");

                _nom = value;
            }
        }

        /// <summary>
        /// Constructeur de la couleur
        /// </summary>
        public string Couleur 
        {
            get => _couleur;
            private set
            {
                ArgumentException.ThrowIfNullOrEmpty(value, "Votre couleur ne peut pas être vide ou être null");

                if (ContientNombre(value))
                    throw new ArgumentException("Votre couleur ne peut pas contenir de nombre");

                _couleur = value;
            }
        }
        /// <summary>
        /// Constructeur pour le niveau de formalité
        /// </summary>
        public int NiveauFormalite
        {
            get => CalculerNiveauFormalite();
        }


        /// <summary>
        /// Constructeur de catégorie
        /// </summary>
        public Categorie Categorie
        {
            get => _categorie;
            private set
            {
                _categorie = value;
            }
        }

        /// <summary>
        /// Constructeur du type
        /// </summary>
        public Type Type 
        { 
            get => _type;
            private set
            {
                _type = value;
            }
        }
    }
}
