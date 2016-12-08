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

    // # The front/overview four days objects
    private Calendar days;


    // private bool isThursday;

    // # Constructor
    public ViewModel()
    {
      //IsThursday();
      days = new Calendar();
    }

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
