using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
  class HostDinner
  {
    // # Needed variables / backing-fields
    private string _headline;
    private string _description;
    private string _additionalNote;
    private string _host;
    private double _price;

    // ## Properties
    // # Headline
    public String Headline
    {
      get { return _headline; }
      set { _headline = value; }
    }
    // # Description
    public String Description
    {
      get { return _description; }
      set { _description = value; }
    }
    // # Additional Note
    public String AdditionalNote
    {
      get { return _additionalNote; }
      set { _additionalNote = value; }
    }
    // # Hosting Household
    public String Host
    {
      get { return _host; }
      set { _host = value; }
    }
    // # Price
    public double Price
    {
      get { return _price; }
      set { _price = value; }
    }

    // # Default Constructor
    public HostDinner()
    {
      _headline = "";
      _description = "";
      _additionalNote = "";
      _host = "";
      _price = 0.0;
    }

    // # Constructor that takes values
    public HostDinner(String _headline, 
                      String _description, 
                      String _additionalNote, 
                      String _host, 
                      double _price)
    {
      this._headline = _headline;
      this._description = _description;
      this._additionalNote = _additionalNote;
      this._host = _host;
      this._price = _price;
    }
  }
}
