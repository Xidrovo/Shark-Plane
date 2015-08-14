using UnityEngine;
using System.Collections;

public class MexistorBehaviour : MonoBehaviour {

	public float AlturaMax;
	public float AlturaMin;
	public float Altura;
	private bool Subir;

	public float Speed;
	public float Vidas;

	// Use this for initialization
	void Start () {
		Subir = true;
	}
	
	// Update is called once per frame
	void Update () {
		Altura = this.GetComponent<Rigidbody2D> ().position.y;
		if (Subir) {
			BottomUp();
			if((int)(Altura)==(int)(AlturaMax)){
				Subir = false;
			}
		} else {
			TopDown();
			if((int)(Altura)==(int)(AlturaMin)){
				Subir = true;
			}
		}
		Disparar ();
	}

	void BottomUp(){
		transform.Translate (Vector3.up * Speed * Time.deltaTime);
	}

	void TopDown(){
		transform.Translate (Vector3.down * Speed * Time.deltaTime);
	}

	void Disparar(){
		//Dispare enemigo
	}
}
