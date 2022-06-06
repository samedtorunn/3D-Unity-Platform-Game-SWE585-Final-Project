using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

	public float moveSpeed;
    public float moveSpeedX;
	private Rigidbody theRB;
	public float jumpForce;
	public Transform groundCheck;
	public LayerMask Ground;
    public int wine;

    // Start is called before the first frame update
    void Start()
    {
    	theRB = GetComponent<Rigidbody>();

        moveSpeedX = 7;

        
    }

    // Update is called once per frame
    void Update()
    {
    	
        
    }

    void FixedUpdate(){

        Drunker();

        theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeedX, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded()) {

        	theRB.velocity= new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
        }

    }

    bool IsGrounded() {

    	return Physics.CheckSphere(groundCheck.position, 0.1f, Ground);

    }

    public void Drunker(){

        wine = FindObjectOfType<GameManager>().WineReturn(); 

        //Debug.Log(wine);

        if(wine == 0){

            moveSpeedX = 25*7/25;

        } 

        else if(wine == 15){

            moveSpeedX = 25*7/25;
        } 

        else if(wine == 30){

            moveSpeedX = 24*7/25;
        } 

        else if(wine == 45){

            moveSpeedX = 23*7/25;
        } 

        else if(wine == 60){

            moveSpeedX = 22*7/25;
        } 

        else if(wine == 75){

            moveSpeedX = 21*7/25;
        } 

        else if(wine == 90){

            moveSpeedX = 20*7/25;
        } 

        else if(wine == 105){

            moveSpeedX = 19*7/25;
        } 

        else if(wine == 120){

            moveSpeedX = 18*7/25;
        } 

        else if(wine == 135){

            moveSpeedX = 17*7/25;
        } 

        else if(wine == 150){

            moveSpeedX = 16*7/25;
        } 

        else if(wine == 165){

            moveSpeedX = 15*7/25;
        } 

        else if(wine == 180){

            moveSpeedX = 14*7/25;
        } 

        else if(wine == 195){

            moveSpeedX = 13*7/25;
        } 

        else if(wine == 210){

            moveSpeedX = 12*7/25;
        } 

        else if(wine == 225){

            moveSpeedX = 11*7/25;
        } 

        else if(wine == 240){

            moveSpeedX = 10*7/25;
        } 

        else if(wine == 255){

            moveSpeedX = 6*7/25;
        } 
    }

    /*
    IEnumerator Delayer()  //  <-  its a standalone method
    {

     yield return new WaitForSeconds(lifeTime);

    }
    */

    
}
