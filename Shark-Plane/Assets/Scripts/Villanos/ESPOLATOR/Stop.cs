using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {

	public float Speed = 5f, Delay = 0.01f;

	void Start()
	{
		Speed = AtributosGenerales.Speed;
	}

	void OnTriggerEnter2D(Collider2D Trigg)
	{
		if (Trigg.tag == "MainCamera") 
		{
			AtributosGenerales.Speed = 0;
		}
	}
}
