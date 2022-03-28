using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik.Class
{
    class Bateau
    {
        private int _noBateau;
        private string _nomBateau;

        public Bateau(int noBateau, string nomBateau)
        {
            _noBateau = noBateau;
            _nomBateau = nomBateau;
        }

        public int NoBateau
        {
            get => _noBateau;
        }
        public string NomBateau
        {
            get => _nomBateau;
        }

        public override string ToString()
        {
            return NomBateau;
        }
    }
}
