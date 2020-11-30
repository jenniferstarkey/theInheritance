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
            fxs.Turn("right");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            model1500.Drive();
            model1500.Turn("right");
            model1500.Stop();

        }
    }
}
