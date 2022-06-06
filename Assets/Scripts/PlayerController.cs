using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float moveSpeed;
	private Rigidbody theRB;
	public float jumpForce;
	public Transform groundCheck;
	public LayerMask Ground;

    // Start is called before the first frame update
    void Start()
    {
    	theRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	
        
    }

    void FixedUpdate(){

        theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded()) {

        	theRB.velocity= new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
        }

    }

    bool IsGrounded() {

    	return Physics.CheckSphere(groundCheck.position, 0.1f, Ground);

    }

    
}
