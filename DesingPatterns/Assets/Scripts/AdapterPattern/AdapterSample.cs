using UnityEngine;
using System.Collections;

namespace Adapter
{
	public class AdapterSample : MonoBehaviour
	{
		void Start()
		{
			Army army = new Army();
			Army cyborg = new ArmyAdapter(new Cyborg());

			army.Voice();
			cyborg.Voice();
		}
	} 
}
