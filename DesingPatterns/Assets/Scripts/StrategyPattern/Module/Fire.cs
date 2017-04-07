using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class Fire : IAttack
	{
		public void Attack()
		{
			Debug.Log("Fire!");
		}
	} 
}
