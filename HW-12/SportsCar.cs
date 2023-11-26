using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    class SportsCar : Car
    {
        public SportsCar(string name) : base(name, new Random().Next(150, 200)) { }
    }

    class PassengerCar : Car
    {
        public PassengerCar(string name) : base(name, new Random().Next(100, 150)) { }
    }

    class Truck : Car
    {
        public Truck(string name) : base(name, new Random().Next(80, 120)) { }
    }

    class Bus : Car
    {
        public Bus(string name) : base(name, new Random().Next(60, 100)) { }
    }
}
