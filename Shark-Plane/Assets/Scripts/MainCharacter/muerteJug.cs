using UnityEngine;
using System.Collections;

public class muerteJug : MonoBehaviour {

	// Use this for initialization
	private int bd = 0, i = 0;
	public GameObject Resurrect;
	private bool ResDelay = false;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (bd == 1) 
		{
			bd = 0;
			this.transform.position = Resurrect.transform.position;
		}
	}


	public void Kill()
	{
		bd = 1;
	}


}
