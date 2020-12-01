using System;
namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; } = 100;
        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("The black Zero whips by. Skkkkuuuurrrrtttt!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Zero comes to a slow stop.");
        }
    }
}