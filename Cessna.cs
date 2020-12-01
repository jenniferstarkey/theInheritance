using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; } = 100;
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("The silver Cessna speeds by! ZOOOOOOOMMMMM!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna glides to the {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Cessna slows to a stop.");
        }
    }
}