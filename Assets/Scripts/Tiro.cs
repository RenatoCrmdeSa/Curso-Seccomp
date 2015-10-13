using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {
	public Rigidbody tiro;

	public  Camera main;



	// Use this for initialization
	void Start () {
	Vector3 dir = tiro.transform.position - Camera.main.transform.position;
		tiro.AddForce (dir * 300);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
