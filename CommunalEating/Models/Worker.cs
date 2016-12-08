using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
    class Worker
    {
        private string _chef;
        private string _assistanceChef;
        private string _cleaner;
        private bool _isItThursdag;
        private string _date;

        DateTime _today = new DateTime();

        #region Properties

        public string Chef
        {
            get { return _chef; }
            set { _chef = value; }
        }

        public string AssistanceChef
        {
            get { return _assistanceChef; }
            set { _assistanceChef = value; }
        }

        public string Cleaner
        {
            get { return _cleaner; }
            set { _cleaner = value; }
        }

        public bool IsItThursdag
        {
            get { return _isItThursdag; }
            set { _isItThursdag = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public int DayOfWeek { get; set; }



        #endregion

        #region Constructor

        public Worker(string chef, string assistanceChef, string cleaner, bool isItThursdag)
        {
            _chef = chef;
            _assistanceChef = assistanceChef;
            _cleaner = cleaner;
            _isItThursdag = isItThursdag;
            _date = Date;
            _today = DateTime.Now;
        }
        #endregion

        public bool GetThursday()
        {

            if (_today.DayOfWeek == System.DayOfWeek.Thursday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
