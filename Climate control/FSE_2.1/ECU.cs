using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSE_2._1
{
    public class ECU
    {
        private flowDirection airFlow;
        private Sensor sensor;

        public ECU()
        {
            airFlow = flowDirection.automatic;
            sensor = new Sensor();
        }

        public flowDirection AirDirection
        {
            get
            {
                return airFlow;
            }

            set
            {
                airFlow = value;
            }
        }

        public int Temperature
        {
            get
            {
                return sensor.InteriorTemperature;
            }

            set
            {
                sensor.InteriorTemperature = value;
            }
        }

        public enum flowDirection {automatic, legs, face,
            face_legs, windshield, windshield_legs  }
    }
}
