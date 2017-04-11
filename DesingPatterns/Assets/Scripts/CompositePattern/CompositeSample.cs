using UnityEngine;
using System.Collections;

namespace Composite
{
	public class CompositeSample : MonoBehaviour
	{
		void Start()
		{
			GameObject unit = new GameObject("Unit");
			AttackComponent attack = unit.AddComponent<AttackComponent>();
			MoveComponent move = unit.AddComponent<MoveComponent>();

			attack.Attack();
			move.Move();
		}
	} 
}
