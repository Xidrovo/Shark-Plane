using UnityEngine;
using System.Collections;

public class Ataques : MonoBehaviour {

	// Use this for initialization
	public GameObject villano, prefab;
	private GameObject nuevo, shark;
	public Quaternion rotacion = Quaternion.Euler(0,0,0);
	public bool vertical;
	public float shootForce;
	
	private Atributos Temp;
	void Start () {
		Temp = this.GetComponent<Atributos> ();
		villano = this.gameObject;
		shark = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (SharkCerca()) {
			if(vertical){
				LanzarProyectil();
			}else Disparar ();
		}
	}
	public void Disparar()
	{
		nuevo = (GameObject)Instantiate (prefab, (villano.transform.position), rotacion);
		nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-Temp.Speed, 0)), ForceMode2D.Impulse);
	}
	
	void LanzarProyectil(){
		nuevo = (GameObject)Instantiate (prefab, new Vector2(villano.transform.position.x,villano.transform.position.y+0.5f), rotacion);
		nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (1f, shootForce), ForceMode2D.Impulse);
	}
	
	bool SharkCerca(){
		if (Vector3.Distance(this.gameObject.transform.position,shark.transform.position) <= 8f)
			return true;
		return false;
	}
}
