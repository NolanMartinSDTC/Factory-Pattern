using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(int tireCount)
		{
			switch (tireCount)
			{
				case 2:
				case 3:
					return new Motorcycle();
				case 4:
					return new Car();
				default:
					return new Car();
			}
		}
	}
}

