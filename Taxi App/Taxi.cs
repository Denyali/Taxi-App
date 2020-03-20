using System;
using System.Collection.Generic;
using System.linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        //Properties
        public string DriverName { get; set; }
        public int NumPassenger { get; set; }
        public bool OnDuty { get; set; }
        public int status { get; set; }
       
        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name  : {0}",DriverName);
            if (OnDuty == true)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            Console.WriteLine("On Duty  : {0}", status);
            Console.WriteLine("Number of Passenger  :{0}\n" NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }

         public void DropOffPassenger()
        {
           Console.WriteLine("{0} Sedang Mengatur Penumpang", DriverName);
        }

    }
 
}