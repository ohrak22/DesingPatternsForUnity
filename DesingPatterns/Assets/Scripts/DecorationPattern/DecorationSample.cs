using UnityEngine;
using System.Collections;

namespace Decoration
{
	public class DecorationSample : MonoBehaviour
	{
		void Start()
		{
			GameObject marineGo = new GameObject("Marine");
			GameObject goliathGo = new GameObject("Goliath");
			GameObject ZealotGo = new GameObject("Zealot");
			GameObject ZerglingGo = new GameObject("Zergling");

			Unit marine = marineGo.AddComponent<Unit>();
			Unit goliath = marineGo.AddComponent<Unit>();
			Unit zealot = marineGo.AddComponent<Unit>();
			Unit zergling = marineGo.AddComponent<Unit>();

			marine.health = new Health();
			marine.health = new Healable(marine.health);
			Debug.Log("Marine: " + marine.health.Info);

			goliath.health = new Health();
			goliath.health = new Repairable(goliath.health);
			Debug.Log("Goliath: " + goliath.health.Info);

			zealot.health = new Health();
			zealot.health = new Shield(zealot.health);
			zealot.health = new ShieldCare(zealot.health);
			zealot.health = new Healable(zealot.health);
			zealot.health = new Rechargeable(zealot.health);
			Debug.Log("Zealot: " + zealot.health.Info);

			zergling.health = new Health();
			zergling.health = new HealthCare(zergling.health);
			zergling.health = new Healable(zergling.health);
			Debug.Log("Zergling: " + zergling.health.Info);

		}

	}
}
