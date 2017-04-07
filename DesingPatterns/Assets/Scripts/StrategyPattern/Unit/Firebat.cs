using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class Firebat : Unit
	{
		void Awake()
		{
			attackBehaviour = new Fire();
			moveBehaviour = new Move();
		}
	} 
}
