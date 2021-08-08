using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface ICountNofWheels
    {
        string TotalNoOfWheels
        {
            get;
        }
    }    
    class ShowTotalNoOfWheels
    {
        public void DisplayNoOfWheels(ICountNofWheels car)
        {
            Console.WriteLine(car.TotalNoOfWheels);
        }
    }
    // Tata Car have 4 Wheels
    class TataCar : ICountNofWheels
    {

        public string TotalNoOfWheels
        {
            get { return "4 Wheels"; }
        }
    }
    // Mahindra Car have 4 Wheels
    class MahindraCar : ICountNofWheels
    {
        public string TotalNoOfWheels
        {
            get { return "4 Wheels"; }
        }
    }

    // But.. Eicher Truck has 6 wheels
    class EicherTruck 
    {
        public string NoOfWheels
        {
            get { return "6 Wheels"; }
        }
    }
    class TruckAdapter : ICountNofWheels
    {
        private EicherTruck _truck;
        public TruckAdapter(EicherTruck truck)
        {
            this._truck = truck;
        }        
        public string TotalNoOfWheels
        {
            get { return _truck.NoOfWheels; }
        }
    }
    class Program2
    {
        public static void Main()
        {
            EicherTruck truck = new EicherTruck();
            TruckAdapter truckAdapter = new TruckAdapter(truck);
            ShowTotalNoOfWheels showTotalNoOfWheels = new ShowTotalNoOfWheels();
            showTotalNoOfWheels.DisplayNoOfWheels(truckAdapter);

            Console.ReadLine();
        }
    }
}
