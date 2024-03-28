using Microsoft.Data.SqlClient;
using FlightConsole.Commands;

namespace FlightConsole.CommandHandlers
{

    public class CreateFlightCommandHandler : ICommandHandler<CreateFlightCommand>
    {
        private readonly string connectionString = "Server=localhost; Database=Flights; Integrated Security=True; TrustServerCertificate=True;";

        public void Handle(CreateFlightCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            string sql = @"
            INSERT INTO Flights (FlightID, FlightNumber, DepartureAirport, ArrivalAirport, DepartureTime, 
                                 ArrivalTime, FlightCapacity, FlightDuration, NumberOfPassengers) 
            VALUES (@FlightID, @FlightNumber, @DepartureAirport, @ArrivalAirport, @DepartureTime, 
                    @ArrivalTime, @FlightCapacity, @FlightDuration, @NumberOfPassengers)";
            SqlConnection connection = new SqlConnection(connectionString);
            
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(sql, connection);

            // Add parameters
            sqlCommand.Parameters.AddWithValue("@FlightID", 16);
            sqlCommand.Parameters.AddWithValue("@FlightNumber", command.FlightNumber);
            sqlCommand.Parameters.AddWithValue("@DepartureAirport", command.DepartureAirport.airportID);
            sqlCommand.Parameters.AddWithValue("@ArrivalAirport", command.ArrivalAirport.airportID);
            sqlCommand.Parameters.AddWithValue("@DepartureTime", command.DepartureTime);
            sqlCommand.Parameters.AddWithValue("@ArrivalTime", command.ArrivalTime);
            sqlCommand.Parameters.AddWithValue("@FlightCapacity", command.FlightCapacity);
            sqlCommand.Parameters.AddWithValue("@FlightDuration", command.FlightDuration);
            sqlCommand.Parameters.AddWithValue("@NumberOfPassengers", command.NumberOfPassengers);


            // Execute the command
            sqlCommand.ExecuteNonQuery();
                
            

        }

    }
}
