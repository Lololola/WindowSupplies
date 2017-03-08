using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc
{
    public class WoodCalc
    {
        public double windowHeight { get; set; }
        public double windowWidth { get; set; }
        public static double TotalWoodLength(double winHeight,
           double winWidth)
        {
            return (winHeight * 2) + (winWidth * 2);
        }
        public static double MeterToFeet(double totalLength)
        {
            return totalLength * 3.25;
        }
    }
    public class Glasscalc
    {
        public double windowHeight { get; set; }
        public double windowWidth { get; set; }
        public static double AreaOfGlass(double height, double width)
        {
            return height * width;
        }
    }
}
