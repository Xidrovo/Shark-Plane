using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoControl : MonoBehaviour {


	private float Speed = 5f, HighSpeed = 5f;
	public Unzipper unzip = new Unzipper ();

	private bool LimitRight = false, LimitLeft = false, LimitUp = false, LimitDown = false;

	void OnTriggerEnter2D(Collider2D Trigg)
	{
		if (Trigg.tag == "Limit") 
		{
			LimitRight = true;
		}
		
		if (Trigg.tag == "LimitUp")
		{
			LimitUp = true;
		}
		
		if (Trigg.tag == "LimitDown") 
		{
			LimitDown = true;
		}

		if (Trigg.tag == "LimitLeft")
		{
			LimitLeft = true;
		}
	}

	void OnTriggerExit2D (Collider2D Trigg)
	{
		if (Trigg.tag == "Limit") 
		{
			LimitRight = false;
		}
		
		if (Trigg.tag == "LimitUp")
		{
			LimitUp = false;
		}
		
		if (Trigg.tag == "LimitDown") 
		{
			LimitDown = false;
		}
		
		if (Trigg.tag == "LimitLeft")
		{
			LimitLeft = false;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		SpeedChanger( unzip.values[0]);
		HighChanger( unzip.values[2] );
		transform.Translate (Vector3.right * Speed * Time.deltaTime);
	}
	public void SpeedChanger(string Temp)
	{
		if (Temp == "3" && LimitRight == false) {
			Speed = AtributosGenerales.Speed + AtributosGenerales.Aumento;
		} else if (Temp == "1" && LimitLeft == false) {
			Speed = AtributosGenerales.Speed - AtributosGenerales.Aumento;
		} else {
			Speed = AtributosGenerales.Speed;
		}
	}

	public void HighChanger(string Parametro)
	{
		if (Parametro == "6" && LimitUp == false) 
		{
			transform.Translate (Vector3.up * AtributosGenerales.HighSpeed * Time.deltaTime);
		} else if (Parametro == "4" && LimitDown == false) 
		{
			transform.Translate(Vector3.down * AtributosGenerales.HighSpeed * Time.deltaTime);
		}
	}




}
