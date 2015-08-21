using UnityEngine;
using System.Collections;

public class explo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.CompareTag("MainCamera"))
		{
			Destroy(this.gameObject);
		}
	}
}
