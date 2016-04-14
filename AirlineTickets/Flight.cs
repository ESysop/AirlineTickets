using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTickets
	{
	public class Flight
		{
		public string airlineName, departureTime;
		public int stops, flightNumber;
		
		public Flight (string airlineName, string departureTime, int stops, int flightNumber)
			{
			this.flightNumber = flightNumber;
			this.stops = stops;
			this.departureTime = departureTime;
			this.airlineName = airlineName;
			}
		
		
		}

	}
