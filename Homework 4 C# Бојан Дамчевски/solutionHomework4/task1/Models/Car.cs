using System;
using System.Collections.Generic;
using System.Text;

namespace task1.Models
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public int CalculateSpeed(Driver driver)
        {
            int totalSpeed = 0;
            totalSpeed = driver.Skill * Speed;
            return totalSpeed;
        }
    }
}
