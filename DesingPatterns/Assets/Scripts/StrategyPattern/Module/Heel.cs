using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class Heel : IAttack
	{
		public void Attack()
		{
			Debug.Log("Heel~");
		}
	} 
}
