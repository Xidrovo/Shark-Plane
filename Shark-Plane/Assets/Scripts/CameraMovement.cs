﻿using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float Speed = AtributosGenerales.Speed;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.right * Speed * Time.deltaTime);
		Speed = AtributosGenerales.Speed;
	}
}
