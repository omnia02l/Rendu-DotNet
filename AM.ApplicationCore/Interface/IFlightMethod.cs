using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    public interface IFlightMethod
    {
        IList<DateTime> GetFlightDates(string destination);
        IList<Flight> GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        // Enumerable n'est pas modifiable
        IEnumerable<Flight> OrderedDurationFlights();

        IEnumerable<Traveller> SeniorTravellers(Flight flight);
        //enumerable contient le dictionnaire
        IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
    }
}
