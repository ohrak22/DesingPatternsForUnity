using UnityEngine;
using System.Collections;

namespace Command
{
	public class CommandSample : MonoBehaviour
	{
		void Start()
		{
			GameObject go = new GameObject("CommandCenter");
			CommandCenter commandCenter = go.AddComponent<CommandCenter>();

			Engine engine = new Engine();
			FloatingCommand floating = new FloatingCommand(engine);
			LandingCommand landing = new LandingCommand(engine);
			commandCenter.SetFloatingCommand(floating);
			commandCenter.SetLandingCommand(landing);

			SCV scv = new SCV();
			CreateSCVCommand createUnit = new CreateSCVCommand(scv);
			commandCenter.SetSCVCommand(createUnit);

			AddOn scan = new AddOn();
			AddOnCommand addOn = new AddOnCommand(scan);
			commandCenter.SetAddOnCommand(addOn);

			commandCenter.OnFloatingButtonClick();
			commandCenter.OnLandingButtonClick();
			commandCenter.LandingFail();
			commandCenter.OnLandingButtonClick();

			commandCenter.OnCreateSCVButtonClick();
			commandCenter.OnCreateSCVButtonClick();
			commandCenter.OnCreateSCVButtonClick();
			commandCenter.OnCancelButtonClick();
			commandCenter.OnCancelButtonClick();
			commandCenter.OnCancelButtonClick();

			commandCenter.OnAddOnScanButtonClick();
			commandCenter.OnCancelButtonClick();

		}
	} 
}
