namespace DesignPatterns.Factory
{
    public class Sedan : Vehicle
    {
        public override string VehicleName()
        {
            return "Toyota Avensis Sedan Car";
        }

        public override int VehiclePrice()
        {
            return 2000;
        }
    }
}
