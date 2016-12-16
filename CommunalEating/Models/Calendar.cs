using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunalEating.Annotations;

namespace CommunalEating.Models
{
    class Calendar : INotifyPropertyChanged
    {
        #region Variables
        // # Typical Variables
        DateTime today = new DateTime();
        DateTime day1 = new DateTime();
        DateTime day2 = new DateTime();
        DateTime day3 = new DateTime();
        DateTime day4 = new DateTime();
        // private string _day;

        // # Variables for week-number
        static CultureInfo culture = new CultureInfo("da-DK");
        private System.Globalization.Calendar calendar = culture.Calendar;
        private CalendarWeekRule calendarWeekRule = culture.DateTimeFormat.CalendarWeekRule;
        private DayOfWeek dayOfWeek = culture.DateTimeFormat.FirstDayOfWeek;
        #endregion

        #region Constructors
        // ## Default Constructor
        // # I know - I too am ashamed of this snippet
        public Calendar()
        {
            today = DateTime.Today;
            day1 = DateTime.Today;
            day2 = DateTime.Today;
            day3 = DateTime.Today;
            day4 = DateTime.Today;
            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                day2 = day2.AddDays(1);
                day3 = day3.AddDays(2);
                day4 = day4.AddDays(3);
            }
            else if (today.DayOfWeek == DayOfWeek.Tuesday)
            {
                day2 = day2.AddDays(1);
                day3 = day3.AddDays(2);
                day4 = day4.AddDays(6);
            }
            else if (today.DayOfWeek == DayOfWeek.Wednesday)
            {
                day2 = day2.AddDays(1);
                day3 = day3.AddDays(5);
                day4 = day4.AddDays(6);
            }
            else if (today.DayOfWeek == DayOfWeek.Thursday)
            {
                day2 = day2.AddDays(4);
                day3 = day3.AddDays(5);
                day4 = day4.AddDays(6);
            }
            else if (today.DayOfWeek == DayOfWeek.Friday)
            {
                day1 = day1.AddDays(3);
                day2 = day2.AddDays(4);
                day3 = day3.AddDays(5);
                day4 = day4.AddDays(6);
            }
            else if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                day1 = day1.AddDays(2);
                day2 = day2.AddDays(3);
                day3 = day3.AddDays(4);
                day4 = day4.AddDays(5);
            }
            else
            {
                day1 = day1.AddDays(1);
                day2 = day2.AddDays(2);
                day3 = day3.AddDays(3);
                day4 = day4.AddDays(4);
            }
        }

        // # Constructor that takes a date
        public Calendar(DateTime _date)
        {
            today = _date;
        }
        #endregion

        // # Properties to easily get the days
        #region Properties
        public String Day1
        {
            get { return MonToThurs(day1); }
        }
        public String Day2
        {
            get { return MonToThurs(day2); }
        }
        public String Day3
        {
            get { return MonToThurs(day3); }
        }
        public String Day4
        {
            get { return MonToThurs(day4); }
        }
        #endregion

        // # Properties to get the dates of the days
        #region Properties
        public DateTime Day1Date
        {
            get { return day1; }
        }
        public DateTime Day2Date
        {
            get { return day2.Date; }
        }
        public DateTime Day3Date
        {
            get { return day3.Date; }
        }
        public DateTime Day4Date
        {
            get { return day4.Date; }
        }
        #endregion

        #region Didn't work
        // # Property to easily get a day (either today, or one of the next 3 days)
        //public String Day
        //{
        //  get { return MonToThurs(today); }
        //}

        // # Default constructor for today's date
        //public Calendar()
        //{
        //  today = DateTime.Now;
        //}

        // # Constructor that takes a day
        //public Calendar(int _days)
        //{
        //  today = DateTime.Now.AddDays(_days);
        //} 
        #endregion

        // # Define a day (Mon-Thurs)
        #region Method
        public String MonToThurs(DateTime _day)
        {
            //DateTime td = new DateTime();
            //td = DateTime.Now;
            //TimeSpan ts = _day - td;
            //// # Push to a correct day, if not Mon-Thurs
            //if (_day.DayOfWeek == DayOfWeek.Friday)
            //  _day = _day.AddDays(3 + ts.TotalDays);
            //else if (_day.DayOfWeek == DayOfWeek.Saturday)
            //  _day = _day.AddDays(2 + ts.TotalDays);
            //else if (_day.DayOfWeek == DayOfWeek.Sunday)
            //  _day = _day.AddDays(1 + ts.TotalDays);

            // # Return the day in Danish format
            String day;
            if (_day.DayOfWeek == DayOfWeek.Monday)
                day = "Mandag";
            else if (_day.DayOfWeek == DayOfWeek.Tuesday)
                day = "Tirsdag";
            else if (_day.DayOfWeek == DayOfWeek.Wednesday)
                day = "Onsdag";
            else
                day = "Torsdag";
            return day;
        }
        #endregion

        #region Method no longer in use
        // ## No longer in use 
        // # Method to check if it's Thursdag
        //public bool IsThursday()
        //{
        //  bool thursday = false;
        //  if (today.DayOfWeek == DayOfWeek.Thursday)
        //    thursday = true;
        //  return thursday;
        //} 
        #endregion

        // # Show week-number
        #region Method 
        public int GetWeekNumber(DateTime date)
        {
            return calendar.GetWeekOfYear(date, calendarWeekRule, dayOfWeek);
        } 
        #endregion

        #region NotifyProperyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }
}
