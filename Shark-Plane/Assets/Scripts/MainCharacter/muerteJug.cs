using UnityEngine;
using System.Collections;

public class muerteJug : MonoBehaviour {

	// Use this for initialization
	private int bd=0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (bd == 1) 
		{
			this.gameObject.SetActive(false);
			bd=0;
		}
		for (int i=0; i<10; i++) 
		{
			if((i+1)==10)
			{
				this.gameObject.SetActive(true);
			}
		}
	
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (!col.gameObject.CompareTag ("Bala") ) 
		{
			bd=1;
			//bajar vida

		}
		
	}


}
