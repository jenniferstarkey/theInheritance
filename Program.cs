using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram model1500 = new Ram();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            model1500.Drive();
        }
    }
}
