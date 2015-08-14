﻿using UnityEngine;
using System.Collections;

public class Atributos : MonoBehaviour {

	// Use this for initialization
	public float Speedy=6f, Speedx = AtributosGenerales.Speed/2, vida=1f;

	public float AlturaMax, Rango, Speed=25f;

	public void Update()
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
			if (vida == 0) 
			{
				Destroy(this.gameObject);
			}
		}

	}

}
