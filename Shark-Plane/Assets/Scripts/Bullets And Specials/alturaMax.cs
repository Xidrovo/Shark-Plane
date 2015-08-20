using UnityEngine;
using System.Collections;

public class alturaMax : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.transform.position.y >= 10f) 
		{
			Destroy(this.gameObject);
		}
	
	}
}
