using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoControl : MonoBehaviour {


	public float Speed = 5f, HighSpeed = 5f;
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
	}
	public void SpeedChanger(int Temp)
	{
		if (Temp == 3) {
			Speed = 8f;
		} else if (Temp == 1) {
			Speed = 3f;
		} else {
			Speed = 5f;
		}
	}

	public void HighChanger(int Parametro)
	{
		if (Parametro == 6) 
		{
			transform.Translate (Vector3.up * HighSpeed * Time.deltaTime);
		} else if (Parametro == 4) 
		{
			transform.Translate(Vector3.down * HighSpeed * Time.deltaTime);
		}
	}




}
