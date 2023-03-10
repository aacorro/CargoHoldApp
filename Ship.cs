using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CargoHold
{
	public class Ship
	{
		//constant values
		const int CYCLE_WEIGHT = 3;
		const int CAR_WEIGHT = 5;
		const int TRUCK_WEIGHT = 11;
		const int TRAIN_WEIGHT = 17;

		const int MAX_WEIGHT = 10;

		// properties
		public int Capacity { get; set; }

		public int CycleCount { get; set; }
		public int CarCount { get; set; }
		public int TruckCount { get; set; }
		public int TrainCount { get; set; }

		Random random = new Random();

		

		// methods
		public int getShipLoaded()
		{
			//calculate the total weight of the cargo on the ship
			return CycleCount * CYCLE_WEIGHT + CarCount * CAR_WEIGHT + TruckCount * TRUCK_WEIGHT + TrainCount * TRAIN_WEIGHT;
		}

		// constructor
		public Ship()
		{
			CycleCount = 0;
			CarCount = 0;
			TruckCount = 0;
			TrainCount = 0;

			//create a random sized ship
			Capacity = random.Next(MAX_WEIGHT) * CYCLE_WEIGHT + random.Next(MAX_WEIGHT) * CAR_WEIGHT + random.Next(MAX_WEIGHT) * TRUCK_WEIGHT + random.Next(MAX_WEIGHT) * TRAIN_WEIGHT;
		}

		public int overUnder()
		{
			//return a value of how loaded the ship is
			return Capacity - getShipLoaded();
		}

		public override string ToString()
		{
			return $"Capacity = {Capacity}, CurrentLoad = {getShipLoaded()}";
		}

	}
}
