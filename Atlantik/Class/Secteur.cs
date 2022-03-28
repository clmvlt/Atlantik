using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik.Class
{
    class Secteur
    {
        private int _noSecteur;
        private string _nomSecteur;

        public Secteur(int noSecteur, string nomSecteur)
        {
            _noSecteur = noSecteur;
            _nomSecteur = nomSecteur;
        }

        public int NoSecteur 
        {
            get => _noSecteur;
        }
        public string NomSecteur
        {
            get => _nomSecteur;
        }

        public override string ToString()
        {
            return NomSecteur;
        }
    }
}
