using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Stop : MonoBehaviour {

	public float Speed = 5f, Delay = 0.01f;
	public Image Vida;
	public Text BossName;

	void Start()
	{
		Speed = AtributosGenerales.Speed;
	}

	void OnTriggerEnter2D(Collider2D Trigg)
	{
		if (Trigg.tag == "MainCamera") 
		{
			Vida.gameObject.SetActive(true);
			BossName.gameObject.SetActive(true);
			AtributosGenerales.Speed = 0;
		}
	}
}
