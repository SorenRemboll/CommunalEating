﻿using System;
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

    // ## Default Constructor
    // # I know - I too am ashamed of this snippet
    public Calendar()
    {
      today = DateTime.Now;
      day1 = DateTime.Now;
      day2 = DateTime.Now;
      day3 = DateTime.Now;
      day4 = DateTime.Now;
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

    // # Properties to easily get the days
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

    // # Define a day (Mon-Thurs)
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

    // # Show week-number
    public int GetWeekNumber(DateTime date)
    {
      return calendar.GetWeekOfYear(date, calendarWeekRule, dayOfWeek);
    }

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
