using UnityEngine;
using System.Collections;

namespace FactoryMethod
{
	public class Unit : MonoBehaviour
	{
		void Awake()
		{
			Debug.Log("I'm " + name);
		}
	} 
}
