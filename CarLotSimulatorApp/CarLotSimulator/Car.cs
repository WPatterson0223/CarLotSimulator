using System;
using System.Reflection;

namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{

		}
		public Car(int carYear, string carMake, string carModel, string carEngineNoise, string carHonkNoise, bool carIsDriveable)
		{
			Year = carYear;
			Make = carMake;
			Model = carModel;
			EngineNoise = carEngineNoise;
			HonkNoise = carHonkNoise;
			IsDriveable = carIsDriveable;

		}

		public int Year;
		public string Make;
		public string Model;
		public string EngineNoise;
		public string HonkNoise;
		public bool IsDriveable;

		public static void MakeEngineNoise(string noise)
		{
			Console.WriteLine(noise);
		}

		public static void MakeHonkNoise(string noise)
		{
			Console.WriteLine(noise);
		}
	}
}

