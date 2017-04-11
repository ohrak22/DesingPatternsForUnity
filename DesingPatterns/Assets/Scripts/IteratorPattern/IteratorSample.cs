using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
	public class IteratorSample : MonoBehaviour
	{
		void Start()
		{
			List<ZergUnit> zergList = new List<ZergUnit>();
			TerranUnit[] terranArr = new TerranUnit[3];
			zergList.Add(new ZergUnit());
			zergList.Add(new ZergUnit());
			zergList.Add(new ZergUnit());
			terranArr[0] = new TerranUnit();
			terranArr[1] = new TerranUnit();
			terranArr[2] = new TerranUnit();

			IEnumerator zergIterator = zergList.GetEnumerator();
			PrintInfo(zergIterator);
			IEnumerator terranIterator = terranArr.GetEnumerator();
			PrintInfo(terranIterator);
		}

		private void PrintInfo(IEnumerator iterator)
		{
			while(iterator.MoveNext())
			{
				Unit unit = (Unit)iterator.Current;
				Debug.Log(unit.Info);

			}
		}
	}

	public class Unit
	{
		public string Info
		{
			get
			{
				return GetType().Name;
			}
		}
	}

	public class ZergUnit : Unit
	{
	}

	public class TerranUnit : Unit
	{
	}
}
