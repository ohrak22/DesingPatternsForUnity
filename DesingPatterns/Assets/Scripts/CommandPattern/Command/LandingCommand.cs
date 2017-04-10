using UnityEngine;
using System.Collections;
using System;

namespace Command
{
	public class LandingCommand : Command
	{
		Engine engine;

		public LandingCommand(Engine engine)
		{
			this.engine = engine;
		}

		public void Excute()
		{
			engine.Landing();
		}
		public void Cancel()
		{
			engine.CancelLanding();
		}
	}
}
