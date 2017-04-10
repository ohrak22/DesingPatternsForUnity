using UnityEngine;
using System.Collections;
namespace Command
{
	public interface Command
	{
		void Excute();
		void Cancel();
	} 
}
