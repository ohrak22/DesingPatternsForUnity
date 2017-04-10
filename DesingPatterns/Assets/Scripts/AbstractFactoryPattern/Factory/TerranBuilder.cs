using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace AbstractFactory
{
	public class TerranBuilder : Factory
	{
		public override Building CreateCenterBuilding()
		{
			return new CommandCenter();
		}
		public override Building CreatePopulationBuilding()
		{
			return new SupplyDepot();
		}
		public override Building CreateArmyBuilding()
		{
			return new Barracks();
		}
		public override Building CreateAirForceBuilding()
		{
			return new Starport();
		}
	}
}
