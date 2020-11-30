using System;

public class Ram : Vehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }
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