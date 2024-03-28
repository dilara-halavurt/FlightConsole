using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlightConsole
{
    public class Flight
    {
        public int FlightID { get; set; } // Assuming flightID is an int
        public string FlightNumber { get; set; }
        public Airport DepartureAirport { get; set; } // Assuming airport codes are used here
        public Airport ArrivalAirport { get; set; } // Assuming airport codes are used here
        public int FlightCapacity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public double FlightDuration { get; set; } // Assuming duration is a TimeSpan
        public int NumberOfPassengers { get; set; } // Assuming you want to track current passengers

        // Optional: Constructor to initialize a new Flight object with values
        public Flight(int flightID, string flightNumber, Airport departureAirport, Airport arrivalAirport,
                      int flightCapacity, DateTime departureTime, DateTime arrivalTime,
                      double flightDuration, int numberOfPassengers)
        {
            FlightID = flightID;
            FlightNumber = flightNumber;
            DepartureAirport = departureAirport;
            ArrivalAirport = arrivalAirport;
            FlightCapacity = flightCapacity;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            FlightDuration = flightDuration;
            NumberOfPassengers = numberOfPassengers;
        }
    }
}
