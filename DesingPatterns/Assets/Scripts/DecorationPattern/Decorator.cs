using UnityEngine;
using System.Collections;

namespace Decoration
{
	public abstract class Decorator
	{
		public string info;
		public abstract string Info { get; set; }
	}
}
