using UnityEngine;
using System.Collections;

public class Fundamuertos : MonoBehaviour {

	private GameObject shark;
	private Atributos atri;
	private bool Subir;
	
	// Use this for initialization
	void Start () {
		shark = GameObject.FindWithTag("Player");
		Subir = true;
		atri = GetComponent<Atributos>();
	}
	
	// Update is called once per frame
	void Update () {
		if (SharkCerca()) {
			AtacarHorizontal();
		} else {
			if (Subir) {
				BottomUp ();
				if ((int)(this.gameObject.transform.position.y) == (int)(atri.AlturaMax)) {
					Subir = false;
				}
			} else {
				TopDown ();
				if ((int)(this.gameObject.transform.position.y) == (int)(atri.AlturaMax - atri.Rango)) {
					Subir = true;
				}
			}
		}
	}
	
	void BottomUp(){
		transform.Translate (Vector3.up * atri.Speedy * Time.deltaTime);
	}
	
	void TopDown(){
		transform.Translate (Vector3.down * atri.Speedy * Time.deltaTime);
	}
	
	void AtacarHorizontal(){
		transform.Translate (Vector3.left * atri.Speedx * Time.deltaTime);
	}
	
	bool SharkCerca(){
		if (Vector3.Distance(this.gameObject.transform.position,shark.transform.position) <= 8f)
			return true;
		return false;
	}
}
