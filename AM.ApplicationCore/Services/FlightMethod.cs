using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// fichier.sln
namespace AM.ApplicationCore.Services
{

    public class FlightMethod : IFlightMethod
    {
      public  IList<Flight> flights = new List<Flight>();
        IList<Traveller> travellers = new List<Traveller>();

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            //var querry = from f in flights
            //             group f by f.Destination;
            var querry = flights.GroupBy(f => f.Destination);
            foreach (var q in querry ) {
                Console.WriteLine("Destination"+q.Key);
                foreach (var s in q) {
                    Console.WriteLine("Decollage"+s.FlightDate);
                }
            }
            return querry;
        }

        public double DurationAverage(string destination)
        {
            /*var requette = from f in flights
                           where f.Destination == destination
                           select f.EstimatedDuration;
            return requette.Average();*/
            return flights.Where(f => f.Destination == destination).Average(f => f.EstimatedDuration);

                }

        public IList<DateTime> GetFlightDates(string destination)
        {

            IList<DateTime> date = new List<DateTime>();
            // count == langth
            //for (int i = 0; i < flights.Count; i++)
            //{
            //    if (flights[i].Destination == destination)
            //    {
            //        date.Add(flights[i].FlightDate);
            //    }
            //}
            ///////////////////////////////////////
            //foreach(Flight f in flights) 
            //{
            //    if (f.Destination == destination)
            //        date.Add(f.FlightDate);
            //}
            //return date;
            // ************** Struc with Link *******
           /* var querry = from f in flights
                         where f.Destination == destination
                         select f.FlightDate;
            return querry.ToList();*/
           return flights.Where(f=>f.Destination == destination).Select(f=> f.FlightDate).ToList();
        }

        /*
         * Implémenter la méthode GetFlights(string filterType, string filterValue) 
         * qui affiche les vols en fonction de type de filtre et sa valeur. 
         * Le type de filtre représente un attribut simple (ce n’est pas une instance de classe ou une liste) de la classe Flight. 
         * Par exemple GetFlights(“Destination”, “Paris”) permettra d’afficher les vols dont la valeur de Destination est égale Paris.
         */
        public IList<Flight> GetFlights(string filterType, string filterValue)
        {
            IList<Flight> filteredFlights = new List<Flight>();

            if (filterType == "Destination")
            {
                foreach (Flight f in flights)
                {
                    if (filterValue == f.Destination)
                    {
                        filteredFlights.Add(f);
                    }
                }
            }
            else if (filterType == "Departure")
            {
                foreach (Flight f in flights)
                {
                    if (filterValue == f.Departure)
                    {
                        filteredFlights.Add(f);
                    }
                }
            }
            else if (filterType == "EstimatedDuration")
            {
                foreach (Flight f in flights)
                {
                    if (filterValue == f.EstimatedDuration.ToString())
                    {
                        filteredFlights.Add(f);
                    }
                }
            }
            else
            {
                throw new ArgumentException("Invalid filterType");
            }

            return filteredFlights;
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {/*
            var querry = from f in flights
                         orderby f.EstimatedDuration descending
                         select f;
            return querry;*/
            return flights.OrderByDescending(f => f.EstimatedDuration);
        }
        //totalDays donne  le nbr de jour seulement
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /* var querry =from f in flights
                         where (f.FlightDate - startDate ).TotalDays < 7
                         select f;
             return querry.Count();*/
            return flights.Count(f => (f.FlightDate - startDate).TotalDays < 7);
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            /*var querry = from f in flight.Passengers.OfType<Traveller>()
           
                         orderby f.BirthDate descending
                         select f;
            return querry.Take(3);*/
            return flight.Passengers.OfType<Traveller>().OrderByDescending(A=>A.BirthDate).Take(3);
        }

        public void ShowFlightDetails(Plane plane)
        {/*
            var querry = from f in flights
                         where f.Plane == plane
                         select new { f.Destination, f.FlightDate };

            foreach( var f in querry)
                {
                Console.WriteLine("Destination" +f.Destination+ "Date" + f.FlightDate);
            }*/
            var querry = flights.Where(f=>f.Plane == plane).Select(f=> new {f.Destination, f.FlightDate}).ToList();
            foreach (var f in querry)
            {
                Console.WriteLine("Destination" + f.Destination + "Date" + f.FlightDate);
            }
        }
    }
}
