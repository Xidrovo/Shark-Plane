using UnityEngine;
using System.Collections;

public class exploJuga : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag ("Player")) 
		{
			Destroy(this.gameObject);
		}
		
	}
	public void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.CompareTag("MainCamera"))
		{
			Destroy(this.gameObject);
		}
	}
}
