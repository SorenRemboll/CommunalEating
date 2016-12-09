using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
    class Household
    {
        public int Address { get; set; }
        public string Email { get; set; }



        public Household(int address, string email)
        {
            Address = address;
            Email = email;
        }

        public override string ToString()
        {
            return $"{nameof(Address)}: {Address}, {nameof(Email)}: {Email}";
        }
    }
}
