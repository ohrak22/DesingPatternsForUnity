using UnityEngine;
using System.Collections;
using System;

namespace FactoryMethod
{
	public class Barracks : Building
	{
		public override Unit CreateUnit(string type)
		{
			Debug.Log(name + ": " + type + " creation...");
			GameObject go = new GameObject(type);
			Unit unit = null;

			if(type == "Marine")
			{
				unit = go.AddComponent<Marine>();
			}
			else if(type == "Firebat")
			{
				unit = go.AddComponent<Firebat>();
			}
			else if(type == "Medic")
			{
				unit = go.AddComponent<Medic>();
			}

			Debug.Log(name + ": " + type + " creation completed.");

			return unit;
		}
	}
}
