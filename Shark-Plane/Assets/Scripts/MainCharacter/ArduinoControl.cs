using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoControl : MonoBehaviour {

	SerialPort Puerto = new SerialPort ("COM3", 115200);
	public float Speed = 5f, HighSpeed = 5f;

	// Use this for initialization
	void Start () {
		Puerto.Open();
	}
	
	// Update is called once per frame
	void Update () {
		Puerto.ReadTimeout = 25;
		if (Puerto.IsOpen) 
		{
			transform.Translate(Vector3.right * Speed * Time.deltaTime);
			try 
			{
				Debug.Log( Puerto.ReadLine() );
				SpeedChanger();
				HighChanger( Puerto.ReadByte() );
			}
			catch(System.Exception)
			{

			}
		}
	}
	public void SpeedChanger()
	{
		int Temp = Puerto.ReadByte ();
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
