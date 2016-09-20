using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

	public float limiteEsq, limiteDir;
	private Vector3 posIni;

	private bool isShaking;

	// Use this for initialization
	void Start () {
		posIni = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (PrincipalScript.estaAtirando && !isShaking) {
			StartCoroutine (ShakeC ());			
		}
	}

	IEnumerator ShakeC(){

		isShaking = true;

		for(int i = 0; i <= 3; i++){
			transform.position = new Vector3 (limiteEsq, 0f, transform.position.z);
			yield return new WaitForSeconds (0.01f);
			transform.position = new Vector3 (limiteDir, 0f, transform.position.z);
			yield return new WaitForSeconds (0.01f);
		}

		transform.position = posIni;
		isShaking = false;


	}
}
