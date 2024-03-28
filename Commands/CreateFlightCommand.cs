using Microsoft.Data.SqlClient;

namespace FlightConsole.Commands
{
		public class CreateFlightCommand
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
			public CreateFlightCommand(Flight flight)
			{
			    FlightID = flight.FlightID;
				FlightNumber = flight.FlightNumber;
				DepartureAirport = flight.DepartureAirport;
				ArrivalAirport = flight.ArrivalAirport;
				DepartureTime = flight.DepartureTime;
				ArrivalTime = flight.ArrivalTime;
			    FlightDuration = flight.FlightDuration;
				NumberOfPassengers = flight.NumberOfPassengers;
				FlightCapacity = flight.FlightCapacity;
			}
		}
	
}
