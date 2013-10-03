using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	CharacterController controller;
	Vector3 velocity;
	public float speed 		= 1.0f;
	public float airMove	= 1.0f;
	public float jumpSpeed	= 1.0f;
	public float jumpCount	= 0.0f;
	public float maxJump	= 2.0f;
	public float gravity	= 1.0f;

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
			if(Input.GetKey("a") || (Input.GetKey("left"))) {
				velocity += transform.forward * 2f;
			}
			// Run foward
			//walk backward
			if(Input.GetKey("s") || (Input.GetKey("right"))) {
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