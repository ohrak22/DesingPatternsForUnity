using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;

namespace MVC
{
	public class NexusModel
	{
		public UnityAction<DisplayInfo> selectAction;
		public UnityAction<DisplayInfo> changeStatusAction;

		private DisplayInfo info = new DisplayInfo();
		private bool selected = false;

		public object Current
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public NexusModel()
		{
			info.name = "Nexus";
			info.state = "Wait";
		}

		public void Select()
		{
			selected = true;
			if(selectAction != null)
				selectAction(info);
		}
		public void CreateProb()
		{
			IEnumerator iterator = Process();
			while(iterator.MoveNext())
			{
			}
		}
		IEnumerator Process()
		{
			for(int i = 0; i < 100; i += 10)
			{
				info.state = "Creating(" + i + "%)";
				if(changeStatusAction != null)
					changeStatusAction(info);

				yield return new WaitForSeconds(0.5f);
			}

			info.state = "Creating complete";
			if(changeStatusAction != null)
				changeStatusAction(info);

			GameObject go = new GameObject("Prob");
			ProbView prob = go.AddComponent<ProbView>();

			prob.OnSelect();
			prob.OnMove();
			prob.OnStop();
		}

	} 
}
