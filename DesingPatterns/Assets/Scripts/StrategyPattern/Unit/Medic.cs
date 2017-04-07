using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class Medic : Unit
	{
		void Awake()
		{
			attackBehaviour = new Heel();
			moveBehaviour = new Move();
		}
	} 
}
