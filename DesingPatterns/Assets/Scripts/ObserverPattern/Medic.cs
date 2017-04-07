using UnityEngine;
using System.Collections;

namespace Observer
{
	public class Medic : MonoBehaviour
	{
		public void OnDamageNotify(int health)
		{
			Debug.Log(name + ": Heal~");
		}

	} 
}
