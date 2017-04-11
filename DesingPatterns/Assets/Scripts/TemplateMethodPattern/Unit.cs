using UnityEngine;
using System.Collections;
using System;

namespace TemplateMethod
{
	public abstract class Unit : IComparable<Unit>
	{
		public int type = 0;

		public abstract void EquipWeapon();
		public abstract void Attack();

		public void EquipArmor()
		{
			Debug.Log("Equip armor");
		}
		public void Move()
		{
			Debug.Log("Move");
		}

		public int CompareTo(Unit unit)
		{
			if(this.type < unit.type)
			{
				return -1;
			}
			else if(this.type == unit.type)
			{
				return 0;
			}
			else
			{
				return 1;
			}
		}
	}

	public class Marine : Unit
	{
		public Marine()
		{
			type = 1;
		}

		public override void EquipWeapon()
		{
			Debug.Log("Equip rifle");
		}
		public override void Attack()
		{
			Debug.Log("Shoot!");
		}
	}

	public class Firebat : Unit
	{
		public Firebat()
		{
			type = 2;
		}

		public override void EquipWeapon()
		{
			Debug.Log("Equip flamethrower");
		}
		public override void Attack()
		{
			Debug.Log("Fire!");
		}
	}


}