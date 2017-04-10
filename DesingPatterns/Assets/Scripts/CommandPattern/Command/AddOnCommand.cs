using UnityEngine;
using System.Collections;
using System;

namespace Command
{
	public class AddOnCommand : Command
	{
		private AddOn addOn;

		public AddOnCommand(AddOn addOn)
		{
			this.addOn = addOn;
		}

		public void Excute()
		{
			addOn.Create();
		}

		public void Cancel()
		{
			addOn.Cancel();
		}
	}
}
