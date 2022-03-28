using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik.Class
{
    class Port
    {
        private int _noPort;
        private string _nomPort;

        public Port(int noPort, string nomPort)
        {
            _noPort = noPort;
            _nomPort = nomPort;
        }

        public int NoPort
        {
            get => _noPort;
        }
        public string NomPort
        {
            get => _nomPort;
        }

        public override string ToString()
        {
            return NomPort;
        }
    }
}
