using UnityEngine;
using System.Collections;
[RequireComponent (typeof(Rigidbody2D))]

public class CharacterController : MonoBehaviour {

	public float speed = 2;
	public float jumpForce = 2;
	public float maxSpeed = 8;

	private bool jump = false;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) 
		{
			jump = true;
		}
	}

	void FixedUpdate()
	{
		float h = Input.GetAxis ("Horizontal");

		if (h * rigidbody2D.velocity.x < maxSpeed) 
			rigidbody2D.AddForce (Vector2.right * h * speed);

		if (Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
		    rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);

		if (jump)
		{
			rigidbody2D.AddForce (transform.up * jumpForce);
			jump = false;
		}
	}
}
