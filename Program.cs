


namespace ASSIGNMENT_7_4
{
    public class Program
    {

        static void Main()
        {
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);

            Console.WriteLine(parkingSystem.Addcar(1));

            Console.WriteLine(parkingSystem.Addcar(2));

            Console.WriteLine(parkingSystem.Addcar(3));

            Console.WriteLine(parkingSystem.Addcar(1));

        }
    }
}

