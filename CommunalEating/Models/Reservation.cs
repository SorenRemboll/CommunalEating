using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
    class Reservation 
    {
        private int _dinnerId;
        private int _noOfAdults;
        private int _noOfTeens;
        private int _noOfKids;
        private int _noOfBabies;

        #region Constructor

        public Reservation(int noOfAdults, int noOfTeens, int noOfKids, int noOfBabies)
        {
            _dinnerId = dinnerId;
            _noOfAdults = noOfAdults;
            _noOfTeens = noOfTeens;
            _noOfKids = noOfKids;
            _noOfBabies = noOfBabies;
        }

        #endregion

        #region Properties

        public int dinnerId
        {
            get { return _dinnerId; }
            set { _dinnerId = value; }
        }

        public int noOfAdults
        {
            get { return _noOfAdults; }
            set { _noOfAdults = value; }
        }

        public int noOfTeens
        {
            get { return _noOfTeens; }
            set { _noOfTeens = value; }
        }

        public int noOfKids
        {
            get { return _noOfKids; }
            set { _noOfKids = value; }
        }

        public int noOfBabies
        {
            get { return _noOfBabies; }
            set { _noOfBabies = value; }
        }

        #endregion

        public override string ToString()
        {
            return $"{nameof(dinnerId)}: {dinnerId}, {nameof(noOfAdults)}: {noOfAdults}, {nameof(noOfTeens)}: {noOfTeens}, {nameof(noOfKids)}: {noOfKids}, {nameof(noOfBabies)}: {noOfBabies}";
        }
    }
}
