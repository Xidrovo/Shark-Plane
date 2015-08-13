using UnityEngine;
using System.Collections;

public class PewPew : MonoBehaviour {

	// Use this for initialization
	public GameObject player, prefab1;
	public float speed=2f;
	private GameObject nuevo;
	public Quaternion rotacion= Quaternion.Euler(0,0,0);
	void Start () 
	{

		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
	}
	public void CrearBala()
	{
		nuevo=(GameObject)Instantiate ((GameObject)prefab1,new Vector3(0,0,0),rotacion);
		nuevo.GetComponent<Rigidbody> ().AddForce (new Vector2 (0 , speed));
	}
	public void OnCollisionEnter(Collision col)
	{
		
		if (col.gameObject.CompareTag ("Enemy")) 
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
