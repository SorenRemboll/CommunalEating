using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
  class Calendar
  {
    // # Typical Variables
    DateTime today = new DateTime();
    private string _day;

    // # Variables for week-number
    static CultureInfo culture = new CultureInfo("da-DK");
    private System.Globalization.Calendar calendar = culture.Calendar;
    private CalendarWeekRule calendarWeekRule = culture.DateTimeFormat.CalendarWeekRule;
    private DayOfWeek dayOfWeek = culture.DateTimeFormat.FirstDayOfWeek;


    // # Property to easily get a day (either today, or one of the next 3 days)
    public String Day
    {
      get { return MonToThurs(today); }
    }

    // # Default constructor for today's date
    public Calendar()
    {
      today = DateTime.Now;
    }

    // # Constructor that takes a day (1,2or3) for the next, the following and fourth eating day
    public Calendar(int _days)
    {
      today = DateTime.Now.AddDays(_days);
    }

   // # Define a day (Mon-Thurs)
    public String MonToThurs(DateTime _day)
    {
      // # Push to a correct day, if not Mon-Thurs
      if (today.DayOfWeek == DayOfWeek.Friday)
        today = DateTime.Now.AddDays(3);
      else if (today.DayOfWeek == DayOfWeek.Saturday)
        today = DateTime.Now.AddDays(2);
      else if (today.DayOfWeek == DayOfWeek.Sunday)
        today = DateTime.Now.AddDays(1);

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
  }
}
