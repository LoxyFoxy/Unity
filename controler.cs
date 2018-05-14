using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour {
	float h;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis("Horizontal");
		Vector3 move = new Vector3 (h, 0, 0);
		rb.AddForce (move * 40f);
	}
}
