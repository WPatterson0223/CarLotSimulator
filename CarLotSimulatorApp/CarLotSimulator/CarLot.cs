using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot()
		{
			
		}
		public static int numberOfCars;
		public List<Car> MyList = new List<Car>();
		public void PrintCars()
		{
			foreach (Car car in MyList)
			{
				Console.WriteLine($"{car.Year} {car.Make}, {car.Model}");
			}
		}
	}
}

