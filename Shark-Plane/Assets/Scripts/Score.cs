using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private static Text testo;
	private static string str;

	void Start()
	{
		testo = this.GetComponent<Text>();
	}
	public void ActualizarTexto( int Score)
	{
		int Acumulado = 20;
		Acumulado = int.Parse (testo.text);
		Acumulado = Acumulado + Score;
		try
		{
			testo.text = "" + Acumulado;
		}
		catch(System.Exception e)
		{
			Debug.Log (e.Message);
		}
	}
}
