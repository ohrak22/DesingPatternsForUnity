using UnityEngine;
using System.Collections;

namespace FactoryMethod
{
	public abstract class Building : MonoBehaviour
	{
		public abstract Unit CreateUnit(string type);
	} 
}
