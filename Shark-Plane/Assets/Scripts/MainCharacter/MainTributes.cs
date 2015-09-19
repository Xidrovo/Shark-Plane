using UnityEngine;
using System.Collections;

public class MainTributes : MonoBehaviour {

	float Dano;
	public LifeController ControladorDeVida;
    public static bool Invunerable = false;

	void OnTriggerEnter2D ( Collider2D Trigg )
	{
		if (Trigg.tag == "BalaEne" && Invunerable == false) 
		{
			Dano = Trigg.GetComponent<BulletTributes>().Damage;
            Dano = 10f;
			ControladorDeVida.GetDamage(Dano);
		}
	}
}
