namespace FSE_2._1
{
    public class Sensor
    {
        private int exteriorTemp, interiorTemp;

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

        public void IncreaseTemperature()
        {
            interiorTemp++;
        }

        public void DecreaseTemperature()
        {
            interiorTemp--;
        }
    }
}
