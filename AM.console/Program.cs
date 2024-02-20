// See https://aka.ms/new-console-template for more information
// delete using System.Numerics;

//right click on plane quick action then appuyer using AM.ApplicationCore.Domain; 

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System.Net.Mail;

Console.WriteLine("Hello, World!");
//constucteur vide ( par defaut)
//Plane plane = new Plane();
//plane.Capacity = 1;

// .Net manseta3mlouch constructeur
//Plane p1 = new Plane(0, PlaneType.Boing);

// *important* Initialisateur d'objet
Plane p11 = new Plane
{
    Capacity = 10, 
    ManufactureDate = new DateTime(2024/12/31),
    PlaneType= PlaneType.Boing

};
Passenger p1 = new Passenger
{
    FirstName= "fadi", LastName = "saidi"

};
Passenger p2 = new Passenger
{
    FirstName = "fadi",
    LastName = "saidi",
    EmailAddress = "fadi@esprit.tn"
};
Traveller t1 = new Traveller
{
    FirstName = "fadi",
    LastName = "saidi",
    EmailAddress = "fadi@esprit.tn"
};
Staff s1 = new Staff
{
    FirstName = "fadi",
    LastName = "saidi",
    EmailAddress = "fadi@esprit.tn"
};
// cwl + tab
Console.WriteLine("************ Poly par signature ********** ");
Console.WriteLine(p1.CheckProfile("test" , "test"));
Console.WriteLine(p2.login("fadi", "saidi" , "fadi@esprit.tn"));
Console.WriteLine("************ Poly par héritage ********** ");
p1.PassengerType();
t1.PassengerType();
s1.PassengerType();
// ***************
FlightMethod sf = new FlightMethod();
sf.flights = TestData.listFlights;
Console.WriteLine("***Getflightdates****");
foreach(var item in sf.GetFlightDates("Madrid"))
{
    Console.WriteLine("Date"+item);
}
Console.WriteLine("****ShowFlightDetail******");
sf.ShowFlightDetails(TestData.BoingPlane);
Console.WriteLine("*******DestinationGroupedFlight********");
sf.DestinationGroupedFlights();