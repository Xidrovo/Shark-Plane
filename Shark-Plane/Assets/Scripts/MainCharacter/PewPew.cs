using UnityEngine;
using System.Collections;

public class PewPew : MonoBehaviour {

	// Use this for initialization
	public GameObject player, prefab1;
	public Unzipper unzipper;
	private float speed=40f;
	private int i = 0;
	private GameObject nuevo;
	public Quaternion rotacion= Quaternion.Euler(0,0,0);
	void Start () 
	{

		
	}
	
	// Update is called once per frame
	void Update () 
	{
		i++;
		if(!(i>10 && i<20)&& ((i%10)==0))
		{
			if (unzipper.values[1] == "9" || Input.GetKey(KeyCode.Space)) 
			{
				CrearBala();
			}
		}
		if(i==40)
		{
			i=0;
		}
	}
	public void CrearBala()
	{
		nuevo=(GameObject)Instantiate ((GameObject)prefab1,new Vector3(player.transform.position.x + 0.4f ,player.transform.position.y - 0.25f,-1),rotacion);
		nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (speed, 0)), ForceMode2D.Impulse);

	}


}
