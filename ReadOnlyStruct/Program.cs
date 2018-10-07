using System;

namespace ReadOnlyStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadOnlyStruct");

            var c = new Car(1, "honda", 1.4F);
            ShowCar(c);

            Console.ReadLine();
        }

        // the method receive one reference of car, the access will be
        // direct to the object that was passed as argument, not to a copy
        static void ShowCar(in Car c)
        {
            Console.WriteLine($"The car {c.Name} have motor {c.Motor} ");
        }
    }

    readonly struct Car // put readonly in struct
    {
        public Car(int id, string name, float motor)
        {
            Id = id;
            Name = name;
            Motor = motor;
        }

        public int Id { get; } // properties can not be set
        public string Name { get; } // properties can not be set
        public float Motor { get; } // properties can not be set

        private readonly static string minMotor = "1.0"; // fields need readonly
        public static ref readonly string MinMotor => ref minMotor; // fields need readonly
    }
}
