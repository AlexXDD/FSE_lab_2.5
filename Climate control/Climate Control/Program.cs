using FSE_2._1;

namespace Climate_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            ECU ecu = new ECU();
            Menu.displayInformation(ecu);
        }
    }
}
