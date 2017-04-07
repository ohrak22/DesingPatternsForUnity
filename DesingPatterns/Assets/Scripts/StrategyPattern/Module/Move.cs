using UnityEngine;
using System.Collections;
using System;

namespace Strategy
{
	public class Move : IMove
	{
		void IMove.Move()
		{
			Debug.Log("Move!");
		}
	} 
}
