using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    class RaceGame
    {
        public event Car.RaceEventHandler RaceFinished;

        public void StartRace(Car[] cars, int finishDistance)
        {
            Console.WriteLine("Гонка началась!");
            foreach (var car in cars)
            {
                car.RaceEvent += HandleRaceEvent;
                car.StartRace();
            }

            while (true)
            {
                foreach (var car in cars)
                {
                    car.Move();
                    if (new Random().Next(0, 10) == 0) 
                        car.Speed += new Random().Next(5, 20);

                    if (car.Speed > 0)
                        car.Speed -= 1;

                    if (car.Speed <= 0)
                    {
                        car.FinishRace();
                        RaceFinished?.Invoke($"{car.Name} пришел к финишу!");
                        return;
                    }
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void HandleRaceEvent(string message)
        {
            Console.WriteLine(message);
        }
    }
}
