using UnityEngine;
using System.Collections;

public class PrincipalScript : MonoBehaviour {

	public static bool estaAtirando;

	// Update is called once per frame
	void Update () {
		//Controla a ação de atirar
		if (Input.GetButtonDown ("Fire1")) {
			estaAtirando = true;
		} else {
			estaAtirando = false;
		}
	}
}
