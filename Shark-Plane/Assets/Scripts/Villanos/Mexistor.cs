using UnityEngine;
using System.Collections;

public class Mexistor : MonoBehaviour {

	private Atributos atri;
	private bool Subir;
	public bool IniciaDerecha;
	private GameObject shark;
	// Use this for initialization
	void Start () {
		Subir = true;
		atri = GetComponent<Atributos> ();
		shark = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (SharkCerca()) 
		{
			if (Subir) {
				BottomUp();
				if((int)(this.gameObject.transform.position.y)==(int)(atri.AlturaMax)){
					Subir = false;
				}
			} else {
				TopDown();
				if((int)(this.gameObject.transform.position.y)==(int)(atri.AlturaMax-atri.Rango)){
					Subir = true;
				}
			}
			MoveHorizontal ();
			Disparar ();
		}


	}

	bool SharkCerca(){
		if (Vector3.Distance(this.gameObject.transform.position,shark.transform.position) <= 35f)
			return true;
		return false;
	}
	
	void BottomUp(){
		transform.Translate (Vector3.up * atri.Speedy * Time.deltaTime);
		if (IniciaDerecha) {
			transform.Translate (Vector3.right * atri.Speedy * Time.deltaTime);
		} else {
			transform.Translate (Vector3.left * atri.Speedy* Time.deltaTime);
		}
	}
	
	void TopDown(){
		transform.Translate (Vector3.down * atri.Speedy * Time.deltaTime);
		if (IniciaDerecha) {
			transform.Translate (Vector3.left * atri.Speedy * Time.deltaTime);
		} else {
			transform.Translate (Vector3.right * atri.Speedy * Time.deltaTime);
		}
	}
	
	void MoveHorizontal(){
		transform.Translate (Vector3.right * atri.Speedx * Time.deltaTime);
	}
	
	
	void Disparar(){
		//Dispare enemigo
	}
}
