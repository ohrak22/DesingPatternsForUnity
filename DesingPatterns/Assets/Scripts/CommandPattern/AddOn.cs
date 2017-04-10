using UnityEngine;
using System.Collections;

namespace Command
{
	public class AddOn : Module
	{
		public void Create()
		{
			Debug.Log("Installing add-on");
		}

		public void Cancel()
		{
			Debug.Log("Cancel Add-on installation");
		}
	} 
}
