using UnityEngine;
using System.Collections;

namespace MVC
{
	public class MVCSample : MonoBehaviour
	{
		void Start()
		{
			GameObject uiObj = new GameObject("UI");
			GameObject nexusObj = new GameObject("Nexus");

			UIView uiView = uiObj.AddComponent<UIView>();
			NexusView nexus = nexusObj.AddComponent<NexusView>();

			nexus.OnSelectButtonClick();
			nexus.OnCreateProbButtonClick();
		}
	} 
}
