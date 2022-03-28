using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik.Class
{
    internal class Liaison
    {
        private int _noLiaison;
        private int _noSecteur;
        private int _noPortDepart;
        private int _noPortArrive;
        private double _distance;

        private string _nomPortDep;
        private string _nomPortArr;

        public Liaison(int noLiaison, int noSecteur, int noPortDepart, int noPortArrive, double Distance, string nomPortDep, string nomPortArr)
        {
            _noLiaison = noLiaison;
            _noSecteur = noSecteur;
            _noPortDepart = noPortDepart;
            _noPortArrive = noPortArrive;
            _distance = Distance;
            _nomPortDep = nomPortDep;
            _nomPortArr = nomPortArr;
        }

        public int NoLiaison { get => _noLiaison; }
        public int NoSecteur { get => _noSecteur; }
        public int NoPortDepart { get => _noPortDepart; }
        public int NoPortArrive { get => _noPortArrive; }
        public double Distance { get => _distance; }

        public string NomPortDepart { get => _nomPortDep; }
        public string NomPortArrive { get => _nomPortArr; }

        public override string ToString()
        {
            return $"{NomPortDepart} - {NomPortArrive}";
        }
    }
}
