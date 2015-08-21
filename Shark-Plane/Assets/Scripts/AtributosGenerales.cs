using UnityEngine;
using System.Collections;

public class AtributosGenerales : MonoBehaviour {

	public static float Speed = 5f, HighSpeed = 5f, Aumento = 3f;
	public static int Score;
	//public static GameObject Tcred, Ncred, TTcred;
	public static bool Scripted = false;
	public float VarSpeed = 5f, VerHighSpeed = 5f, VarAumento = 3f;

	void Start()
	{
		Speed = VarSpeed;
		HighSpeed = VerHighSpeed;
		Aumento = VarAumento;
	}
}
