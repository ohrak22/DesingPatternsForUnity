using UnityEngine;
using System.Collections;
using System;

namespace State
{
	public interface State
	{
		void Print();			 
	}

	public class IdleState : State
	{
		public void Print()
		{
			Debug.Log(GetType().Name);
		}
	}
	public class AttackState : State
	{
		public void Print()
		{
			Debug.Log(GetType().Name);
		}
	}
	public class MoveState : State
	{
		public void Print()
		{
			Debug.Log(GetType().Name);
		}
	}
	public class UnderAttackState : State
	{
		public void Print()
		{
			Debug.Log(GetType().Name);
		}
	}

	public class Unit
	{
		private State Idle = new IdleState();
		private State AttackState = new AttackState();
		private State MoveState = new MoveState();
		private State UnderAttackState = new UnderAttackState();
		public State state { get; set; }
		public Unit()
		{
			state = Idle;
		}

		public void Stop()
		{
			state = Idle;
			state.Print();
		}
		public void Attack()
		{
			state = AttackState;
			state.Print();
		}
		public void Move()
		{
			state = MoveState;
			state.Print();
		}
		public void UnderAttack()
		{
			state = UnderAttackState;
			state.Print();
			state = AttackState;
			state.Print();
		}
	} 
}
