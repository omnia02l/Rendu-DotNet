using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    // :Passenger  = extend from passenger
    public class Traveller:Passenger
    {
        #region prop de base
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        #endregion
        #region Imp
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine(" I am Traveller Guten Tag");
        }
        #endregion
    }
}
