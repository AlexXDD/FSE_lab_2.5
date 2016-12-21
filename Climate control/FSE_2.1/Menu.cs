using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSE_2._1
{
    public static class Menu
    {
        public static void displayInformation(ECU ecu)
        {
            Console.WriteLine("Flow direction mode: " + ecu.AirDirection 
                + "\nInterior temperature: " + ecu.InteriorTemerature
                + "\nExterior temperature: " + ecu.ExteriorTemperature);
        }
    }
}
