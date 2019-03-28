using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiEstimation
{
    class PiTest
    {

        public Coords[] RandomCoords(int arraySize)
        {
            var coords = new Coords[arraySize];
            var random = new Random();

            for (int x = 0; x < arraySize; x++)
            {
                coords[x] = new Coords(random.NextDouble(), random.NextDouble());
            }

            return coords;
        }

        public double Hypo(Coords coords)
        {
            return Math.Sqrt(Math.Pow(coords.X, 2) + Math.Pow(coords.Y, 2));
        }

        public double OverlapCounter(Coords[] coords)
        {

            int counter = 0;

            foreach (var coord in coords)
            {

                if (Hypo(coord) <= 1)
                {
                    counter += 1;
                }
            }
            return counter;
        }
        
        public double CalcPi(int number)
        {
            var rndCoors = RandomCoords(number);
            var circleOverlap = OverlapCounter(rndCoors);

            return circleOverlap / rndCoors.Length * 4;
        }
    }
}
