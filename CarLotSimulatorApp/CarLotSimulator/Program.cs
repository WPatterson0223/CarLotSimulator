using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            CarLot ourCars = new CarLot();

            Car carOne = new Car();
            carOne.Year = 1965;
            carOne.Make = "Ford";
            carOne.Model = "Mustang";
            carOne.EngineNoise = "VROOM";
            carOne.HonkNoise = "BEEP";
            carOne.IsDriveable = true;
            ourCars.MyList.Add(carOne);

            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Console.WriteLine();

            Car carTwo = new Car(){Year = 1996, Make = "Lincoln", Model = "Mark VIII", EngineNoise = "MMMMMMMMM", HonkNoise = "TOOT", IsDriveable = false};
            ourCars.MyList.Add(carTwo);

            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHonkNoise(carTwo.HonkNoise);
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Console.WriteLine();

            Car carThree = new Car(2001, "Land Rover", "Discovery", "BLUBBLUB", "HONK", false);
            ourCars.MyList.Add(carThree);

            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Console.WriteLine();

            ourCars.PrintCars();

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
