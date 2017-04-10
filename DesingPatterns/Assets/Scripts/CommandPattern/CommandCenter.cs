using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Command
{
	public class CommandCenter : MonoBehaviour
	{
		Command scvCommand;
		Command addOnCommand;
		Command floatingCommand;
		Command landingCommand;
		Command cancelCommand;

		public void SetSCVCommand(Command command)
		{
			scvCommand = command;
		}
		public void SetAddOnCommand(Command command)
		{
			addOnCommand = command;
		}
		public void SetFloatingCommand(Command command)
		{
			floatingCommand = command;
		}
		public void SetLandingCommand(Command command)
		{
			landingCommand = command;
		}
		public void OnCreateSCVButtonClick()
		{
			scvCommand.Excute();
			cancelCommand = scvCommand;
		}
		public void OnAddOnScanButtonClick()
		{
			addOnCommand.Excute();
			cancelCommand = addOnCommand;
		}
		public void OnFloatingButtonClick()
		{
			floatingCommand.Excute();
			cancelCommand = floatingCommand;
		}
		public void OnLandingButtonClick()
		{
			landingCommand.Excute();
			cancelCommand = landingCommand;
		}
		public void OnCancelButtonClick()
		{
			cancelCommand.Cancel();
		}
		public void LandingFail()
		{
			Debug.Log("Landing fail!!!");
			cancelCommand.Cancel();
		}
	} 
}
