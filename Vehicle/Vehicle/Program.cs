using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle Excercises");

            Vehicle vh1 = new Vehicle("Mini", "Cooper", "2000");
            Console.WriteLine(vh1.GetInfo());

            Car car1 = new Car("Nova", "Vauxhall", "1980");
            Console.WriteLine(car1.GetInfoCar());

        }
    }
}
