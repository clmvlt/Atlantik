using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik.Class
{
    class Client
    {
        private int _noclient, _codepostal;
        private string _nom, _prenom, _adresse, _ville, _telfixe, _telport, _mel, _mdp;

        public Client(int noclient, int codepostal, string nom, string prenom, string adresse, string ville, string telfixe, string telport, string mel, string mdp)
        {
            _noclient = noclient;
            _codepostal = codepostal;
            _nom = nom;
            _prenom = prenom;
            _adresse = adresse;
            _ville = ville;
            _telfixe = telfixe;
            _telport = telport;
            _mel = mel;
            _mdp = mdp;
        }

        public int NoClient { get => _noclient; }
        public int CodePostal { get => _codepostal; }
        public string Nom { get => _nom; }
        public string Prenom { get => _prenom; }
        public string Adresse { get => _adresse; }
        public string Ville { get => _ville; }
        public string TelFixe { get => _telfixe; }
        public string TelPort { get => _telport; }
        public string MotDePasse { get => _mdp; }
        public string Mel { get => _mel; }

        public override string ToString()
        {
            return Nom + ", " + Prenom;
        }
    }
}
