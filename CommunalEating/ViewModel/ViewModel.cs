using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.UI.Xaml.Controls;
using CommunalEating.Annotations;
using CommunalEating.Models;
using Eventmaker.Common;

namespace CommunalEating
{
    class ViewModel : INotifyPropertyChanged
    {

        #region Properties

        #region Alex

        private ObservableCollection<Reservation> _reservations;
        private int _noOfAdults;
        private int _noOfTeens;
        private int _noOfYoungsters;
        private int _noOfKids;

        public ObservableCollection<Reservation> Reservations
        {
            get { return _reservations; }
            set { _reservations = value; OnPropertyChanged(); }
        }

        public int NoOfAdults
        {
            get { return _noOfAdults; }
            set { _noOfAdults = value; OnPropertyChanged(); }
        }

        public int NoOfTeens
        {
            get { return _noOfTeens; }
            set { _noOfTeens = value; OnPropertyChanged(); }
        }

        public int NoOfYoungsters
        {
            get { return _noOfYoungsters; }
            set { _noOfYoungsters = value; OnPropertyChanged(); }
        }

        public int NoOfKids
        {
            get { return _noOfKids; }
            set { _noOfKids = value; OnPropertyChanged(); }
        }

        private int _address;
        private string _email;
        private int _housePick;
        #endregion

        #region Jacob

        public int HousePick
        {
            get { return _housePick; }
            set { _housePick = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Household> Households
        {
            get { return _households; }
            set { _households = value; }
        }

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


        private ObservableCollection<Household> _households;
        public RelayCommand HAddCommand { get; set; }
        public RelayCommand HRemoveCommand { get; set; }
        public RelayCommand HSaveCommand { get; set; }
        public RelayCommand HLoadCommand { get; set; }
        #endregion

        #region Properties (creating objects)
        // # The front/overview four days objects
        private Calendar days;

        private HostDinner day1;
        private HostDinner day2;
        private HostDinner day3;
        private HostDinner day4;
#endregion
        #region Henrik
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

        //public DateTime testDate { get { return days.Day1Date; }  }
        //public DateTime testDate2 { get { return day1.Date; } }

        // # (Properties) Get the food/description for the following eating days
        #region FoodDescription
        public String day1Headline
        {
            get
            {
                String x = "";
                if (days.Day1Date == day1.Date)
                    x = day1.Headline;
                return x;
            }
        }
        public String day1Host
        {
            get
            {
                String x = "Ingen Arrangør";
                if (days.Day1Date == day1.Date)
                    x = day1.Host.ToString();
                return x;
            }
        }
        public String day1Description
        {
            get
            {
                String x = "";
                if (days.Day1Date == day1.Date)
                    x = day1.Description;
                return x;
            }
        }
        public String day1Note
        {
            get
            {
                String x = "";
                if (days.Day1Date == day1.Date)
                    x = day1.AdditionalNote;
                return x;
            }
        }
        // End day one
        public String day2Headline
        {
            get
            {
                String x = "";
                if (days.Day2Date == day2.Date)
                    x = day2.Headline;
                return x;
            }
        }
        public String day2Host
        {
            get
            {
                String x = "Ingen Arrangør";
                if (days.Day2Date == day2.Date)
                    x = day2.Host.ToString();
                return x;
            }
        }
        public String day2Description
        {
            get
            {
                String x = "";
                if (days.Day2Date == day2.Date)
                    x = day2.Description;
                return x;
            }
        }
        public String day2Note
        {
            get
            {
                String x = "";
                if (days.Day2Date == day2.Date)
                    x = day1.AdditionalNote;
                return x;
            }
        }
        // End day two
        public String day3Headline
        {
            get
            {
                String x = "";
                if (days.Day3Date == day3.Date)
                    x = day3.Headline;
                return x;
            }
        }
        public String day3Host
        {
            get
            {
                String x = "Ingen Arrangør";
                if (days.Day3Date == day3.Date)
                    x = day3.Host.ToString();
                return x;
            }
        }
        public String day3Description
        {
            get
            {
                String x = "";
                if (days.Day3Date == day3.Date)
                    x = day3.Description;
                return x;
            }
        }
        public String day3Note
        {
            get
            {
                String x = "";
                if (days.Day3Date == day3.Date)
                    x = day3.AdditionalNote;
                return x;
            }
        }
        // End day three
        public String day4Headline
        {
            get
            {
                String x = "";
                if (days.Day4Date == day4.Date)
                    x = day4.Headline;
                return x;
            }
        }
        public String day4Host
        {
            get
            {
                String x = "Ingen Arrangør";
                if (days.Day4Date == day4.Date)
                    x = day4.Host.ToString();
                return x;
            }
        }
        public String day4Description
        {
            get
            {
                String x = "";
                if (days.Day4Date == day4.Date)
                    x = day4.Description;
                return x;
            }
        }
        public String day4Note
        {
            get
            {
                String x = "";
                if (days.Day4Date == day4.Date)
                    x = day4.AdditionalNote;
                return x;
            }
        }
        // End day four 
        #endregion


        // ## No longer in use
        // # Property to get IsThursday value
        //public bool ThursdayChecked
        //{
        //    get { return days.IsThursday(); }
        //} 
        #endregion

        #endregion


        // # Constructor
        public ViewModel()
        {
            #region Alex

            _reservations = Singelton.GetInstance().Reservations;
            Singelton.GetInstance().Reservations.Add(new Reservation(0, 0, 0, 0));

            #endregion

            // IsThursday();
            // workers = new Worker("", "", "");

            #region jacob

            _households = Singelton.GetInstance().Households;
            HAddCommand = new RelayCommand(HAdd);
            HRemoveCommand = new RelayCommand(HRemove);
            HSaveCommand = new RelayCommand(SaveHousehold);
            HLoadCommand = new RelayCommand(LoadHousehold);
            Singelton.GetInstance().Households.Add(new Household(5, "test"));
            #endregion


            #region Henrik
            days = new Calendar();
            day1 = new HostDinner("Kødsovs", "Serveres med yadada", "Kan indeholde kød", 5, 500, DateTime.Today);
            day2 = new HostDinner("En anden ret", "Serveres med yadada", "Kan indeholde kød", 5, 500, DateTime.Today.AddDays(4));
            day3 = new HostDinner("En tredje ret", "Serveres med yadada", "Kan indeholde kød", 5, 500, DateTime.Today.AddDays(5));
            day4 = new HostDinner("Og den sidste ret", "Serveres med yadada", "Kan indeholde kød", 5, 500, DateTime.Today.AddDays(6));
            #endregion
        }

        #region Methods

        #region Jacob

        public void HRemove() //Used to call the remove command on the singelton object of household at (housepick) location
        {
            Singelton.GetInstance().Households.RemoveAt(HousePick);
            OnPropertyChanged();
        }

        public void HAdd() //used to call the add command on the singelton object of household
        {
            Singelton.GetInstance().Households.Add(new Household(Address, Email));
            OnPropertyChanged();
        }

        public async void SaveHousehold()
        {
            PersistenceFacade.SaveHouseholdJason(Singelton.GetInstance().Households);
        }

        public async void LoadHousehold()
        {
            var household = await PersistenceFacade.LoadHouseholdJason();
            Singelton.GetInstance().Households.Clear();
            if (household != null)
                foreach (var house in household)
                {
                    Singelton.GetInstance().Households.Add(house);
                }
        }
        #endregion
        #endregion


        private void backButton(object sender, EventArgs e)
        {
            //INavigate(new Uri("MainPage.xaml?pivotItems.SelectedIndex = "));
        }

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

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
