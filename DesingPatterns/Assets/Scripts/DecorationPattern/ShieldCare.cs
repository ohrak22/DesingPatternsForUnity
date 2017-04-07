using UnityEngine;
using System.Collections;
using System;

namespace Decoration
{
	public class ShieldCare : Decorator
	{
		Decorator deco;

		public ShieldCare(Decorator decorator)
		{
			deco = decorator;
		}

		public override string Info
		{
			get
			{
				return deco.Info + ", Shield care 1/sec";
			}

			set
			{
				info = value;
			}
		}
	}
}
