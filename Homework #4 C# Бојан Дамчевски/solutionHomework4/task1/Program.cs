using System;
using task1.Models;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Choose car brands and drivers !");
                Console.WriteLine("1.Bob 2.Greg 3.Jill 4.Anne");
                Console.WriteLine("1.Hyundai 2.Mazda 3.Ferrari 4.Porsche");

                Driver[] drivers =
                {
                new Driver("Bob", 5),
                new Driver("Greg", 4),
                new Driver("Jill", 3),
                new Driver("Anne", 2)
            };

                Car[] cars =
                {
                new Car("Hyundai", 150),
                new Car("Mazda", 200),
                new Car("Ferrari", 250),
                new Car("Porsche", 300)
            };

                Car[] raceCar1Object = new Car[1];
                Car[] raceCar2Object = new Car[1];

                int i = 0;
                Console.WriteLine("Enter first driver");
                string name = Console.ReadLine();
                Console.WriteLine("Enter first car brand");
                string car = Console.ReadLine();
                int k = 0;

                while (k < cars.Length)
                {
                    if (car.ToLower() == cars[k].Model.ToLower())
                    {
                        raceCar1Object[0] = cars[k];
                        break;
                    }
                    k++;
                }

                while (i < drivers.Length)
                {
                    if (name.ToLower() == drivers[i].Name.ToLower())
                    {
                        raceCar1Object[0].Driver = drivers[i];
                        break;
                    }
                    i++;
                }
                int j = 0;
                Console.WriteLine("Enter second driver");
                string name1 = Console.ReadLine();
                Console.WriteLine("Enter second car brand");
                string car1 = Console.ReadLine();

                while (j < cars.Length)
                {
                    if (raceCar1Object[0].Model.ToLower() == car1.ToLower())
                    {
                        throw new Exception("Can not use the same car brand");
                    }
                    if (car1.ToLower() == cars[j].Model.ToLower())
                    {
                        raceCar2Object[0] = cars[j];
                        break;
                    }
                    j++;
                }

                int e = 0;

                while (e < drivers.Length)
                {
                    if (raceCar1Object[0].Driver.Name.ToLower() == name1.ToLower())
                    {
                        throw new Exception("Can not use the same racer");
                    }
                    if (name1.ToLower() == drivers[e].Name.ToLower())
                    {
                        raceCar2Object[0].Driver = drivers[e];
                        break;
                    }
                    e++;
                }

                RaceCars(raceCar1Object[0], raceCar2Object[0]);

                Console.WriteLine("Do you want to race again ? (yes/no)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "no")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }

        }
        static void RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed(car1.Driver) > car2.CalculateSpeed(car2.Driver))
            {
                Console.WriteLine($"The racer {car1.Driver.Name} with the car {car1.Model} with speed of {car1.Speed}km/h is the winner !");
            }
            else if (car1.CalculateSpeed(car1.Driver) < car2.CalculateSpeed(car2.Driver))
            {
                Console.WriteLine($"The racer {car2.Driver.Name} with the car {car2.Model} with speed of {car2.Speed}km/h is the winner !");
            }
            else
            {
                Console.WriteLine("It's a tie !");
            }
        }
    }
}
