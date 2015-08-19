using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LifeController : MonoBehaviour {

	public Image Vida1, Vida2, Vida3;
	public float TotalLife = 300f, CurrentLife = 300f;
	public muerteJug Death;

	public void GetDamage(float Dano)
	{
		CurrentLife = CurrentLife - Dano;

		if (CurrentLife > 200) {
			Vida1.fillAmount = (float)(CurrentLife - 200) / 100f;

			if (Vida1.fillAmount <= 0.05f)
			{
				Death.Kill();
			}

		} else if (CurrentLife > 100) {
			Vida2.fillAmount = (float)(CurrentLife - 100) / 100f;

			if (Vida2.fillAmount <= 0.05f)
			{
				Debug.Log("Muerte 2");
				Death.Kill();
			}
		} else {
			Vida3.fillAmount = (float) (CurrentLife / 100f);
			//Hacer Game Over
		}
	}
}
