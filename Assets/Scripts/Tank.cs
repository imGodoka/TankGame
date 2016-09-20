using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	public float velocidade;
	public float forcaPulo;

	public GameObject tank;

	private Rigidbody2D rb;

	public Transform chaoVerificador;
	//private Vector2 posIni;
	private bool estaNoChao;
	private Vector2 face;


	// Use this for initialization
	void Start () {
		face = Vector2.left;
		rb = GetComponent<Rigidbody2D> ();
		//posIni = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		ControlarTank ();
		Jump ();
		FeedbackTiro ();
	}

	void ControlarTank (){

		//Obtem input das teclas direcionais ou A/D para mover o tank
		float px = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;

		//Rotacionar o tank
		if (Input.GetAxisRaw ("Horizontal") < 0) {
			tank.transform.eulerAngles = new Vector2 (0f, 180f);
			face = Vector2.right;
		} else if (Input.GetAxisRaw ("Horizontal") > 0) {
			tank.transform.eulerAngles = new Vector2 (0f, 0f);
			face = Vector2.left;
		}


		//Move o Tank
		transform.Translate (px, 0f, 0f);
	}

	void FeedbackTiro(){

		if (PrincipalScript.estaAtirando) {
			rb.AddForce (face * 30f);
		}

	}

	void Jump(){
		//Pulo
		estaNoChao = Physics2D.Linecast (transform.position, chaoVerificador.position,
			1 << LayerMask.NameToLayer ("Tiles"));
		
		if (Input.GetButtonDown("jump") && estaNoChao) {
			rb.velocity = new Vector2(0f, forcaPulo);
		}

	}
}
