using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	CharacterController controller;
	Vector3 velocity;
	public float speed 		= 2.0f;
	public float airMove	= 0.2f;
	public float jumpSpeed	= 8.0f;
	public float jumpCount	= 0.0f;
	public float maxJump	= 2.0f;
	public float gravity	= 1.0f;
	public bool inControl 	= true;
	public int health 		= 100;	
	public int rushBar		= 100;
	public int parts		= 0;

	// Use this for initialization
	void Start () {

		controller = GetComponent<CharacterController>();
	}
	// Update is called once per frame
	void Update () {
		// Controls the timing of the
		velocity -= transform.up * gravity;
		// Apply movement all at once
		controller.Move(velocity);

		if(inControl) {
			// Walk forward 
			if(Input.GetKey("s") || (Input.GetKey("right"))) {
				velocity += transform.forward * airMove;
			}
			//walk backward
			if(Input.GetKey("a") || (Input.GetKey("left"))) {
				velocity -= transform.forward * airMove;
			}
			// Code for character movement
			// This componet check to see if the character is grounded
			if(controller.isGrounded) {
				velocity = Vector3.zero;
				// Walk forward 
				if(Input.GetKey("s") || (Input.GetKey("right"))) {
					velocity += transform.forward * 2f;
				}
				// Run foward
				//walk backward
				if(Input.GetKey("a") || (Input.GetKey("left"))) {
					velocity -= transform.forward * 2f;
				}
				// This controls the height of the jump
				if(Input.GetKey("space") || (Input.GetKey("up"))) {
					velocity += transform.up * jumpSpeed;
				}
			}
			else{
				jumpCount = 0.0f;
			}
			if (jumpCount < maxJump) {
			    if (Input.GetKeyDown("space") || (Input.GetKeyDown("up")))  { 
			    	velocity += transform.up * jumpSpeed; 
			    	jumpCount++;
	         	} 
	       }
   		}
	}
	void OnTriggerEnter(Collider other) {

		if(other.tag == "Goal") {

		}
		if(other.tag == "HitD10") {
			health = health -2;
			print(health);
			if(health <=0) {
				inControl = false;
				print("player is dead");
			}
		}
		if(other.tag == "Kill") {
			destroy 
			rushBar = rushBar +10;
			parts = parts +5;
		}
	}
	void OnGUI(){
		GUI.Label(new Rect (25, 25, 100, 30), "Label");
	}
}