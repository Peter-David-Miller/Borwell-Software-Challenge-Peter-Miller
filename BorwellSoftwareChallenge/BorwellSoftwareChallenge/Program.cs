using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellSoftwareChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input and converting them into strings.

            Console.WriteLine("Input Room Length (in meters)");
            string Length = Console.ReadLine();
            Console.WriteLine("Input Room Width (in meters)");
            string Width = Console.ReadLine();
            Console.WriteLine("Input Room Height (in meters)");
            string Height = Console.ReadLine();

            Double LengthInt = 0;
            Double WidthInt = 0;
            double HeightInt = 0;
            Boolean InputValid = true;
            // Checking if the inputting Strings are in Numeric format, allowing for conversion to Doubles.
            try
            {
                LengthInt = Convert.ToDouble(Length);
                WidthInt = Convert.ToDouble(Width);
                HeightInt = Convert.ToDouble(Height);
            }
            // Displaying error message should the Strings not be in a numberic format
            catch (Exception)
            {
                Console.WriteLine("Inputted strings was not the correct format, The strings must be numberic");
                InputValid = false;
            }

            if (InputValid == true)
            {
                // Working out Area

                double Area = LengthInt * WidthInt;
                Console.WriteLine("The Area is " + Area + "m^2");

                // Working out paint required

                double LengthsWall_surface_area = LengthInt * HeightInt * 2;
                Console.WriteLine("The total surface areas of the length side walls is " + LengthsWall_surface_area + "m^2");
                double WidthsWall_surface_area = WidthInt * HeightInt * 2;
                Console.WriteLine("The total surface areas of the width side walls is " + WidthsWall_surface_area + "m^2");
                double Total_wall_surface_area = LengthsWall_surface_area + WidthsWall_surface_area;
                Console.WriteLine("The total surface area for the room is " + Total_wall_surface_area + "m^2");
                double Paint_required = Total_wall_surface_area / 10;
                Console.WriteLine("When assuming 10m^2 per 1 litre of paint, to paint all the walls you need " + Paint_required + " litres of paint.");

                //Working out Volume
                double Volume = LengthInt * WidthInt * HeightInt;
                Console.WriteLine("The rooms Volume is " + Volume + "m^3");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
