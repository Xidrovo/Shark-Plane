using UnityEngine;
using System.Collections;

public class UnPolitecnical : MonoBehaviour {

	private Atributos atri;
	private bool Subir;
	
	// Use this for initialization
	void Start () {
		Subir = true;
		atri = GetComponent<Atributos> ();
	}
	
	// Update is called once per frame
	void Update () {
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
	}
	
	void BottomUp(){
		transform.Translate (Vector3.up * atri.Speedy * Time.deltaTime);
	}
	
	void TopDown(){
		transform.Translate (Vector3.down * atri.Speedy * Time.deltaTime);
	}
	
	void MoveHorizontal(){
		transform.Translate (Vector3.right * atri.Speedx * Time.deltaTime);
	}
}
