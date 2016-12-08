using Windows.ApplicationModel.Activation;
using Windows.Devices.Bluetooth.Background;

namespace CommunalEating
{
    public class Calcualtor
    {

        private int day1 = 1;
        private int day2 = 1;
        private int day3 = 1;
        private int day4 = 1;

        private int voksen = 1;
        private int barn = 1;

        private int totalpris = voksen + barn;

        public int Voksen
        {
            get { return voksen; }
            set { voksen = value; }
        }

        public int Barn
        {
            get { return barn; }
            set { barn = value; }
        }


        public Calcualtor()
        {
            if (day1 != isChecked);
            if (day2 != isChecked);
            if (day3 != isChecked);
            if (day4 != isChecked);

        }
        
    }
    
}


        
    
    
