using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	public muerteJug Death;
	public LifeController Controlador;

	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") 
		{
			Death.Kill();
			Controlador.LifeUpgrade(false);
		}

	}
}
