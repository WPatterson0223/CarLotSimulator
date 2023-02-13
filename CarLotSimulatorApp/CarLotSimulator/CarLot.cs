using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot()
		{
		}
		public static List<Car> MyList = new List<Car>();

		public static void AddCar(Car newCar)
		{
			MyList.Add(newCar);
		}
		public static void PrintCars()
		{
			foreach (Car item in MyList)
			{
				Console.WriteLine($"{item.Year}, {item.Make} {item.Model}");
			}
		}
	}
}

