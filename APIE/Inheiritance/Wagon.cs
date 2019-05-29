using System;
using System.Collections.Generic;
using System.Text;

namespace APIE.Inheiritance
{
    public class Wagon : Car
    {
        public Car WagonR()
        {
            Wagon wagon = new Wagon();
            var str = "";
            bool b = false;
            wagon.IsSedan = wagon.SedanBool(b);
            wagon.Seats = "4";
            wagon.Mileage = wagon.GetMileage(str);
            Console.WriteLine($"A Wagon is a sedan = {wagon.IsSedan}, has {wagon.Seats} seats, and gets about {wagon.Mileage} kmpl");

            return wagon;
        }
        
    }
}
