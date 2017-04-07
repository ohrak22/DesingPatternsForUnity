using UnityEngine;
using System.Collections;

namespace Observer
{
	public class HealthBar : MonoBehaviour
	{
		public void OnDamageNotify(int health)
		{
			Debug.Log("HP: " + health + "/100");
		}
	} 
}
