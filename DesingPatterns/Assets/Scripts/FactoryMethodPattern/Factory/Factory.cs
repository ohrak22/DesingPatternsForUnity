using UnityEngine;
using System.Collections;

namespace FactoryMethod
{
	public abstract class Factory : MonoBehaviour
	{
		public abstract Unit CreateUnit(string type);
	} 
}
