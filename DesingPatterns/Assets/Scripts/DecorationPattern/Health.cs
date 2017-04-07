using UnityEngine;
using System.Collections;
using System;

namespace Decoration
{
	public class Health : Decorator
	{
		public int HP = 100;

		public override string Info
		{
			get
			{
				return "HP:" + HP;
			}

			set
			{
				info = value;
			}
		}
	}
}
