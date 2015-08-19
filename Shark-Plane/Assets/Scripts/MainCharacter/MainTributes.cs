using UnityEngine;
using System.Collections;

public class MainTributes : MonoBehaviour {

	float Dano;
	public LifeController ControladorDeVida;

	void OnTriggerEnter2D ( Collider2D Trigg )
	{
		if (Trigg.tag == "BalaEne") 
		{
			Dano = Trigg.GetComponent<BulletTributes>().Damage;
			ControladorDeVida.GetDamage(Dano);
		}
	}
}
