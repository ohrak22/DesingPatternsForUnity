using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace TemplateMethod
{
	public class TemplateMethodSample : MonoBehaviour
	{
		void Start()
		{
			Unit marine = new Marine();
			Unit firebat = new Firebat();

			marine.EquipWeapon();
			marine.EquipArmor();
			marine.Attack();
			marine.Move();

			firebat.EquipWeapon();
			firebat.EquipArmor();
			firebat.Attack();
			firebat.Move();

			List<Unit> list = new List<Unit>();
			list.Add(firebat);
			list.Add(marine);
			list.Add(firebat);
			list.Add(marine);
			list.Add(firebat);
			list.Add(marine);

			list.Sort();

			for(int i = 0; i < list.Count; i++)
			{
				Debug.Log(list[i].GetType().Name + ": " + list[i].type);
			}

		}
	} 
}
