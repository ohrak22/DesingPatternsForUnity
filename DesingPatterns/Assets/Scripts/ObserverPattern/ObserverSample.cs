using UnityEngine;
using System.Collections;

namespace Observer
{
	public class ObserverSample : MonoBehaviour
	{
		void Start()
		{
			GameObject maringObj = new GameObject("Marine");
			GameObject medicObj = new GameObject("Medic");
			GameObject FirebatObj = new GameObject("Firebat");
			GameObject warningObj = new GameObject("WarningSystem");
			GameObject healthBarObj = new GameObject("HealthBar");

			Marine marine = maringObj.AddComponent<Marine>();
			Medic medic = medicObj.AddComponent<Medic>();
			Firebat Firebat = FirebatObj.AddComponent<Firebat>();
			WarningSystem warning = warningObj.AddComponent<WarningSystem>();
			HealthBar healthBar = healthBarObj.AddComponent<HealthBar>();

			marine.DamageNotify += medic.OnDamageNotify;
			marine.DamageNotify += Firebat.OnDamageNotify;
			marine.DamageNotify += warning.OnDamageNotify;
			marine.DamageNotify += healthBar.OnDamageNotify;

			marine.GetDamage(10);
			marine.GetDamage(10);

			marine.DamageNotify -= medic.OnDamageNotify;
			marine.DamageNotify -= Firebat.OnDamageNotify;
			marine.DamageNotify -= warning.OnDamageNotify;
			marine.DamageNotify -= healthBar.OnDamageNotify;
		}
	}
}
