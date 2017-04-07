using UnityEngine;
using System.Collections;

namespace Observer
{
	public class Firebet : MonoBehaviour
	{
		public void OnDamageNotify(int health)
		{
			Debug.Log(name + ": Attack!");
		}
	}

}