using UnityEngine;
using System.Collections;
using System;

namespace Command
{
	public class FloatingCommand : Command
	{
		Engine engine;

		public FloatingCommand(Engine engine)
		{
			this.engine = engine;
		}

		public void Excute()
		{
			engine.Floating();
		}
		public void Cancel()
		{
			engine.CancelFloating();
		}
	}
}
