using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

	Animator animator;
	int isWalkingHash;
	int isJumpingHash;
	public Transform groundCheck;
	public LayerMask Ground;
	

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isJumpingHash = Animator.StringToHash("isJumping");
    }

    // Update is called once per frame
    void Update()
    {

    	bool isWalking = animator.GetBool(isWalkingHash);
    	bool isJumping = animator.GetBool(isJumpingHash);

    	bool forwardPressed = Input.GetKey("up");
    	bool jumpPressed = Input.GetKey("space");


    	if(!isWalking && forwardPressed){

    		animator.SetBool(isWalkingHash, true);
    	}

    	if(isWalking && !forwardPressed){

    		animator.SetBool(isWalkingHash, false);
    	}

    	if(jumpPressed){

    		animator.SetBool(isJumpingHash, true);
    	}

    	if(!jumpPressed){

    		animator.SetBool(isJumpingHash, false);
    	}
        
    }
}
