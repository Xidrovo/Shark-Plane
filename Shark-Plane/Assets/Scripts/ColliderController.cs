using UnityEngine;
using System.Collections;

public class ColliderController : MonoBehaviour {

	public static bool RegularSpeed = false;

	void OnTriggerEnter2D(Collider2D Trigg)
	{
		if (Trigg.gameObject.name == "Tiburion") {
			RegularSpeed = true;
		}
	}

	void OnTriggerExit2D(Collider2D Trigg)
	{
		if (Trigg.name == "Tiburion") {
			RegularSpeed = false;
		}
	}
}
