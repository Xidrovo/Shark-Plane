using UnityEngine;
using System.Collections;

public class Fundamuertos : MonoBehaviour {

	private GameObject shark;
	private Atributos atri;
	private bool Subir;
	private float altu=3f; 
	private Vector3 positionB;
	
	// Use this for initialization
	void Start () {
		shark = GameObject.FindWithTag("Player");
		Subir = true;
		atri = GetComponent<Atributos>();
		positionB=new Vector3(this.transform.position.x,this.transform.position.y,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (SharkCerca()) 
		{
			AtacarHorizontal();
			if (shark.transform.position.y - this.transform.position.y>0){
				BottomUp ();

			} else {
				TopDown ();

			}
		} else {
			if (Subir) {

				BottomUp ();
				if ((int)(this.gameObject.transform.position.y) >= (int)(positionB.y+altu)) {
					Subir = false;
				}
			} else {
				TopDown ();
				if ((int)(this.gameObject.transform.position.y) <= (int)(positionB.y)) {
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
		if (Vector3.Distance(new Vector3(this.gameObject.transform.position.x,0,0),new Vector3(shark.gameObject.transform.position.x,0,0)) <= 9f)
			return true;
		return false;
	}
}
