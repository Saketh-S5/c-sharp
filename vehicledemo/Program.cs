namespace vehicledemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Model X", "Tesla", 99.99);
            vehicle.display();

            Car car = new Car("Civic", "Honda", 79.99, 5, "Petrol");
            car.display();
        }
    }
}