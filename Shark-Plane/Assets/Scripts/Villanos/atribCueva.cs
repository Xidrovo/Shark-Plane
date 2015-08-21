using UnityEngine;
using System.Collections;

public class atribCueva : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Physics2D.IgnoreLayerCollision (9, 9, true);
		Physics2D.IgnoreLayerCollision (9, 8, true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
