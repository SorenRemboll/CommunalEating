using Windows.ApplicationModel.Activation;
using Windows.Devices.Bluetooth.Background;
using CommunalEating.Models;

namespace CommunalEating
{
    public class Calcualtor : Reservation
    {
        private int valueOfAdults = 1;
        private double valueOfTeens = 0.5;
        private double valueOfKids = 0.25;
        private int valueOfBabies = 0;

        private HostDinner hd = new HostDinner();



        public Calcualtor(int noOfAdults, int noOfTeens, int noOfKids, int noOfBabies) : base(noOfAdults, noOfTeens, noOfKids, noOfBabies)

        {
            noOfAdults = 0;
            noOfTeens = 1;
            noOfKids = 1;
            noOfBabies = 1;

        }

        public double calcNoOfAdults()
        {
            if (noOfAdults== 0)
            {
                return 0;
            }
            else
            {
                double result = hd.Price / (noOfAdults / valueOfAdults) + (noOfTeens / valueOfTeens) + (noOfKids / valueOfKids);
                return result;
            }

        }

        public double calcNoOfTeens()
        {
            if (noOfTeens == 0)
            {
                return 0;
            }
            else
            {
                double result = hd.Price / ((noOfAdults / valueOfAdults) + (noOfTeens / valueOfTeens) + (noOfKids / valueOfKids) / valueOfTeens);
                return result;
            }

            
        }

        public double calcNoOfKids()
        {
            if (noOfKids == 0)
            {
                return 0;
            }
            else
            {
                double result = hd.Price / ((noOfAdults / valueOfAdults) + (noOfTeens / valueOfTeens) + (noOfKids / valueOfKids) / valueOfKids);
                return result;
            }
        }

        public double calcNoOfBabies()
        {
            return 0;
        }

        public double calcResult()
        {
            double result = calcNoOfAdults() + calcNoOfTeens() + calcNoOfKids() + calcNoOfBabies();
            return result;
        }







    }

}





