using System;
using System.Globalization;
using System.Threading;
using GalacticGPS.Extensions;
using GalacticGPS.Graphs;

namespace GalacticGPS
{
    public static class GPSTester
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Location newLocation = new Location(45.2322, 11.23948, Planet.Uranus);

            //Console.WriteLine(newLocation);
            Console.WriteLine(Temperature.DrawTemperatureGraph());
            Console.WriteLine(SpaceRotation.LapDays(Planet.Saturn));
        }
    }
}

// Sample output:

//Mercury:
//  - Min Temp -> ##################/ -180 C
//  - Max Temp -> ###############################################/ 470C
//Venus:
//  - Min Temp -> #####################/ -210 C
//  - Max Temp -> ################################################/ 480C
//Earth:
//  - Min Temp -> #####/ -50 C
//  - Max Temp -> #####/ 50C
//Mars:
//  - Min Temp -> ##############/ -143 C
//  - Max Temp -> ####/ 35C
//Saturn:
//  - Min Temp -> ###################/ -185 C
//  - Max Temp -> #########/ -90C
//Jupiter:
//  - Min Temp -> ####################/ -195 C
//  - Max Temp -> ##########/ -100C
//Uranus:
//  - Min Temp -> ######################/ -215 C
//  - Max Temp -> ###############/ -150C
//Neptune:
//  - Min Temp -> ########################/ -240 C
//  - Max Temp -> ####################/ -200C

//It takes Saturn 10756 days to complete one full lap around the sun.
//That would be 29.47 earth years