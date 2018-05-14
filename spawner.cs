using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	public Rigidbody obj;
	Transform tr;
	Rigidbody clone;
	void Start () {
		tr = GetComponent<Transform> ();
		InvokeRepeating ("enemy", 1f, 2f);
	}
	

	void Update () {
		
	}
	void enemy(){
		clone=Instantiate (obj, new Vector3(Random.Range(-2.5f,3.1f),tr.position.y,tr.position.z), tr.rotation);
		Vector3 force = new Vector3 (0,-100f,0);
		clone.AddForce (force);
	}
}
