using GlazerCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowSupplyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total Supplies Needed for"
                +" " + "1 Double Glazed Window");
            Console.WriteLine();
            while (RecurringDisplayMenu())
            {
                Console.WriteLine(RecurringDisplayMenu());
            }
            Console.ReadLine();
        }
        public static bool RecurringDisplayMenu()
        {
            if (true)
            {
                const double MAX_WIDTH = 5.0;
                const double MIN_WIDTH = 0.5;
                const double MAX_HEIGHT = 3.0;
                const double MIN_HEIGHT = 0.75;

                Console.Write("Type in Window Height (in meters): ");
                float windowHeight = float.Parse(Console.ReadLine());
                if (windowHeight < MIN_HEIGHT)
                {
                    Console.WriteLine("\n\nHeight is too small.\n\n");
                    Console.WriteLine("Using minimum height: 0.75 meters");
                    windowHeight = (float)MIN_HEIGHT;
                }
                if (windowHeight > MAX_HEIGHT)
                {
                    Console.WriteLine("\n\nHeight is too large.\n\n");
                    Console.WriteLine("Using maximum height: 3.0 meters");
                    windowHeight = (float)MAX_HEIGHT;
                }
                Console.WriteLine();
                Console.Write("Type in Window Width (in meters): ");
                float windowWidth = float.Parse(Console.ReadLine());
                if (windowWidth < MIN_WIDTH)
                {
                    Console.WriteLine("\n\nWidth is too small.\n\n");
                    Console.WriteLine("Using minimum width: 0.5 meters");
                    windowWidth = (float)MIN_WIDTH;
                }
                if (windowWidth > MAX_HEIGHT)
                {
                    Console.WriteLine("\n\nWidth is too large.\n\n");
                    Console.WriteLine("Using maximum width: 5.0 meters");
                    windowWidth = (float)MAX_WIDTH;
                }
                Console.WriteLine();

                float totalWood = WoodCalc.TotalWoodLength(
                    windowHeight, windowWidth);
                double totalWoodNeeded = WoodCalc.MeterToFeet(totalWood);
                Console.WriteLine("TOTAL LENGTH OF WOOD REQUIRED: {0} feet",
                    totalWoodNeeded);
                float areaOfGlass = Glasscalc.AreaOfGlass(
                    windowHeight, windowWidth);
                Console.WriteLine("TOTAL AREA OF GLASS REQUIRED: "
                    + "2 sheets of {0} sq. meters",
                    areaOfGlass);
                Console.WriteLine();
                return true;
            }
        }
    }
}
