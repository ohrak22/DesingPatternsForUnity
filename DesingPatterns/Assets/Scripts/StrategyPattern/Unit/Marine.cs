using UnityEngine;
using System.Collections;

namespace Strategy
{
	public class Marine : Unit
	{
		void Awake()
		{
			attackBehaviour = new Fire();
			moveBehaviour = new Move();
		}
	} 
}
