using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class Heal : IAttack
	{
		public void Attack()
		{
			Debug.Log("Heal~");
		}
	} 
}
