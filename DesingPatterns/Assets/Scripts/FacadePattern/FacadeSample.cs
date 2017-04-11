namespace Facade
{
	using UnityEngine;
	using System.Collections;

	public class FacadeSample : MonoBehaviour
	{
		void Start()
		{
			GameObject go = new GameObject("Factory");
			Factory factory = go.AddComponent<Factory>();
			factory.CreateTank();
		}

	}

}