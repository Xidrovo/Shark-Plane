using UnityEngine;
using System.Collections;

public class ColliderController : MonoBehaviour {

	public static bool RegularSpeedL = false;

	void OnTriggerEnter2D(Collider2D Trigg)
	{
		if (Trigg.gameObject.tag == "Player") {
			RegularSpeedL = true;
		}
	}

	void OnTriggerExit2D(Collider2D Trigg)
	{
		if (Trigg.tag == "Player") {
			RegularSpeedL = false;
		}
	}
}
