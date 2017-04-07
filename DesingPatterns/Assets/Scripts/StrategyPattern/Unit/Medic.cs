using UnityEngine;
using System.Collections;

public class Medic : Unit
{
	void Awake()
	{
		attackBehaviour = new Heel();
		moveBehaviour = new Move();
	}
}
