using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BossLife : MonoBehaviour {

	public Atributos BossTribues;
	private Image Vida;

	void Start()
	{
		Vida = this.GetComponent<Image> ();
	}
	// Update is called once per frame
	void Update () {
		Vida.fillAmount = (float) BossTribues.vida / 30;
	}
}
