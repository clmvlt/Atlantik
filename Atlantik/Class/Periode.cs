using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik.Class
{
    class Periode
    {
        private int _noPeriode;
        private DateTime _debutPeriode;
        private DateTime _finPeriode;

        public Periode(int noPeriode, DateTime debutPeriode, DateTime finPeriode)
        {
            _noPeriode = noPeriode;
            _debutPeriode = debutPeriode;
            _finPeriode = finPeriode;
        }

        public int NoPeriode
        {
            get => _noPeriode;
        }
        public DateTime DebutPeriode
        {
            get => _debutPeriode;
        }

        public DateTime FinPeriode
        {
            get => _finPeriode;
        }

        public override string ToString()
        {
            return DebutPeriode.ToShortDateString() + " au " + FinPeriode.ToShortDateString();
        }
    }
}
