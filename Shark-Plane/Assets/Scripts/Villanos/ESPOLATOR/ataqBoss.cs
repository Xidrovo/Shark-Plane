using UnityEngine;
using System.Collections;

public class ataqBoss : MonoBehaviour {

	public GameObject  prefab;
	private GameObject nuevo;
	public Quaternion rotacion = Quaternion.Euler(0,0,0);
	private Atributos Temp;
	private int i = 0;

	// Use this for initialization
	void Start () {
		Temp = this.GetComponent<Atributos> ();
	}
	
	// Update is called once per frame
	void Update () {
		ataqSenoidal ();
	}

	public void ataqSenoidal()
	{

			int ran = Random.Range(0,360);
			if(i<(ran+10)|| (i>ran) || Input.GetKey(KeyCode.A))
			{
				Disparar(i);
			}
		if (i == 360) {
			i = 0;
		}
	}


	public void Disparar(int i)
	{
		nuevo = (GameObject)Instantiate (prefab, new Vector3 (0 ,10.5f * (float) Mathf.Cos(2 * Mathf.PI*i)) , rotacion);
		nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-Temp.Speed, 0)), ForceMode2D.Impulse);
	}
}
