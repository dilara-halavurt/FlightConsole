using FlightConsole.Commands;
using FlightConsole.CommandHandlers;

namespace FlightConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                {
                    Airport departure = new Airport("LAX", "Los Angeles International Airport", "Los Angeles", "USA");
                    Airport arrival = new Airport("JFK", "John F. Kennedy International Airport", "New York", "USA");
                    Flight flight = new Flight(flightID: 16, flightNumber: "AA123",
                                                departureAirport: departure,
                                                arrivalAirport: departure,
                                                flightCapacity: 200,
                                                departureTime: new DateTime(2024, 1, 1, 8, 0, 0), // Jan 1, 2024, 8:00 AM
                                                arrivalTime: new DateTime(2024, 1, 1, 14, 0, 0), // Jan 1, 2024, 2:00 PM
                                                flightDuration: 6, // 6 hours
                                                numberOfPassengers: 150);
                    CreateFlightCommand createFlightCommand = new CreateFlightCommand(flight);
                    CreateFlightCommandHandler createFlightCommandHandler = new CreateFlightCommandHandler();
                    createFlightCommandHandler.Handle(createFlightCommand);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
