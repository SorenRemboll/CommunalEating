using System.Collections.Generic;
using Windows.ApplicationModel.Activation;
using Windows.Devices.Bluetooth.Background;

namespace CommunalEating
{
    public class Calcualtor
    {

        int day1 = 0;
        int day2 = 0;
        int day3 = 0;
        int day4 = 0;



        private int voksen = 1;
        private double ung = 0.5;
        private double barn = 0.25;
        private int baby = 0;
        
        private int _baby = 0;

        public int Day1
        {
            get { return day1; }
            set { day1 = value; }
        }

        public int Day2
        {
            get { return day2; }
            set { day2 = value; }
        }

        public int Day3
        {
            get { return day3; }
            set { day3 = value; }
        }

        public int Day4
        {
            get { return day4; }
            set { day4 = value; }
        }

        public int Voksen
        {
            get { return voksen; }
            set { voksen = value; }
        }

        public double _ung
        {
            get { return _ung; }
            set { _ung = value; }
        }

        public double Barn
        {
            get { return barn; }
            set { barn = value; }
        }

        public int Baby
        {
            get { return _baby; }
            set { _baby = value; }
        }
        

    }
    
 }
    



        
    
    
