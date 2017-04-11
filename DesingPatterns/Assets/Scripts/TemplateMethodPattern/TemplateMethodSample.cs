using UnityEngine;
using System.Collections;

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
		}
	} 
}
