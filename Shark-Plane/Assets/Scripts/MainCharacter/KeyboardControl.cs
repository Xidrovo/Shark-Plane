using UnityEngine;
using System.Collections;

public class KeyboardControl : MonoBehaviour {

	public float Speed = 5f, HighSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		HighAndLow ();
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
	}

	public void HighAndLow()
	{
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.Translate (Vector3.up * HighSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.Translate (Vector3.down * HighSpeed * Time.deltaTime);
		}
	}
}
