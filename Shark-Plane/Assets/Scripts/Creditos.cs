using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {

	// Use this for initialization
	private int i=0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		i++;
		if ((i % 3) == 0) 
		{
			GameObject.Find("TITULO").transform.Translate(new Vector3(0,0.2f,0));
			GameObject.Find("titulos").transform.Translate(new Vector3(0,0.2f,0));
			GameObject.Find("NombresCred").transform.Translate(new Vector3(0,0.2f,0));
		}
		if (i == 40) 
		{
			i=0;
		}
	
	}
}
