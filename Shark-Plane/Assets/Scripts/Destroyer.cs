using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D Coll)
	{
    		Destroy (Coll.gameObject);
	}
}
