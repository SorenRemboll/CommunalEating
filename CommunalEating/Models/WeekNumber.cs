using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
    class WeekNumber : Calendar
    {
        // # Property with backing field (week-number)
        private int _week;
        public int week
        {
            get { return _week; }
            set { _week = value; }
        }

        // # Constructor
        public WeekNumber(int _week)
        {
            this._week = _week;
        }

        // # Custom ToString
        public override string ToString()
        {
            return "Uge " + _week;
        }
    }
}
