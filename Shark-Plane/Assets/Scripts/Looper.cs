using UnityEngine;
using System.Collections;

public class Looper : MonoBehaviour {

	public GameObject PortalOut;
	public GameObject MainCharacter, Boss, Camara;

	public GameObject WordSpace;
	private Vector3 Temp, TempMain, TempBoss, Relative;
	private int Cont = 0, Tomp = -2;
	

	void OnTriggerEnter2D(Collider2D Trigg)
	{
		if(Trigg.tag == "MainCamera")
		{
			Temp = Camara.transform.position;

			Temp.x = PortalOut.transform.position.x;
			WordSpace.transform.position = Temp;

			Relative = WordSpace.transform.InverseTransformPoint(TempMain);
	//		Relative.z = 0;
			if (Tomp < 0)
			{
				Relative = Relative * -1;
				Tomp = -2;
			}
			Relative.z = 0;
			Debug.Log(WordSpace.transform.position);
			Camara.transform.position = Temp;
			MainCharacter.transform.position = Relative;
			Debug.Log(Relative);
			Tomp++;
		}
	}

	void Update()
	{
		TempMain.x = Camara.transform.position.x - MainCharacter.transform.position.x;
		TempMain.y = Camara.transform.position.y - MainCharacter.transform.position.y;
		TempMain.z = 10f;
		Relative = Camara.transform.InverseTransformDirection(TempMain);

//		Debug.Log (Relative);
	}
}
