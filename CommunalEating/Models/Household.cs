using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
    class Household
    {
        public string Address { get; set; }
        public string Email { get; set; }

        public Household()
        {
            
        }

        public Household(string address, string email)
        {
            Address = address;
            Email = email;
        }
    }
}
