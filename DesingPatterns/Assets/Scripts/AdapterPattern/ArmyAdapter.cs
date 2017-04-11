using UnityEngine;
using System.Collections;

namespace Adapter
{
	public class Army
	{
		public virtual void Voice()
		{
			Debug.Log("I'm Army");
		}
		public virtual void Move()
		{
			Debug.Log("Army move");
		}
	}
	public class Cyborg
	{
		public void Speaker()
		{
			Debug.Log("I'm Cyborg");
		}
		public void Move()
		{
			Debug.Log("Cyborg move");
		}
	}
	public class ArmyAdapter : Army
	{
		Cyborg cyborg;
		public ArmyAdapter(Cyborg cyborg)
		{
			this.cyborg = cyborg;
		}
		public override	void Voice()
		{
			cyborg.Speaker();
		}
		public override void Move()
		{
			cyborg.Move();
		}
	}

}
