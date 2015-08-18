using UnityEngine;
using System.Collections;

public class ataqBoss : MonoBehaviour {

	public GameObject villano, prefab;
	private GameObject nuevo;
	public Quaternion rotacion = Quaternion.Euler(0,0,0);
	private Atributos Temp;
	// Use this for initialization
	void Start () {
		Temp = this.GetComponent<Atributos> ();
		villano = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ataqSenoidal()
	{
		for(int i=0; i<360; i++)
		{
			int ran=Random.Range(0,360);
			if(i<(ran+10)|| (i>ran))
			{
				Disparar(i);
			}

		}
	}
	public void Disparar(int i)
	{
		nuevo = (GameObject)Instantiate (prefab, 10.5f* Mathf.Cos(2*Mathf.PI*i), rotacion);
		nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-Temp.Speed, 0)), ForceMode2D.Impulse);
	}
}
