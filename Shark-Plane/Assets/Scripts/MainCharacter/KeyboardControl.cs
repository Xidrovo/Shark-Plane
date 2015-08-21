using UnityEngine;
using System.Collections;

public class KeyboardControl : MonoBehaviour {
	
	private float Speed = AtributosGenerales.Speed;
	private bool LimitR = false;
	private bool LimitUp = false;
	private bool LimitDown = false;


	void OnTriggerEnter2D(Collider2D Trigg)
	{
		if (Trigg.tag == "Limit") 
		{
			LimitR = true;
		}

		if (Trigg.tag == "LimitUp")
		{
			LimitUp = true;
		}

		if (Trigg.tag == "LimitDown") 
		{
			LimitDown = true;
		}
	}

	void OnTriggerExit2D (Collider2D Trigg)
	{
		if (Trigg.tag == "Limit") 
		{
			LimitR = false;
		}

		if (Trigg.tag == "LimitUp")
		{
			LimitUp = false;
		}
		
		if (Trigg.tag == "LimitDown") 
		{
			LimitDown = false;
		}
	}
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
			if (Input.GetKey (KeyCode.RightArrow) && LimitR == false) 
			{
				Speed = AtributosGenerales.Speed + AtributosGenerales.Aumento;
			} 
			else if (Input.GetKey (KeyCode.LeftArrow) && ColliderController.RegularSpeedL == false) 
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
		if (Input.GetKey (KeyCode.UpArrow) && LimitUp == false) 
		{
			transform.Translate (Vector3.up * AtributosGenerales.HighSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow) && LimitDown == false) 
		{
			transform.Translate (Vector3.down * AtributosGenerales.HighSpeed * Time.deltaTime);
		}
	}
}
