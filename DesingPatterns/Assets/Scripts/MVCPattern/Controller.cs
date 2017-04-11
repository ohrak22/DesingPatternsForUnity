using UnityEngine;
using System.Collections;

namespace MVC
{
	public class Controller
	{
		private static Controller instance = null;

		public static Controller Instance
		{
			get
			{
				if(instance == null)
				{
					instance = new Controller();
				}
				return instance;
			}
		}

		private NexusModel nexusModel = new NexusModel();
		private ProbModel probModel = new ProbModel();

		public NexusModel NexusModel
		{
			get { return nexusModel; }
		}
		public ProbModel ProbModel
		{
			get { return probModel; }
		}

		public void SelectNexus()
		{
			nexusModel.Select();
		}

		public void CreateProb()
		{
			nexusModel.CreateProb();
		}

		public void SelectProb()
		{
			probModel.Select();
		}

		public void MoveProb()
		{
			probModel.Move();
		}

		public void StopProb()
		{
			probModel.Stop();
		}
	} 
}
