using UnityEngine;
using System.Collections;

namespace AbstractFactory
{
	public class AbstractFactorySample : MonoBehaviour
	{
		void Start()
		{
			//Probe
			GameObject scvObj = new GameObject("SCV");
			GameObject probeObj = new GameObject("Probe");

			TerranBuilder scv = scvObj.AddComponent<TerranBuilder>();
			ProtossBuilder probe = probeObj.AddComponent<ProtossBuilder>();

			Building building = scv.CreateCenterBuilding();
			Debug.Log(building.GetType().Name + " build completed!");
			building = scv.CreatePopulationBuilding();
			Debug.Log(building.GetType().Name + " build completed!");
			building = scv.CreateArmyBuilding();
			Debug.Log(building.GetType().Name + " build completed!");
			building = scv.CreateAirForceBuilding();
			Debug.Log(building.GetType().Name + " build completed!");

			building = probe.CreateCenterBuilding();
			Debug.Log(building.GetType().Name + " build completed!");
			building = probe.CreatePopulationBuilding();
			Debug.Log(building.GetType().Name + " build completed!");
			building = probe.CreateArmyBuilding();
			Debug.Log(building.GetType().Name + " build completed!");
			building = probe.CreateAirForceBuilding();
			Debug.Log(building.GetType().Name + " build completed!");
		}
	}
}
