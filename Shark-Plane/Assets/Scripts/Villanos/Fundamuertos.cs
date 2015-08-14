using UnityEngine;
using System.Collections;

public class Fundamuertos : MonoBehaviour {

	private Atributos atri;
	private bool Subir;
	private bool AmpliarVuelo;
	private float CorteAmplitud;
	private float AltoMax;
	private float Amplitud;
	
	// Use this for initialization
	void Start () {
		Subir = true;
		AmpliarVuelo = false;
		CorteAmplitud = 1f;
		atri = GetComponent<Atributos> ();
		AltoMax = atri.AlturaMax;
		Amplitud = atri.Rango;
	}
	
	// Update is called once per frame
	void Update () {
		if (Subir) {
			BottomUp();
			if((int)(this.gameObject.transform.position.y)==(int)((int)(AltoMax))){
				Subir = false;
			}
		} else {
			TopDown();
			if((int)(this.gameObject.transform.position.y)==(int)(AltoMax - Amplitud)){
				Subir = true;
			}
		}
		if(AmpliarVuelo){
			CorteAmplitud += Time.deltaTime;
			AltoMax = atri.AlturaMax + (atri.AlturaMax*((int)(CorteAmplitud)/2f));
		}else{
			CorteAmplitud -= Time.deltaTime;
			AltoMax = atri.AlturaMax - (atri.AlturaMax/((int)(CorteAmplitud)*2f));
		}
		Amplitud = atri.Rango /((int)(CorteAmplitud));
		if (CorteAmplitud >3f) {
			CorteAmplitud = 3f;
			AmpliarVuelo = false;
		} else if (CorteAmplitud <1f) {
			CorteAmplitud = 1f;
			AmpliarVuelo = true;
		}
		MoveHorizontal ();
	}
	
	void BottomUp(){
		transform.Translate (Vector3.up * atri.Speedy * Time.deltaTime/CorteAmplitud);
	}
	
	void TopDown(){
		transform.Translate (Vector3.down * atri.Speedy * Time.deltaTime/CorteAmplitud);
	}
	
	void MoveHorizontal(){
		transform.Translate (Vector3.right * atri.Speedx * Time.deltaTime);
	}
}
