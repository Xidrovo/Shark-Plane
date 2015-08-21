using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Testo : MonoBehaviour {

	private Text testo;
	private int SubControl = 0, Controlador = 0;
	public Unzipper unzip;

	void Start()
	{
		testo = this.GetComponent<Text> ();
		StartCoroutine(TestCoroutine());
	}
	// Update is called once per frame
	void Update () {

		//aqui va la parte del tutorial de la aceleracion
		if (Controlador == 1) 
		{
			if (SubControl == 0)
			{
				if (Input.GetKey(KeyCode.RightArrow) || unzip.values[0] == "3")
				{
					testo.text = "¡Bien!, ahora muevelo al otro lado";
					SubControl = 1;
				}
			}

			if (SubControl >= 1 && SubControl < 250 )
			{
				if (Input.GetKey(KeyCode.LeftArrow) || unzip.values[0] == "1")
				{
					testo.text = "¡Bien!, ahora aprendamos a subir";
				}
				SubControl++;
			}

			if (SubControl >= 250)
			{
				testo.text = "Apunta con tu brazo hacia arriba";
				Controlador = 2;
				SubControl = 0;
			}
		}

		//Aqui va la parte del tutorial de el "High And Low"
		if (Controlador == 2) 
		{
			if (SubControl == 0)
			{
				if(Input.GetKey(KeyCode.UpArrow) || unzip.values[2] == "4")
				{	
					testo.text = "¡Bien hecho!, prueba apuntando hacia abajo";
					SubControl = 1;
				}
			}
			if (SubControl >= 1 && SubControl < 250)
			{
				if (Input.GetKey(KeyCode.DownArrow) || unzip.values[2] == "6")
				{
					testo.text = "¡Ya estamos cerca del final!";
				}

				SubControl++;
			}

			if (SubControl >= 250 && SubControl < 500)
			{
				testo.text = "A lo largo de tu aventura encontraras peligro";
				SubControl++;
			}

			if(SubControl >= 500 && SubControl < 750)
			{
				testo.text = "Para eso aprenderas a enfrentarte a ellos";
				SubControl++;
			}

			if(SubControl >= 750)
			{
				testo.text = "Tapa la parte frontal de tu celular";
				Controlador = 3;
				SubControl = 0;
			}
		}

		if (Controlador == 3) 
		{
			if (SubControl == 0)
			{
				if (Input.GetKey(KeyCode.Space) || unzip.values[1] == "9")
				{
					SubControl = 1;
				}
			}

			if (SubControl >= 1)
			{
				testo.text = "¡Felicidades!, ahora podras comenzar!";
				SubControl++;
			}

			if (SubControl >= 250)
			{
				Application.LoadLevel ("Pre");
			}
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
		testo.text = "El primero que aprenderas sera de suma importancia";
		yield return new WaitForSeconds(2);
		testo.text = "Con el podras cambiar tu velocidad";
		yield return new WaitForSeconds(2);
		testo.text = "Vamos, trata de moverte hacia al frente";
		yield return new WaitForSeconds(2);
		testo.text = "Solo gira tu muñeca hacia al frente";
		yield return new WaitForSeconds(2);
		Controlador = 1;
		yield break;
		Debug.Log ("You'll never see this"); // produces a dead code warning
	}
}