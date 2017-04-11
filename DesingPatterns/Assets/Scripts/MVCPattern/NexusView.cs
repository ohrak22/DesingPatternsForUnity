using UnityEngine;
using System.Collections;

namespace MVC
{
	public class NexusView : MonoBehaviour
	{
		public void OnSelectButtonClick()
		{
			Controller.Instance.SelectNexus();
		}

		public void OnCreateProbButtonClick()
		{
			Controller.Instance.CreateProb();
		}
	} 
}
