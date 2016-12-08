using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunalEating.Models;

namespace CommunalEating
{
    class ViewModel
    {
        public void IsThursday()
        {
            Worker.GetThursday();
        }
    }
}
