using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace GarageLexicon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Welcome to the garage! Press the number of the action you wish to executive \n" +
                "1. List all parked cars \n" +
                "2. Add or remove vehicles from the garage");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                case 1:
                    listVehicles();
                    break;
                case 2:

                    break;
                case 0:
                    runProgram = false;
                    break;
                }
            }
        }
        static void listVehicles()
        {

        }

        static void createGarage()
        {
            Console.WriteLine("How big should the garage be, how many parking spaces does the garage have?");
            int size = Convert.ToInt32(Console.ReadLine());
            Garage<Vehicle> garage = new(size);
        }
    }
}
