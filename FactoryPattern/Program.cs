namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of wheels to build a motorized vehicle: ");
            int userWheels = int.Parse(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(userWheels);
            vehicle.Drive();

        }
    }
}
