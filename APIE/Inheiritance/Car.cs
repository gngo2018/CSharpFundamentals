using System;
using System.Collections.Generic;
using System.Text;

namespace APIE.Inheiritance
{
    public class Car
    {
        //Fields/Properties
        public bool IsSedan { get; set; }
        public string Seats { get; set; }
        public string Mileage { get; set; }

        //Service Methods
        public bool SedanBool(bool output)
        {
            Console.WriteLine("Is your vehicle a sedan? 0 for no, 1 for yes");
            string answer = Console.ReadLine();

            if (answer.Contains("0"))
            {
                IsSedan = false;
            }
            else
            {
                IsSedan = true;
            }

            output = IsSedan;

            return output;

        }
        public string GetMileage(string mileage)
        {
            Console.WriteLine("How many miles are there on your vehicle?");
            mileage = Console.ReadLine();

            return mileage;
        }

    }
}
