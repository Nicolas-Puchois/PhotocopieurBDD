using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDPhotocopieur.Classes
{
    internal class Technicien
    {
        private int _id_technicien;
        private int _telephoneTech;
        private string _prenom;
        private string _nom;
        private string _villeAttitre;
        

        public int Id_Technicien { get => _id_technicien; set => Id_Technicien = value; }
        public int Telephone_Tech { get => _telephoneTech; set => _telephoneTech = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Nom { get => _nom; set => _nom = value; }

        public string VilleAttitre { get => _villeAttitre; set => _villeAttitre = value; }



        public Technicien(int telephone_tech, string prenom, string nom, string villeAttritre) 
        {
            Telephone_Tech = telephone_tech;
            Prenom = prenom;
            Nom = nom;
            VilleAttitre= villeAttritre;
        }
    }
}
