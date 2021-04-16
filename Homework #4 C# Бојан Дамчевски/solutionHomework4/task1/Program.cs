using System;
using task1.Models;

namespace task1
{
    class Program
    {
        static void GetDriversAndCars(Driver[] driverObject, Car[] carObject)
        {
            int counter1 = 1;
            Console.WriteLine("Drivers:\n");
            foreach (Driver driver in driverObject)
            {
                Console.Write("{0}. {1} |", counter1, driver.Name);
                counter1++;
            }
            int counter2 = 1;
            Console.WriteLine("\nCars:\n");
            foreach (Car car in carObject)
            {
                Console.Write("{0}. {1} |", counter2, car.Model);
                counter2++;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Choose car brands and drivers !");
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

                    GetDriversAndCars(drivers, cars);

                    Car[] raceCar1Object = new Car[1];
                    Car[] raceCar2Object = new Car[1];

                    int i = 0;
                    Console.WriteLine("\nEnter first driver");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter first car brand");
                    string car = Console.ReadLine();
                    int k = 0;

                    while (k < cars.Length)
                    {
                        if (car.ToLower() == cars[k].Model.ToLower())
                        {
                            raceCar1Object[0] = cars[k];
                            flag = false;
                            break;
                        }
                        k++;
                    }

                    while (i < drivers.Length)
                    {
                        if (name.ToLower() == drivers[i].Name.ToLower())
                        {
                            raceCar1Object[0].Driver = drivers[i];
                            flag = false;
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
                            Console.Clear();
                            Console.WriteLine("Can not use the same car brand");
                            flag = true;
                        }
                        if (car1.ToLower() == cars[j].Model.ToLower())
                        {
                            raceCar2Object[0] = cars[j];
                            flag = false;
                            break;
                        }
                        j++;
                    }

                    int e = 0;

                    while (e < drivers.Length)
                    {
                        if (raceCar1Object[0].Driver.Name.ToLower() == name1.ToLower())
                        {
                            Console.Clear();
                            Console.WriteLine("Can not use the same racer");
                            flag = true;
                        }
                        if (name1.ToLower() == drivers[e].Name.ToLower())
                        {
                            raceCar2Object[0].Driver = drivers[e];
                            flag = false;
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
