using UnityEngine;
using System.Collections;

public class ataqBoss : MonoBehaviour {

	public GameObject villano, prefab;
	private GameObject nuevo;
	public Quaternion rotacion = Quaternion.Euler(0,0,0);
	private Atributos Temp;
	int i=0, ran=0;
	private GameObject shark;
	// Use this for initialization
	void Start () {
		Temp = this.GetComponent<Atributos> ();
		villano = this.gameObject;
		shark = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (SharkCerca ()) 
		{
			i++;
			if(!(i>10 && i<20)&& ((i%5)==0))
			{
				Disparar ();
			}
			if(i==40)
			{
				i=0;
			}
		}

	}

	bool SharkCerca(){
		if (Vector3.Distance(this.gameObject.transform.position,shark.transform.position) <= 30f)
			return true;
		return false;
	}
	
	public void Disparar()
	{
		nuevo = (GameObject)Instantiate (prefab, new Vector3(villano.transform.position.x,5f,0), rotacion);
		nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-5, 9f)), ForceMode2D.Impulse);
	}
}
