using UnityEngine;
using System.Collections;

public class AtributosGenerales : MonoBehaviour {

	public static float Speed = 5f, HighSpeed = 5f, Aumento = 3f;
	public static int Score;

	public float VarSpeed = 5f, VerHighSpeed = 5f, VarAumento = 3f;

	public void Update()
	{
		Speed = VarSpeed;
		HighSpeed = VerHighSpeed;
		Aumento = VarAumento;
	}
}
