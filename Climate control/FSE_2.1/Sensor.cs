namespace FSE_2._1
{
    public class Sensor
    {
        private int exteriorTemp, interiorTemp;

        public Sensor()
        {
            exteriorTemp = 0; // Here must be exterior temperature
            interiorTemp = 22; // Here must be interior temperature
        }
    
        public int ExteriorTemperature
        {
            get
            {
               return exteriorTemp;
            }
        }

        public int InteriorTemperature
        {
            get
            {
                return interiorTemp;
            }
        }
    }
}
