using UnityEngine;
using System.Collections;

namespace FactoryMethod
{
	public class FactoryMethodSample : MonoBehaviour
	{
		void Start()
		{
			GameObject barracksObj = new GameObject("Barracks");
			GameObject starportObj = new GameObject("Starport");

			Building barracks = barracksObj.AddComponent<Barracks>();
			Building starport = starportObj.AddComponent<Starport>();

			Unit unit = barracks.CreateUnit("Marine");
			unit = barracks.CreateUnit("Firebat");
			unit = barracks.CreateUnit("Medic");

			unit = starport.CreateUnit("Wraith");
			unit = starport.CreateUnit("Dropship");
			unit = starport.CreateUnit("Battlecruiser");
		}

	} 
}
