using UnityEngine;
using System.Collections;

public class Looper : MonoBehaviour {

	public GameObject PortalOut;
	public GameObject MainCharacter, Boss, Camara;

	private Vector3 Temp, TempMain, TempBoss;

	void OnTriggerEnter2D(Collider2D Trigg)
	{
		Temp = Camara.transform.position;

		TempMain.y = Temp.y - MainCharacter.transform.position.y;
		TempMain.z = 0f;

		Temp.x = PortalOut.transform.position.x;
		Camara.transform.position = Temp;
		TempMain.x =  MainCharacter.transform.position.x - Camara.transform.position.x;

		TempBoss = Boss.transform.position;
		TempBoss.x = PortalOut.transform.position.x;


		MainCharacter.transform.position = TempMain;
		Boss.transform.position = TempBoss;
	}
}
