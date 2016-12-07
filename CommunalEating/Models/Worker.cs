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

        #endregion

        #region Constructor

        public Worker(string chef, string assistanceChef, string cleaner, bool isItThursdag)
        {
            _chef = chef;
            _assistanceChef = assistanceChef;
            _cleaner = cleaner;
            _isItThursdag = isItThursdag;
        }
        #endregion

        
    }
}
