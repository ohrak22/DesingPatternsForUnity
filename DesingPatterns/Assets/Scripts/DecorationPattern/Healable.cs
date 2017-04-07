using UnityEngine;
using System.Collections;
using System;

namespace Decoration
{
	public class Healable : Decorator
	{
		Decorator deco;

		public Healable(Decorator decorator)
		{
			deco = decorator;

		}
		public override string Info
		{
			get
			{
				return deco.Info + ", Healable";
			}

			set
			{
				info = value;
			}
		}
	}
}
