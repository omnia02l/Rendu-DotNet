using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{//2 éme methode
    //public enum PlaneType
    //{
    //    Boing, Airbus
    //}
    public class Plane
    {
        //public Plane(int planedId, PlaneType planeType)
        //{
        //    PlanedId = planedId;
        //    PlaneType = planeType;
        //}
        #region exemple java
        //public int Capacity;
        //public int getCapacity()
        //{
        //    return Capacity;
        //}
        //public void setCapacity(int capacity) {
        //    this.Capacity = capacity;
        //}
        #endregion
        #region propp version
        //        //prop + tab
        //        //prop = declaration +getter and setter
        //        //version Light
        //public int Capacity { get; set; }
        //        //propg + tab (private sur set) 
        //        //version secure
        //public int MyPropertys { get; private set; }
        //        //propfull + tab
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        #endregion
        #region propp de base
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlanedId { get; set; }
        public PlaneType PlaneType { get; set; }

        #endregion
        #region propp de navigation
        //IList<> = Interface != List
        // IList<> == ICollection
        public IList<Flight> Flights { get; set; }


        #endregion
    }
}

//test 