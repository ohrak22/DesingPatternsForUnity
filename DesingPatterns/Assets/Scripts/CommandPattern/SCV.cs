using UnityEngine;
using System.Collections;

namespace Command
{
	public class SCV : Module
	{
		public void Create()
		{
			Debug.Log("SCV creating...");
		}

		public void Cancel()
		{
			Debug.Log("Cancel SCV creation!");
		}
	} 
}
