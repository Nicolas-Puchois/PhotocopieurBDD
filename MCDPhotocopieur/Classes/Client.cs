using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDPhotocopieur.Classes
{
    internal class Client
    {
        private static int _idGlobal = 1;
        private int _idClient;
        private int _numeroAdresse;
        private int _numeroTelephone;
        private string _ville;
        private string _rue;
        private string _nom;
        private string _prenom;
        
        public static int IdClient { get => _idClient; set => _idClient = value; }
        public int NumeroAdresse { get => _numeroAdresse; set => _numeroAdresse = value; }
        public int NumeroTelephone { get => _numeroTelephone; set => _numeroTelephone = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public string Rue { get => _rue; set => _rue = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

        public Client(int numeroAdresse, int numeroTelephone, string ville, string rue, string nom, string prenom)
        {
            NumeroAdresse = numeroAdresse;
            NumeroTelephone = numeroTelephone;
            Ville = ville;
            Rue = rue;
            Nom = nom;
            Prenom = prenom;
        }


    }
}
