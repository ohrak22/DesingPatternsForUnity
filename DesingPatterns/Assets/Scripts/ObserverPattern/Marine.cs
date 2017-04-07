using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Observer
{
	public class Marine : MonoBehaviour
	{
		public UnityAction<int> DamageNotify;

		private int health = 100;

		public void GetDamage(int damage)
		{
			health -= damage;
			if(DamageNotify != null)
			{
				DamageNotify(health);
			}
		}
	} 
}
