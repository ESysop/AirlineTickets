using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTickets
	{
	public class TicketDesk : IEnumerable
		{
		List<Flight> flightList;
		public TicketDesk ()
			{
			flightList = new List<Flight>();
			}
		public void addFlights ()
			{
			flightList.Add(new Flight("American Airlines", "5:10p - 9:18p", 1, 5755));
			flightList.Add(new Flight("American Airlines", "6:59a - 11:51a", 1, 5661));
			flightList.Add(new Flight("American Airlines", "7:43p - 11:44p", 1, 5713));
			flightList.Add(new Flight("American Airlines", "1:33p - 5:55p", 1, 50153));
			flightList.Add(new Flight("American Airlines", "6:49a - 11:20a", 1, 2926));
			flightList.Add(new Flight("American Airlines", "6:59a - 11:36a", 1, 50193));
			flightList.Add(new Flight("American Airlines", "4:37p - 9:17p", 1, 2929));
			flightList.Add(new Flight("United", "3:15p - 8:16p", 1, 5049));
			flightList.Add(new Flight("Delta", "1:50p - 6:52p", 1, 55013));
			flightList.Add(new Flight("American Airlines", "10:09a - 3:14p", 1, 5735));
			flightList.Add(new Flight("American Airlines", "3:43p - 1:41p", 1, 4013));
			flightList.Add(new Flight("American Airlines", "7:43a - 11:44p", 1, 5813));
			flightList.Add(new Flight("Delta", "2:43p - 11:44p", 1, 5013));
			flightList.Add(new Flight("Delta", "7:43p - 11:44p", 1, 5013));
			flightList.Add(new Flight("American Airlines", "7:13p - 11:24p", 1, 3913));
			flightList.Add(new Flight("American Airlines", "7:43p - 10:44a", 1, 7613));


			}

		public IEnumerator GetEnumerator ()
			{
			foreach (Flight airLine in flightList)
				{
				if (airLine.airlineName.Equals("Delta"))
					{
					yield return airLine;
					}
				}
			throw new NotImplementedException();
			}

		public void printFlightList ()
			{
			foreach (Flight flightNumber in flightList)
				{
				Console.WriteLine((flightNumber.flightNumber)+" " +(flightNumber.departureTime) +" " +(flightNumber.airlineName));
				}
			}
		

		}
	}
