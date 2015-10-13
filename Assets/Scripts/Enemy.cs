using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	Transform P;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		P = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		move ();
	}


	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Tiro")) {
			rb.gameObject.SetActive(false);

		}



	}
void move(){


		Vector3 direction = P.transform.position - rb.transform.position;
		direction.y = 0;
	
		rb.MovePosition (transform.position + (direction*speed*Time.deltaTime));

	}
}
