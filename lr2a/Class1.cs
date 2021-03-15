using System;
 

namespace ClassLibrary1
{
    public class Plane
    {
        public string Name_plane;
        public string Country_departure;
        public string Country_arrival;
        public int Flight_number;
        public int pepolnumber_of_seats;
        public int lux_seats;
        public bool eat;


        public double seatss
        {
            get
            {
                return Getseats();
            }
        }
        public int Getseats()
        {
            return pepolnumber_of_seats + lux_seats;
        }
    }
}

