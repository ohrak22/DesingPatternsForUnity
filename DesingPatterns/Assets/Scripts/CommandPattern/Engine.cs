using UnityEngine;
using System.Collections;

namespace Command
{
	public class Engine : Module
	{
		public void Floating()
		{
			Debug.Log("Floating...");
		}

		public void Landing()
		{
			Debug.Log("Landing...");
		}

		public void CancelFloating()
		{
			Debug.Log("Cancel Floating!");
		}
		public void CancelLanding()
		{
			Debug.Log("Cancel Landing!");
		}
	} 
}
