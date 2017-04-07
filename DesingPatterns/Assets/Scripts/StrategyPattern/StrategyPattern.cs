using UnityEngine;
using System.Collections;

public class StrategyPattern : MonoBehaviour
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
