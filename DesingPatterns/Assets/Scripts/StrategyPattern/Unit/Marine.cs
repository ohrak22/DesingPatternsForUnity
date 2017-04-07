using UnityEngine;
using System.Collections;

public class Marine : Unit
{
	void Awake()
	{
		attackBehaviour = new Fire();
		moveBehaviour = new Move();
	}
}
