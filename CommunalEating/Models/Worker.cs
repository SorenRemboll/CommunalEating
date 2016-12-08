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
        private static DayOfWeek _today;

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

        public static DayOfWeek Today
        {
            get { return _today; }
            set { _today = value; }
        }

        #endregion

        #region Constructor

        public Worker(string chef, string assistanceChef, string cleaner, bool isItThursdag)
        {
            _chef = chef;
            _assistanceChef = assistanceChef;
            _cleaner = cleaner;
            _isItThursdag = isItThursdag;
            _date = Date;
        }
        #endregion

        public static bool GetThursday()
        {
            
            int x = 1;
            if (GetThursday())
            {
                Today = System.DayOfWeek.Thursday;
                
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
