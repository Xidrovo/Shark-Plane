using UnityEngine;
using System.Collections;

public class KeyboardControl : MonoBehaviour {

	public float Speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		transform.Translate (Vector3.right * Speed * Time.deltaTime);

	}

	public void Movement()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			Speed = 8f;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			Speed = 3f;
		} else {
			Speed = 5f;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			PewPew a= new PewPew();
			a.CrearBala();
		}
	}
}
