using UnityEngine;
using System.Collections;
using System;

namespace AbstractFactory
{
	public class ProtossBuilder : Factory
	{
		public override Building CreateCenterBuilding()
		{
			return new Nexus();
		}
		public override Building CreatePopulationBuilding()
		{
			return new Pylon();
		}
		public override Building CreateArmyBuilding()
		{
			return new Stargate();
		}
		public override Building CreateAirForceBuilding()
		{
			return new Starport();
		}
	}
}
