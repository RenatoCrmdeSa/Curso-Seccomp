using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Player : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	Vector3 movement;
	float camRayLength = 100f; 
	int floorMask;
	public GameObject Cam;
	public float turnspeed;
	public Rigidbody Tiro;
	public Rigidbody Enemy;
	// Use this for initialization
	float t;
	void Start () {
		t = Time.time;
		rb = GetComponent<Rigidbody>();

		floorMask = LayerMask.GetMask ("Plane");


	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		move ();
		Turning ();
		Shoot ();
		Inimigo ();
	}


void move(){
	
		float ver = Input.GetAxis ("Vertical");


		
		Vector3 dir = rb.transform.position - Cam.transform.position;

		
		// Normalise the movement vector and make it proportional to the speed per second.
		movement = dir * speed * Time.deltaTime;
		movement.y = 0f;
		if(ver>0){
	rb.MovePosition (transform.position + movement);
		}
		if(ver<0){
			rb.MovePosition (transform.position - movement);
		}

		}

	void Turning ()
	{
		float hor = Input.GetAxis ("Horizontal");

		if (hor>0) {

			transform.Rotate (Vector3.up, speed );
		}
		if (hor<0) {
			
			transform.Rotate (Vector3.up, -speed );
		}
	}


	void Shoot(){
		
		Vector3 dir = rb.transform.position - Cam.transform.position;
		dir = dir * 0.1f;
		Vector3 Point = rb.transform.position+dir;
		if(Input.GetKeyDown("space"))
		{			
			Instantiate(Tiro, Point, Quaternion.identity);

		}
		
		
	}

	void Inimigo(){
		Vector3 pos=rb.transform.position + new Vector3(5f,0f,6f);
		if ((Time.time - t) % 10 == 0) 
		{Instantiate(Enemy,pos,Quaternion.identity);
		}
	
	}


	}
