using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc
{
    public class WoodCalc
    {
        public float WindowHeight { get; set; }
        public float WindowWidth { get; set; }       
        public static float TotalWoodLength(float winHeight,
           float winWidth)
        {
            return (winHeight * 2) + (winWidth * 2);
        }
        public static float MeterToFeet(float totalLength)
        {
            double result = (totalLength * 3.25);
            float result1 = (float)result;

            return result1;
        }
    }
    public class Glasscalc
    {
        public float windowHeight { get; set; }
        public float windowWidth { get; set; }
        public static float AreaOfGlass(float height, float width)
        {
            return height * width;
        }
    }
}
