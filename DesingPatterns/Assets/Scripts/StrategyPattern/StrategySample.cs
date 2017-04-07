using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class StrategySample : MonoBehaviour
	{
		void Start()
		{
			GameObject marineGo = new GameObject("Marine");
			GameObject FirebatGo = new GameObject("Firebat");
			GameObject medicGo = new GameObject("Medic");

			Unit marine = marineGo.AddComponent<Marine>();
			Unit Firebat = FirebatGo.AddComponent<Firebat>();
			Unit medic = medicGo.AddComponent<Medic>();

			marine.Attack();
			Firebat.Attack();
			medic.Attack();
		}
	} 
}
