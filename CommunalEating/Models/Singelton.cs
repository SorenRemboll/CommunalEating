using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
    class Singelton
    {
        private static Singelton _instance = new Singelton();
        public ObservableCollection<Household> Households { get; set; }
        public ObservableCollection<Reservation> Reservations { get; set; }

        public ObservableCollection<Calcualtor> Calculation { get; set; }

        public Singelton()
        {
            //Here is where the objects are created
            Households = new ObservableCollection<Household>();
            Reservations = new ObservableCollection<Reservation>();
            Calculation = new ObservableCollection<Calcualtor>();

        }

        public static Singelton GetInstance()
        { //This is where you call your objects through
            return _instance;
        }
    }
}
