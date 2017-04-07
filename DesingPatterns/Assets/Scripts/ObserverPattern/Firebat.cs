using UnityEngine;
using System.Collections;

namespace Observer
{
	public class Firebat : MonoBehaviour
	{
		public void OnDamageNotify(int health)
		{
			Debug.Log(name + ": Attack!");
		}
	}

}