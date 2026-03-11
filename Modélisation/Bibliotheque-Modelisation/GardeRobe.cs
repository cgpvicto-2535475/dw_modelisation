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
        private Vetement[] _vetements;
        private int _nombreHauts;
        private int _nombreBas;
        private int _nombreChaussures;
        private int _nombreVestes;
        private int _nombreAcccessoires;

        /// <summary>
        /// Constructeur du garde-robe, avec tous les vêtements,
        /// </summary>
        /// <param name="vetements">la liste de vêtements</param>
        public GardeRobe(Vetement[] vetements, int nombreHauts, int nombreBas, int nombreChaussures, int nombreVestes, int nombreAcccessoires)
        {
            Vetements = vetements;
        }


        public static int CompterInventaire(enum Type { }
        /// <summary>
        /// 
        /// </summary>
        public Vetement[] Vetements 
        {
            get => _vetements;
            set => _vetements = value;
        }
        public int NombreHauts 
        { 
            get => _nombreHauts; 
            set => _nombreHauts = value;
        }
        public int NombreBas 
        { 
            get => _nombreBas; 
            set => _nombreBas = value;
        }
        public int NombreChaussures 
        { 
            get => _nombreChaussures; 
            set => _nombreChaussures = value; 
        }
        public int NombreVestes 
        { 
            get => _nombreVestes; 
            set => _nombreVestes = value; 
        }
        public int NombreAcccessoires 
        {
            get => _nombreAcccessoires; 
            set => _nombreAcccessoires = value; 
        }
    }
}
