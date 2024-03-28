using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightConsole
{
    public class Airport
    {
        public string airportID { get; set; }
        private string airportName { get; set; }
        private string city { get; set; }
        private string country { get; set; }

        public Airport(string id, string name, string city, string country)
        {
            airportID = id;
            airportName = name;
            city = city;
            country = country;
        }
    }


}
