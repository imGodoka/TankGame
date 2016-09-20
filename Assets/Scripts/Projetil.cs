using UnityEngine;
using System.Collections;

public class Projetil : MonoBehaviour {

	public float velocidade;

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.right * velocidade * Time.deltaTime);
	
	}

	void OnCollisionEnter2D(Collision2D c){
		if (c.collider.tag != "Player") {
			Destroy (gameObject);
		}
	}
}
