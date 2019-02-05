namespace DesignPatterns.Factory
{
    public class Racing : Vehicle
    {
        public override string VehicleName()
        {
            return "Formula 1 Racing Car";
        }

        public override int VehiclePrice()
        {
            return 15000000;
        }
    }
}
