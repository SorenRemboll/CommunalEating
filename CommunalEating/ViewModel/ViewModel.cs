using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunalEating.Annotations;
using CommunalEating.Models;

namespace CommunalEating 
{
    class ViewModel : INotifyPropertyChanged
    {
        private bool _isItThursday;

        public bool IsItThursday
        {
            get { return _isItThursday; }
            set { _isItThursday = value; }
        }

        public void IsItThursday()
        {
            Worker.GetThursday();
        }

        #region MyRegion

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
