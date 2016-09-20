using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour {

	public GameObject projetil;



	void Update () {

		if (PrincipalScript.estaAtirando) {
			Instantiate (projetil, transform.position, transform.rotation);
		}
	
	}


}
