using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace MVC
{
	
	public class ProbModel
	{
		public UnityAction<DisplayInfo> selectAction;
		public UnityAction<DisplayInfo> changeStatusAction;

		private DisplayInfo info = new DisplayInfo();
		private bool selected = false;

		public ProbModel()
		{
			info.name = "Prob";
			info.state = "Idle";
		}

		public void Select()
		{
			selected = true;
			if(selectAction != null)
				selectAction(info);
		}
		public void Move()
		{
			info.state = "Moving";
			if(changeStatusAction != null)
				changeStatusAction(info);
		}
		public void Stop()
		{
			info.state = "Stop";
			if(changeStatusAction != null)
				changeStatusAction(info);
		}
	} 
}
