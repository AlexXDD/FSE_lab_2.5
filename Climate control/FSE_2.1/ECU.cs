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
        public int ExteriorTemperature
        {
            get
            {
                return sensor.ExteriorTemperature;
            }
        }
        public int InteriorTemerature
        {
            get
            {
                return sensor.InteriorTemperature;
            }
        }
        public enum flowDirection {automatic, legs, face,
            face_legs, windshield, windshield_legs  }
    }
}
