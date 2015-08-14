using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Unzipper : MonoBehaviour {

	// Use this for initialization
	SerialPort Puerto = new SerialPort ("COM3", 115200);
	public int[] values= new int[3];
	void Start () 
	{
		Puerto.Open();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Puerto.ReadTimeout = 25;
		if (Puerto.IsOpen) 
		{
			transform.Translate(Vector3.right * Speed * Time.deltaTime);
			try 
			{
				values=UnzipMessage(Puerto.ReadLine());

			}
			catch(System.Exception)
			{
				
			}
		}
	
	}
	public int[] UnzipMessage(string value)
	{
		values = (int)value.Split ("-");
		
	}
}
