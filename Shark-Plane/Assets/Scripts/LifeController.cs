using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LifeController : MonoBehaviour {

	public Image Vida1, Vida2, Vida3;
	public float TotalLife = 300f, CurrentLife = 300f;
	public muerteJug Death;

	private int[] LifeArray = new int[3];

	void Start()
	{
		LifeArray [0] = 0;
		LifeArray [1] = 0;
		LifeArray [2] = 0;
	}
	public void GetDamage(float Dano)
	{
		CurrentLife = CurrentLife - Dano;

		if (CurrentLife > 200) {
			Vida1.fillAmount = (float)(CurrentLife - 200) / 100f;

			if (Vida1.fillAmount <= 0.05f)
			{
				Vida1.fillAmount = 0;
				LifeArray[0] = 1;
				Death.Kill();
			}

		} else if (CurrentLife > 100) {
			Vida1.fillAmount = 0;
			Vida2.fillAmount = (float)(CurrentLife - 100) / 100f;

			if (Vida2.fillAmount <= 0.05f)
			{
				Vida2.fillAmount = 0;
				LifeArray [1] = 1;
				Death.Kill();
			}
		} else {
			Vida2.fillAmount = 0;
			Vida3.fillAmount = (float) (CurrentLife / 100f);
			//Hacer Game Over
		}
		if (CurrentLife == 0) {
			Application.LoadLevel("gameover");
		}
	}

	//Si "Accion == true", entonces gana una vida.
	//Caso contrario pierda una vida.
	public void LifeUpgrade(bool Accion)
	{
		//Accion cuando pierde una vida.
		if (Accion == false) {
			if (LifeArray [0] == 0f) {
				Vida1.fillAmount = 0f;
				CurrentLife = 200f;
				LifeArray [0] = 1;
			} else if (LifeArray [1] == 0f) {
				Vida2.fillAmount = 0f;
				CurrentLife = 100f;
				LifeArray[1] = 1;
			} else {
				//GameOver
				Vida3.fillAmount = 0.2f;
				CurrentLife = 20f;
			}
		} else 
		{
			if (Vida2.fillAmount == 0f)
			{
				Vida2.fillAmount = Vida3.fillAmount;
				Vida3.fillAmount = 1f;
				CurrentLife = CurrentLife + 100f;
				LifeArray[1] = 0;
			} else if ( Vida1.fillAmount == 0f)
			{
				Vida1.fillAmount = Vida2.fillAmount;
				Vida2.fillAmount = 1f;
				CurrentLife = CurrentLife + 100f;
				LifeArray[0] = 0;
			}else
			{
				Vida1.fillAmount = 1f;
				CurrentLife = 300f;
				LifeArray[0] = 0;
			}
		}
	}
}
