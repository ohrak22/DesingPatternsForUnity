using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class StrategySample : MonoBehaviour
	{
		void Start()
		{
			GameObject marineGo = new GameObject("Marine");
			GameObject firebetGo = new GameObject("Firebet");
			GameObject medicGo = new GameObject("Medic");

			Unit marine = marineGo.AddComponent<Marine>();
			Unit firebet = firebetGo.AddComponent<Firebet>();
			Unit medic = medicGo.AddComponent<Medic>();

			marine.Attack();
			firebet.Attack();
			medic.Attack();
		}
	} 
}
