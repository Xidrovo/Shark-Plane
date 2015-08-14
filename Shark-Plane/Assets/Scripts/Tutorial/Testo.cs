using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Testo : MonoBehaviour {

	private Text testo;
	public static int Controlador = 0;

	void Start()
	{
		testo = this.GetComponent<Text> ();
		StartCoroutine(TestCoroutine());
	}
	// Update is called once per frame
	void Update () {
		if (Controlador > 0) 
		{
			//Comenzar la rutina del tutorial.
		}
	}

	IEnumerator TestCoroutine(){
		testo.text = "¡hey!";
		yield return new WaitForSeconds(1);
		testo.text = "¿Como estas?";
		yield return new WaitForSeconds(2);
		testo.text = "Bienvenido, ¿estas emocionado?";
		yield return new WaitForSeconds(2);
		testo.text = "Muchos lo estan cuando pasan por aqui";
		yield return new WaitForSeconds(3);
		testo.text = "Primero lo primero";
		yield return new WaitForSeconds(2);
		testo.text = "Te doy la bienvenida a este lugar";
		yield return new WaitForSeconds(2);
		testo.text = "Ahora aprendamos los controles basicos";
		yield return new WaitForSeconds(2);
		testo.text = "¿Ves ese deslizador en el celular?";
		yield return new WaitForSeconds(2);
		testo.text = "Con el podras cambiar tu velocidad";
		yield return new WaitForSeconds(2);
		testo.text = "Vamos, trata de moverte hacia al frente";
		yield return new WaitForSeconds(2);
		testo.text = "Solo mueve el deslizador hacia al frente";
		yield break;
		Debug.Log ("You'll never see this"); // produces a dead code warning
	}
}