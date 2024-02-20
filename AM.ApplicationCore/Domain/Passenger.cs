using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        #region propp de base
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int? TelNumber { get; set; }
        public string? EmailAddress { get; set; }
        public int Id { get; set; }


        #endregion
        #region propp de navigation
        //IList<> = Interface != List
        // IList<> == ICollection
        public IList<Flight> Flights { get; set; }
        #endregion
        #region Imp
        public bool CheckProfile(string firstname , string lastname)
        {


            return firstname==FirstName && lastname==LastName;
        }
        public bool CheckProfile(string firstname, string lastname , string email)
        {


            return firstname == FirstName && lastname == LastName && email == EmailAddress;
        }

        public bool login(string firstname, string lastname, string email = null)
        {
            //if (email == null) 
            //    return CheckProfile (firstname, lastname);
            //return CheckProfile(firstname, lastname, email);
            return(email==null)? CheckProfile(firstname, lastname): CheckProfile(firstname, lastname, email);
        }
        public virtual void PassengerType()
        {
            Console.WriteLine(" I am Passenger HelloWorld");
        }

        #endregion
    }
}
