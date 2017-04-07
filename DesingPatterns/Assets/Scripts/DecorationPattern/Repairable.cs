using UnityEngine;
using System.Collections;
using System;

namespace Decoration
{
	public class Repairable : Decorator
	{
		Decorator deco;

		public Repairable(Decorator decorator)
		{
			deco = decorator;
		}

		public override string Info
		{
			get
			{
				return deco.Info + ", Repairable";
			}

			set
			{
				info = value;
			}
		}
	}
}
