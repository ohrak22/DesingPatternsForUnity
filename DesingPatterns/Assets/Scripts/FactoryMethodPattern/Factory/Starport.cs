using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace FactoryMethod
{
	public class Starport : Factory
	{
		public override Unit CreateUnit(string type)
		{
			Debug.Log(name + ": " + type + " creation...");
			GameObject go = new GameObject(type);
			Unit unit = null;

			if(type == "Wraith")
			{
				unit = go.AddComponent<Wraith>();
			}
			else if(type == "Dropship")
			{
				unit = go.AddComponent<Dropship>();
			}
			else if(type == "Battlecruiser")
			{
				unit = go.AddComponent<Battlecruiser>();
			}

			Debug.Log(name + ": " + type + " creation completed.");

			return unit;
		}
	}
}
