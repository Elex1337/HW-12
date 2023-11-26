using System.Diagnostics;
using System;
using HW_12;

class Program
{
    static void Main()
    {
        var sportsCar = new SportsCar("Спортивный автомобиль");
        var passengerCar = new PassengerCar("Легковой автомобиль");
        var truck = new Truck("Грузовик");
        var bus = new Bus("Автобус");

        Car[] cars = { sportsCar, passengerCar, truck, bus };

        RaceGame raceGame = new RaceGame();

        raceGame.RaceFinished += (message) =>
        {
            Console.WriteLine("\nГонка завершена!");
            Console.WriteLine(message);
        };

        raceGame.StartRace(cars, 100);
    }
}