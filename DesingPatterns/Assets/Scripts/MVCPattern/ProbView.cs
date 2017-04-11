using UnityEngine;
using System.Collections;

namespace MVC
{
	public class ProbView : MonoBehaviour
	{
		public void OnSelect()
		{
			Controller.Instance.SelectProb();
		}

		public void OnMove()
		{
			Controller.Instance.MoveProb();
		}

		public void OnStop()
		{
			Controller.Instance.StopProb();
		}
	} 
}
