namespace DesignPatterns.Factory
{
    public class Truck : Vehicle
    {
        public override string VehicleName()
        {
            return "Scania Truck Car";
        }

        public override int VehiclePrice()
        {
            return 15000;
        }
    }
}
