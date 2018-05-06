using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D rb;
	public float Speed = 4f;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () {
		Vector2 dir = Vector2.zero;

		if (Input.GetKey (KeyCode.LeftArrow)) {
			dir.x = -1;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			dir.x = 1;
		}

		rb.velocity = dir * Speed;
	}
}
