using UnityEngine;
using System.Collections;

namespace AbstractFactory
{
	public abstract class Factory : MonoBehaviour
	{
		public abstract Building CreateCenterBuilding();
		public abstract Building CreatePopulationBuilding();
		public abstract Building CreateArmyBuilding();
		public abstract Building CreateAirForceBuilding();
	} 
}
