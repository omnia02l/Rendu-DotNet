using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        #region propp de base
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        #endregion
        #region propp de navigation
        public Plane Plane { get; set; }
        //IList<> = Interface != List
        // IList<> == ICollection
        public IList<Passenger> Passengers { get; set; }


        #endregion
    }
}
