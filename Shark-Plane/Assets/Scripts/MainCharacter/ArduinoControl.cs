using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoControl : MonoBehaviour {


	private float Speed = 5f, HighSpeed = 5f;
	public Unzipper unzip = new Unzipper ();

	// Use this for initialization
	void Start () 
	{

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
		if (Temp == "3") {
			Speed = AtributosGenerales.Speed + AtributosGenerales.Aumento;
		} else if (Temp == "1") {
			Speed = AtributosGenerales.Speed - AtributosGenerales.Aumento;
		} else {
			Speed = AtributosGenerales.Speed;
		}
	}

	public void HighChanger(string Parametro)
	{
		if (Parametro == "6") 
		{
			transform.Translate (Vector3.up * AtributosGenerales.HighSpeed * Time.deltaTime);
		} else if (Parametro == "4") 
		{
			transform.Translate(Vector3.down * AtributosGenerales.HighSpeed * Time.deltaTime);
		}
	}




}
