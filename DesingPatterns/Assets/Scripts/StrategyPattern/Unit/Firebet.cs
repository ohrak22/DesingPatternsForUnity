using UnityEngine;
using System.Collections;

public class Firebet : Unit
{
	void Awake()
	{
		attackBehaviour = new Fire();
		moveBehaviour = new Move();
	}
}
