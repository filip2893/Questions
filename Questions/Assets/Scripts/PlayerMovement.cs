using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	public static bool DestroyCollider = false;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.5f;
	public LayerMask WhatIsGround;
	public float JumpForce = 700f;

	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, WhatIsGround);

		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * speed, GetComponent<Rigidbody2D> ().velocity.y);
	}

	void Update(){
		if (grounded && Input.GetKeyDown(KeyCode.Space)) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce));
		}
	}
}
