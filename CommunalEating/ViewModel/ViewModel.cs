using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunalEating.Annotations;
using CommunalEating.Models;
using Eventmaker.Common;

namespace CommunalEating
{
    class ViewModel : INotifyPropertyChanged
    {
        #region Jacob

        public int Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        public Singelton Singelton { get; set; }

        private ObservableCollection<Household> _households;
        public RelayCommand HAddCommand { get; set; }
        #endregion
        // # The front/overview four days objects
        private Calendar days;
        private Worker workers;
        private int _address;
        private string _email;

        // private bool isThursday;

        // # Constructor
        public ViewModel()
        {
            #region jacob

            _households = Singelton.GetInstance().Households;
            HAddCommand = new RelayCommand(HAdd);
            Singelton.GetInstance().Households.Add(new Household(5, "test"));
            #endregion

            // IsThursday();
            // workers = new Worker("", "", "");
            days = new Calendar();
        }

        #region Jacob

        public void HAdd()
        {
            Singelton.GetInstance().Households.Add(new Household(Address,Email));
            OnPropertyChanged();
        }

        #endregion

        // # Properties to get the 4 days on the front/overview
        public String Day1
        {
            get { return days.Day1; }
        }
        public String Day2
        {
            get { return days.Day2; }
        }
        public String Day3
        {
            get { return days.Day3; }
        }
        public String Day4
        {
            get { return days.Day4; }
        }

        // # Property to get IsThursday value
        public bool ThursdayChecked { get; set; }

        //public bool IsItThursday
        //{
        //    get { return _isThursday; }
        //    set { _isItThursday = value; }
        //}

        //public bool IsThursday()
        //{
        //  Worker testWorkser = new Worker("Louise", "Bent", "Gunnar");

        //  return testWorkser.GetThursday();
        //}

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
