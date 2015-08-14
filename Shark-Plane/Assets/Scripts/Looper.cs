using UnityEngine;
using System.Collections;

public class Looper : MonoBehaviour {

	public GameObject PortalOut;
	public GameObject MainCharacter, Boss, Camara;

	public GameObject WordSpace;
	private Vector3 Temp, TempMain, TempBoss, Relative;
	private int Cont = 0;
	

	void OnTriggerEnter2D(Collider2D Trigg)
	{
		Temp = Camara.transform.position;

		Temp.x = PortalOut.transform.position.x;
		WordSpace.transform.position = Temp;

		Relative = WordSpace.transform.InverseTransformPoint(TempMain);
//		Relative.z = 0;
		Camara.transform.position = Temp;
		MainCharacter.transform.position = Relative;

	}

	void Update()
	{
		TempMain.x =  Camara.transform.position.x - MainCharacter.transform.position.x;
		TempMain.y = MainCharacter.transform.position.y - Camara.transform.position.y;
		TempMain.z = 10f;
		Relative = Camara.transform.InverseTransformDirection(TempMain);

		Debug.Log (Relative);
	}
}
