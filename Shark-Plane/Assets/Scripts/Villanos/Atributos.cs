using UnityEngine;
using System.Collections;

public class Atributos : MonoBehaviour {

	// Use this for initialization
	public float Speedy=6f, Speedx = AtributosGenerales.Speed/2, vida=1f;
	public int Puntos = 50, Temp = 0;
	public float AlturaMax, Rango, Speed=25f;
	public Score score;
	private GameObject nuevo;
	private Quaternion rotation= Quaternion.Euler(0,0,0);
	public GameObject Tcred;
	public GameObject prefabVida, PastelChino;
	void Start()
	{
		Physics2D.IgnoreLayerCollision (8, 9, true);
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Destroyer") 
		{
			Destroy(this.gameObject);
		}
	}

	void Update()
	{
		if(vida==0)
		{
			Destroy(this.gameObject);
		}
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag ("Bala")) 
		{
			vida--;
			Destroy(col.gameObject);
			if (vida <= 0) 
			{
				if(this.gameObject.name.Equals("Espolator3000"))
				{
					Instantiate(Tcred,new Vector3(0,0,0),Quaternion.Euler(0,0,0));
				}
				score.ActualizarTexto((int)Puntos);
				int Temp = Random.Range(0,100);
				if (Temp <= 20)
				{
					if (Temp <= 8)
					{
						Instantiate(prefabVida,this.transform.position,Quaternion.Euler(0,0,0));
					}else
					{
						Instantiate(PastelChino,this.transform.position,Quaternion.Euler(0,0,0));
					}
				}
				Destroy(this.gameObject);
			}
		}

	}
	public void CrearVida()
	{
		nuevo = (GameObject)Instantiate (prefabVida,this.gameObject.transform.position, rotation);
	}

}
