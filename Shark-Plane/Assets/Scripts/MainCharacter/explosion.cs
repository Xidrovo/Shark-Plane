using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnColisionrEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag ("Enemy")) 
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
