using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	public muerteJug Death;
	public LifeController Controlador;
	public GameObject Hider;

	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") 
		{
			Death.Kill();
			Controlador.LifeUpgrade(false);
		}
		
	}

	public void OnTriggerEnter2D(Collider2D Trigg)
	{
		if (Trigg.tag == "Heal") 
		{
			Controlador.GetDamage(-25);
			Destroy(Trigg.gameObject);
		}

		if (Trigg.tag == "LifeUp") 
		{
			Controlador.LifeUpgrade(true);
			Destroy(Trigg.gameObject);
		}
	}
}
