using UnityEngine;
using System.Collections;

namespace Singleton
{
	// Component type.
	public class MySingleton : MonoBehaviour
	{
		private static MySingleton instance;

		public static MySingleton Instance
		{
			get
			{
				if(instance == null)
				{
					GameObject go = new GameObject("MySingleton");
					instance = go.AddComponent<MySingleton>();
					DontDestroyOnLoad(go);
				}
				return instance;
			}
		}
	}

	// Non component type.
	public class Singleton
	{
		private static Singleton instance;

		public static Singleton Instance
		{
			get
			{
				if(instance == null)
				{
					instance = new Singleton();
				}
				return instance;
			}
		}
	}
}
