using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}\n");
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property - DONE


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var jakesCarLot = new CarLot();

            var car1 = new Car();
            car1.Year = "1967";
            car1.Make = "Chevy";
            car1.Model = "Impala";
            car1.EngineNoise = "VROOOOOM";
            car1.HonkNoise = "Honk!!";
            car1.IsDriveable = true;

            var car2 = new Car();
            
            car2.Year = "2023";
            car2.Make = "Lamborghini";
            car2.Model = "Aventador";
            car2.EngineNoise = "VROOOOOOOOOOM!!";
            car2.HonkNoise = "honk.";
            car2.IsDriveable = true;

            var car3 = new Car();

            car3.Year = "2007";
            car3.Make = "Jeep";
            car3.Model = "Wrangler";
            car3.EngineNoise = "Vroom";
            car3.HonkNoise = "honk";
            car3.IsDriveable = true;

            CarLot.numberOfCars++;
            Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}\n");
        }
        




    }
}      

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            //

