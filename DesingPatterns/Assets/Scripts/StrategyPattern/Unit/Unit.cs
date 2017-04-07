using UnityEngine;
using System.Collections;
using System;

namespace Strategy
{
	public class Unit : MonoBehaviour
	{
		protected IAttack attackBehaviour;
		protected IMove moveBehaviour;

		public void Attack()
		{
			attackBehaviour.Attack();
		}

		public void Move()
		{
			moveBehaviour.Move();
		}
	} 
}
