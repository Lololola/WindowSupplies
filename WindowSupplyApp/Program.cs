﻿using GlazerCalc;
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
                Console.Write("Type in Window Height (in meters): ");
                double windowHeight = Double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Type in Window Width (in meters): ");
                double windowWidth = Double.Parse(Console.ReadLine());
                Console.WriteLine();

                double totalWood = WoodCalc.TotalWoodLength(
                    windowHeight, windowWidth);
                double totalWoodNeeded = WoodCalc.MeterToFeet(totalWood);
                Console.WriteLine("TOTAL LENGTH OF WOOD REQUIRED: {0} feet",
                    totalWoodNeeded);
                double areaOfGlass = Glasscalc.AreaOfGlass(
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