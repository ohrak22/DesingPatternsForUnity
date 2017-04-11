using UnityEngine;
using System.Collections;

namespace TemplateMethod
{
	public abstract class Unit
	{
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

	}

	public class Marine : Unit
	{
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