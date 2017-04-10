using UnityEngine;
using System.Collections;
using System;

namespace Command
{
	public class CreateSCVCommand : Command
	{
		private SCV scv;

		public CreateSCVCommand(SCV scv)
		{
			this.scv = scv;
		}

		public void Excute()
		{
			scv.Create();
		}
		public void Cancel()
		{
			scv.Cancel();
		}
	}
}
