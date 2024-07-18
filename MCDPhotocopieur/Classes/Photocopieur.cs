using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDPhotocopieur.Classes
{
    internal class Photocopieur
    {
        private int _id_photocopieur;
        private int _anneeConstruction;
        private string _modele;
        
        public int IdPhotocopieur { get => _id_photocopieur; set => _id_photocopieur = value; }
        public string Modele { get => _modele; set => _modele = value; }
        public int AnneeConstruction { get => _anneeConstruction; set => _anneeConstruction = value; }
    
        public Photocopieur(string modele, int anneeConstruction)
        {
            Modele = modele;
            AnneeConstruction = anneeConstruction;
        }
    
    }
}
