using System;

namespace Garage
{

    public interface IGasVehicle
    {
        void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        double FuelCapacity { get; }
        int CurrentTankPercentage { get; set; }
    }
}