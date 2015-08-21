using UnityEngine;
using System.Collections;

public class ataqBoss : MonoBehaviour {

	public GameObject villano, prefab, prefab2;
	private GameObject nuevo;
	public Quaternion rotacion = Quaternion.Euler(0,0,0);
	private Atributos Temp;
	private int i = 0, cont=0, cont2=0;
	private int rand, rand2, randAtaq = 1;
	private GameObject shark;
	private bool Subir, Comienzo, Focus;
	// Use this for initialization

	void Start () {
		Subir = true;
		Comienzo = true;
		Focus = false;
		Temp = this.GetComponent<Atributos> ();
		villano = this.gameObject;
		shark = GameObject.FindWithTag("Player");
		rand2=Random.Range (4, 5);
		rand = rand2*Random.Range (1, 3);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (SharkCerca ()) 
		{
			i++;
			Debug.Log(i);
			if (this.GetComponent<Atributos> ().vida < 5) {
				AtaqueFinal (i);
			} else 
			{
				switch (randAtaq) 
				{
				case 1:
					{
						AtaqueCruz (i);
						break;
					}
				case 2:
					{
						
						AtaqueCabeza ();
						break;
					}
				}
				if (i >= 40) 
				{
					i = 0;
					if (randAtaq == 1) 
					{
						randAtaq = 2;
					} 
					else 
					{
						randAtaq = 1;
					}
				}

			}
		}

	}

	public void AtaqueCruz(int i)
	{
		cont2++;
		if (cont2 == 100) 
		{
			cont2=0;
		}
		if((i%5)==0)
		{
			if( cont2<20)
			{
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x,8f*Random.Range(0.5f,1),0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, -5f)), ForceMode2D.Impulse);
				
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x,-1.5f*Random.Range(0.5f,1),0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, 5f)), ForceMode2D.Impulse);
			}
			else if(cont2 >=20 && cont2<=40)
			{
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x,7.5f,0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, 0)), ForceMode2D.Impulse);
				
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x,-1f,0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, 0)), ForceMode2D.Impulse);

			}
			else if(cont2 >=60 && cont2<=80)
			{
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x-10,8f*Random.Range(0.5f,1),0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, -5f)), ForceMode2D.Impulse);
				
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x-10,-1.5f*Random.Range(0.5f,1),0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, 5f)), ForceMode2D.Impulse);
				
			}
			else
			{
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x,5.5f,0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, 0)), ForceMode2D.Impulse);
				
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x,1f,0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, 0)), ForceMode2D.Impulse);
				
				nuevo = (GameObject)Instantiate (prefab2, new Vector3(villano.transform.position.x,3f,0), rotacion);
				nuevo.GetComponent<Rigidbody2D>().gravityScale=0;
				nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-10f, 0)), ForceMode2D.Impulse);
			}

		}
	}

	public void AtaqueFinal(int i)
	{

		if((i%10)==0)
		{
			SenDisp ();
			
		}
		if((i%5)==0)
		{
			cont++;
			ArribaDisp();
		}

	}

	bool SharkCerca(){
		if (Vector3.Distance(this.gameObject.transform.position,shark.transform.position) <= 30f)
			return true;
		return false;
	}
	
	public void SenDisp()
	{
		nuevo = (GameObject)Instantiate (prefab, new Vector3(villano.transform.position.x,5f,0), rotacion);
		nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce ((new Vector2 (-4f, 8f)), ForceMode2D.Impulse);
	}

	public void ArribaDisp()
	{
		if (cont <= 10) {
			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-12.5f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);
		} 
		else if (10 < cont && cont <= 20) 
		{
			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-10f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);
		} 
		else if (20 < cont && cont <= 30) 
		{
			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-7.5f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);
		} 
		else if (30 < cont && cont <= 40) 
		{
			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-5f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);
		}
		else if (40 < cont && cont <= 50) 
		{
			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-2.5f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);
		} 
		else if (50 < cont && cont <= 60) 
		{
			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);
		} 
		else 
		{
			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);

			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-2.5f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);

			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-5f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);

			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-7.5f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);

			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-10f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);

			nuevo = (GameObject)Instantiate (prefab2, new Vector2 (villano.transform.position.x - rand-12.5f, -1.2f), rotacion);
			nuevo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 22.5f), ForceMode2D.Impulse);


		}
	}

	void AtaqueCabeza(){
		if (Subir && Comienzo) {
			transform.Translate (Vector3.up * Temp.Speedx * Time.deltaTime);
			if (villano.transform.position.y > 5f) {
				Subir = false;
			}
		} else if (!Subir && Comienzo) {
			transform.Translate (Vector3.down * Temp.Speedx * Time.deltaTime);
			if (villano.transform.position.y < -6f) {
				Subir = true;
				Comienzo = false;
			}
		} else if (Subir && !Comienzo) {
			if(!Focus){
				if((int)(villano.transform.position.x)!=(int)(shark.transform.position.x)){
					if((int)(villano.transform.position.x)>(int)(shark.transform.position.x)){
						transform.Translate (Vector3.left * Temp.Speedx * Time.deltaTime);
					}else if((int)(villano.transform.position.x)<(int)(shark.transform.position.x)){
						transform.Translate (Vector3.right * Temp.Speedx * Time.deltaTime);
					}
				}
				if((int)(villano.transform.position.x)==(int)(shark.transform.position.x))Focus = true;
			}else{
				transform.Translate (Vector3.up * Temp.Speedy * Time.deltaTime);
			}
			if (villano.transform.position.y > 13f) {
				Subir = false;
			}
		} else if (!Subir && !Comienzo) {
			if((int)(villano.transform.position.x)!=390){
				transform.Translate (Vector3.right * Temp.Speedx * Time.deltaTime);
			}
			if(villano.transform.position.y > 4f){
				transform.Translate (Vector3.down * Temp.Speedy * Time.deltaTime);
			}
			if((int)(villano.transform.position.y)== 4){
				Subir= true;
				Comienzo = true;
				Focus = false;
			}
		}
	}
}
