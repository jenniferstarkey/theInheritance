using System;
public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Turn(string direction)
    {
        Console.WriteLine($"The vehicle turns {direction}");
    }
    public virtual void Stop()
    {
        Console.WriteLine("The vehicle comes to a stop.");
    }
}