using UnityEngine;
using System.Collections;

namespace Observer
{
	public class WarningSystem : MonoBehaviour
	{

		public void OnDamageNotify(int health)
		{
			Debug.Log("Warning: We are under attack");
		}
	} 
}
