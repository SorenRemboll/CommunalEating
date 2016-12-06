using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
  class Calendar
  {
    // # Variables
    DateTime today = new DateTime();
    private string _day;

    // # Property to easily get a day (either today, or one of the next 3 day)
    public String Day
    {
      get { return GetDay(today); }
    }

    // # Default constructor for today's date
    public Calendar()
    {
      today = DateTime.Now;
      if (today.DayOfWeek == DayOfWeek.Friday)
        today = DateTime.Now.AddDays(3);
      else if (today.DayOfWeek == DayOfWeek.Saturday)
        today = DateTime.Now.AddDays(2);
      else if (today.DayOfWeek == DayOfWeek.Sunday)
        today = DateTime.Now.AddDays(1);
    }

    // # Constructor that takes a day (1,2or3) for the next, the following and fourth eating day
    public Calendar(int _days)
    {
      today = DateTime.Now.AddDays(_days);
      if (today.DayOfWeek == DayOfWeek.Friday)
        today = DateTime.Now.AddDays(3);
      else if (today.DayOfWeek == DayOfWeek.Saturday)
        today = DateTime.Now.AddDays(2);
      else if (today.DayOfWeek == DayOfWeek.Sunday)
        today = DateTime.Now.AddDays(1);
    }

   // # Define a day (Mon-Thurs)
    public String GetDay(DateTime _day)
    {
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
  }
}
