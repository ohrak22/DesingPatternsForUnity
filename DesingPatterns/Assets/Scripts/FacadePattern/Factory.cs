namespace Facade
{
	using UnityEngine;
	using System.Collections;

	public class Factory : MonoBehaviour
	{
		public int mineal = 200;
		public int gas = 100;
		public int enoughPeopleCount = 5;

		public void CreateTank()
		{
			if(!IsEnoughMineal())
			{
				Debug.Log("Not enough mineal!");
			}
			else if(!IsEnoughGas())
			{
				Debug.Log("Not enough gas!");
			}
			else if(!IsEnoughPeopleCount())
			{
				Debug.Log("Not enough supplies!");
			}
			else
			{
				StartCoroutine(Process());
			}
		}
		public bool IsEnoughMineal()
		{
			return mineal >= 150;
		}
		public bool IsEnoughGas()
		{
			return gas >= 100;
		}
		public bool IsEnoughPeopleCount()
		{
			return enoughPeopleCount >= 2;
		}

		IEnumerator Process()
		{
			mineal -= 150;
			gas -= 100;
			enoughPeopleCount -= 2;

			for(int i = 0; i <= 100; i += 10)
			{
				Debug.Log(i + "%");
				yield return new WaitForSeconds(0.1f);
			}

			GameObject tank = new GameObject("Tank");
			Debug.Log("Creation completed!");
		}

	}

}