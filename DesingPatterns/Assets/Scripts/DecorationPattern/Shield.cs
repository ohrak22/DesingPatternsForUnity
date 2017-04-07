using UnityEngine;
using System.Collections;
using System;

namespace Decoration
{
	public class Shield : Decorator
	{
		public int SP = 100;

		Decorator deco;

		public Shield(Decorator decorator)
		{
			deco = decorator;
		}

		public override string Info
		{
			get
			{
				return deco.Info + ", Shield:" + SP;
			}

			set
			{
				info = value;
			}
		}
	}
}
