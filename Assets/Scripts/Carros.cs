using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carros : MonoBehaviour {

	private Rigidbody2D rb;
	public float Speed = 5f;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () {
		rb.velocity = Vector2.down * Speed;
	}
}
