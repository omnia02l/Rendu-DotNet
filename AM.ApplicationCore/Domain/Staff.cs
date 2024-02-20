using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        #region propp de base
        public DateTime EmployementDate { get; set; }
        public double Salary { get; set; }
        public string Function { get; set; }
        #endregion

        #region Imp
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine(" I am Staff Bonjour");
        }
        #endregion
    }
}
