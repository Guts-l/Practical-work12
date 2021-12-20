using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_12_teselko_01._01
{
    internal class Coordinates
    {
        public double GetDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return Math.Round(distance, 3);
        }
    }
}
