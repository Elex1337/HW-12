using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public delegate void RaceEventHandler(string message);
        public event RaceEventHandler RaceEvent;

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public virtual void StartRace()
        {
            RaceEvent?.Invoke($"{Name} начинает гонку!");
        }

        public virtual void Move()
        {
            RaceEvent?.Invoke($"{Name} двигается со скоростью {Speed} км/ч");
        }

        public virtual void FinishRace()
        {
            RaceEvent?.Invoke($"{Name} финишировал!");
        }
    }
}
