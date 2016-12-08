using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
    class Singelton
    {
        private static Singelton _instance = new Singelton();

        public Singelton()
        {
            //Here is where the objects are created
        }

        public static Singelton GetInstance()
        { //This is where you call your objects through
            return _instance;
        }
    }
}
