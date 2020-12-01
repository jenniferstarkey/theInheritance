using System;
namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; } = 100;
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The red Ram drives by. Ruuuummmmbbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram takes a wide {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Ram slows to a stop.");
        }
    }
}