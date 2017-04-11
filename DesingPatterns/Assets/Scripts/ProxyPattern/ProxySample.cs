using UnityEngine;
using System.Collections;

namespace Proxy
{
	public class ProxySample : MonoBehaviour
	{
		void Start()
		{
			Unit realUnit1 = new Unit("Unit1");
			Unit realUnit2 = new Unit("Unit2");
			Unit realUnit3 = new Unit("Unit3");

			realUnit1.Stop();
			realUnit2.Attack();
			realUnit3.Move();

			UnitProxy unitProxy1 = new UnitProxy(realUnit1);
			UnitProxy unitProxy2 = new UnitProxy(realUnit2);
			UnitProxy unitProxy3 = new UnitProxy(realUnit3);

			Debug.Log(unitProxy1.GetName());
			Debug.Log(unitProxy1.GetCurrentState());

			Debug.Log(unitProxy2.GetName());
			Debug.Log(unitProxy2.GetCurrentState());

			Debug.Log(unitProxy3.GetName());
			Debug.Log(unitProxy3.GetCurrentState());
		}

	}

	public interface UnitData
	{
		string GetName();
		State GetCurrentState();
	}

	public class UnitProxy : UnitData
	{
		Unit unit = null;

		public UnitProxy(Unit unit)
		{
			this.unit = unit;
		}

		public State GetCurrentState()
		{
			return unit.State;
		}

		public string GetName()
		{
			return unit.Name;
		}
	}

	public interface State
	{
		void Print();
	}

	public class IdleState : State
	{
		public void Print()
		{
		}
	}
	public class AttackState : State
	{
		public void Print()
		{
		}
	}
	public class MoveState : State
	{
		public void Print()
		{
		}
	}
	public class UnderAttackState : State
	{
		public void Print()
		{
		}
	}

	public class Unit
	{
		private State Idle = new IdleState();
		private State AttackState = new AttackState();
		private State MoveState = new MoveState();
		private State UnderAttackState = new UnderAttackState();
		public State State { get; set; }
		public string Name { get; set; }
		public Unit(string name)
		{
			State = Idle;
			Name = name;
		}

		public void Stop()
		{
			State = Idle;
			State.Print();
		}
		public void Attack()
		{
			State = AttackState;
			State.Print();
		}
		public void Move()
		{
			State = MoveState;
			State.Print();
		}
		public void UnderAttack()
		{
			State = UnderAttackState;
			State.Print();
			State = AttackState;
			State.Print();
		}
	}
}
