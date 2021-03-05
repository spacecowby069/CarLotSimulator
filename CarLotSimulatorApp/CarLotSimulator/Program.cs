using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
            //TODO

            //Create a seperate class file called Car-DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-DONE
            //The methods should take one string parameter: the respective noise property-DONE


            //Now that the Car class is created we can instanciate 3 new cars-DONE
            //Set the properties for each of the cars-DONE
            //Call each of the methods for each car-DONE

            var car1 = new Car();
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
            car1.Year = 2010;
            car1.Make = "Honda";
            car1.Model = "CR-V";
            car1.EngineNoise = "Zooom";
            car1.HonkNoise = "Beep Beep";
            car1.IsDriveable = true;

            var car2 = new Car()
            {
                Year = 2018,
                Make = "Dodge",
                Model = "Charger",
                EngineNoise = "Whooom Whooom",
                HonkNoise = "Whoomp Whooomp",
                IsDriveable = true
            };
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Car car3 = new Car(5000, "Jupiter LTD", "WhirlyBird", "Whirrrrrrr", "Do space ships Honk?", true);
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            Console.WriteLine();

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            Console.WriteLine();

            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            Console.WriteLine();


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car-DONE



            //*************BONUS X 2*************//



            //Create a CarLot class-DONE
            //It should have at least one property: a List of cars-DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.-DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console-DONE

            carLot.ParkingLot = new List<Car>() { car1, car2, car3 };

            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
        }
    }
}
