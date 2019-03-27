using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiEstimation
{
    public struct Coords
    {
        public double X;
        public double Y;

        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Coords(Random random)
        {
            X = random.NextDouble();
            Y = random.NextDouble();
        }

    }
}
