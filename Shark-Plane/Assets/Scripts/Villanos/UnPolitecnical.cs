using UnityEngine;
using System.Collections;

public class UnPolitecnical : MonoBehaviour {

	private Atributos atri;
	private bool Subir;
	private GameObject shark;
	// Use this for initialization
	void Start () {
		Subir = true;
		atri = GetComponent<Atributos> ();
		shark = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (SharkCerca ()) {
			if (Subir) {
				BottomUp ();
				if (this.gameObject.transform.position.y >= atri.AlturaMax) {
					Subir = false;
				}
			} else {
				TopDown ();
				if (this.gameObject.transform.position.y <= atri.AlturaMax - atri.Rango) {
					Subir = true;
				}
			}
			MoveHorizontal ();
		}
	}

	bool SharkCerca(){
		if (Vector3.Distance(this.gameObject.transform.position,shark.transform.position) <= 8f)
			return true;
		return false;
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
