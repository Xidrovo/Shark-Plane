using UnityEngine;
using System.Collections;

public class Ataques : MonoBehaviour {

	// Use this for initialization
	public GameObject villano, prefab;
	private GameObject nuevo;
	public Quaternion rotacion = Quaternion.Euler(0,0,0);

	private Atributos Temp;
	void Start () {
		Temp = this.GetComponent<Atributos> ();
		villano = this.gameObject;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		Disparar ();

	
	}
	public void Disparar()
	{
		nuevo = (GameObject)Instantiate (prefab, (villano.transform.position), rotacion);
		nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-Temp.Speed, 0)), ForceMode2D.Impulse);
	}
}
