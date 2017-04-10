using UnityEngine;
using System.Collections;

namespace Singleton
{
	public class SingletonSample : MonoBehaviour
	{

		void Start()
		{
			Debug.Log(MySingleton.Instance.name);
			Debug.Log(Singleton.Instance.GetType().Name);
		}

	} 
}
