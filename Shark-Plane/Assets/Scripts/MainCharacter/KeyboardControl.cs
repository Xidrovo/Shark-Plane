using UnityEngine;
using System.Collections;

public class KeyboardControl : MonoBehaviour {
	
	private float Speed = AtributosGenerales.Speed;
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
			if (Input.GetKey (KeyCode.RightArrow)) 
			{
				Speed = AtributosGenerales.Speed + AtributosGenerales.Aumento;
			} 
			else if (Input.GetKey (KeyCode.LeftArrow) && ColliderController.RegularSpeed == false) 
			{
				Speed = AtributosGenerales.Speed - AtributosGenerales.Aumento;
			} 
			else 
			{
				Speed = AtributosGenerales.Speed;
			}
	}

	public void HighAndLow()
	{
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.Translate (Vector3.up * AtributosGenerales.HighSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.Translate (Vector3.down * AtributosGenerales.HighSpeed * Time.deltaTime);
		}
	}
}
