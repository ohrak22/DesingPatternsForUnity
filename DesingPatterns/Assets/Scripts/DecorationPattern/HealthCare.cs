using UnityEngine;
using System.Collections;
using System;

namespace Decoration
{
	public class HealthCare : Decorator
	{
		Decorator deco;

		public HealthCare(Decorator decorator)
		{
			deco = decorator;
		}

		public override string Info
		{
			get
			{
				return deco.Info + ", Health care 1/sec";
			}

			set
			{
				info = value;
			}
		}
	}
}
