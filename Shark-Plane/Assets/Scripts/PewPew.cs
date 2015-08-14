using UnityEngine;
using System.Collections;

public class PewPew : MonoBehaviour {

	// Use this for initialization
	public GameObject player, prefab1;
	private float speed=40f;
	private GameObject nuevo;
	public Quaternion rotacion= Quaternion.Euler(0,0,0);
	void Start () 
	{

		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey (KeyCode.Space)) 
		{
			CrearBala();

		}
		
	}
	public void CrearBala()
	{
		nuevo=(GameObject)Instantiate ((GameObject)prefab1,new Vector3(player.transform.position.x,player.transform.position.y,0),rotacion);
		nuevo.GetComponent<Rigidbody> ().AddRelativeForce ((new Vector2 (speed, 0)), ForceMode.Impulse);

	}


}
