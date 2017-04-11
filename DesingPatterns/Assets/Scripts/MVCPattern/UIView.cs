using UnityEngine;
using System;
using System.Collections;

namespace MVC
{
	public class DisplayInfo
	{
		public string name = "";
		public string state = "";
	}

	public class UIView : MonoBehaviour
	{
		DisplayInfo info = new DisplayInfo();

		void Awake()
		{
			Controller.Instance.NexusModel.selectAction = OnSelectNexus;
			Controller.Instance.ProbModel.selectAction = OnSelectProb;

			Controller.Instance.NexusModel.changeStatusAction = OnChangeStateNexus;
			Controller.Instance.ProbModel.changeStatusAction = OnChangeStateProb;
		}

		public void OnChangeStateProb(DisplayInfo info)
		{
			this.info = info;
			Display();
		}

		public void OnChangeStateNexus(DisplayInfo info)
		{
			this.info = info;
			Display();
		}

		public void OnSelectProb(DisplayInfo info)
		{
			this.info = info;
			Display();
		}

		public void OnSelectNexus(DisplayInfo info)
		{
			this.info = info;
			Display();
		}



		private void Display()
		{
			Debug.Log(info.name + ": " + info.state);
		}
	} 
}
