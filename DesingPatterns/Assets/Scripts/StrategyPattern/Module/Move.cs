using UnityEngine;
using System.Collections;
using System;

public class Move : IMove
{
	void IMove.Move()
	{
		Debug.Log("Move!");
	}
}
