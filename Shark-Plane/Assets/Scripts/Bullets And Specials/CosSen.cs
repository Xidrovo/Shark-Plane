using UnityEngine;
using System.Collections;

public class CosSen : MonoBehaviour {

	// Use this for initialization
	public GameObject prefab;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(this.gameObject.transform.position.y <= -0.006f)
		{
			prefab.GetComponent<Rigidbody2D>().AddRelativeForce((new Vector2(-3,10f)), ForceMode2D.Impulse);
			//Destroy(this.gameObject);
		}
	
	}
}
