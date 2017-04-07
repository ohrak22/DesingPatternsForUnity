using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class Firebet : Unit
	{
		void Awake()
		{
			attackBehaviour = new Fire();
			moveBehaviour = new Move();
		}
	} 
}
