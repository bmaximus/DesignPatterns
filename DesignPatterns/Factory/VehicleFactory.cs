namespace DesignPatterns.Factory
{
    public static class VehicleFactory
    {
        public static Vehicle GetVehicleByPrice(int price)
        {
            if (price < 10000)
            {
                return new Sedan();
            }
            else if (price > 10000 && price <= 1000000)
            {
                return new Truck();
            }
            else if (price > 1000000)
            {
                return new Racing();
            }
            return null;
        }
    }
}
