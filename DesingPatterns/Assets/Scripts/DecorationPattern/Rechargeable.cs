using UnityEngine;
using System.Collections;
using System;

namespace Decoration
{
	public class Rechargeable : Decorator
	{
		Decorator deco;

		public Rechargeable(Decorator decorator)
		{
			deco = decorator;

		}
		public override string Info
		{
			get
			{
				return deco.Info + ", Rechargeable";
			}

			set
			{
				info = value;
			}
		}
	}
}
