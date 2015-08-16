using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Unzipper : MonoBehaviour {

	// Use this for initialization
	SerialPort Puerto = new SerialPort ("COM3", 115200);
	public string[] values = new string[3];

	void Start () 
	{
		try{
			Puerto.Open();
		}catch(System.Exception e)
		{
			values [0] = "0";
			values [1] = "0";
			values [2] = "0";
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		Puerto.ReadTimeout = 25;
		if (Puerto.IsOpen) 
		{
			try 
			{
				UnzipMessage(Puerto.ReadLine());
//				Debug.Log (values[0] + "--" + values[1] + "--" + values[2]);
			}
			catch(System.Exception)
			{
				
			}
		}
	}
	public void UnzipMessage(string value)
	{
		values = value.Split ('-');
	}
}
