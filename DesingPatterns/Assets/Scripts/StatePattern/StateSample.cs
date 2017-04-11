using UnityEngine;
using System.Collections;

namespace State
{
	public class StateSample : MonoBehaviour
	{
		void Start()
		{
			Unit unit = new Unit();
			unit.Move();
			unit.Stop();
			unit.Attack();
			unit.UnderAttack();
		}
		
	} 
}
