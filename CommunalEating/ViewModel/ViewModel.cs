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
        private bool isThursday;

        public ViewModel()
        {
            IsThursday();
        }

        //public bool IsItThursday
        //{
        //    get { return _isThursday; }
        //    set { _isItThursday = value; }
        //}

        public bool IsThursday()
        {
            Worker testWorkser = new Worker("Louise", "Bent", "Gunnar");

            return testWorkser.GetThursday();
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
