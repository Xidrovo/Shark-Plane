using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnCollisionEnter(Collision col)
	{
		
		//if (col.gameObject.CompareTag ("Enemy")) 
		{
			//pierde vidas
		}
		Destroy(this);
	}
	public void OnTriggerExit(Collider col)
	{
		
		if (col.gameObject.CompareTag ("MainCamera")) 
		{
			Destroy(this);
		}
		
	}
}
