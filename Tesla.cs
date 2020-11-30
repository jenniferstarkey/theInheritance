using System;

public class Tesla : Vehicle // Electric car
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine("The white Tesla glides by. Vrooommm!");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"The Tesla turns sharply to the {direction}.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The Tesla haults to a stop.");
    }

}