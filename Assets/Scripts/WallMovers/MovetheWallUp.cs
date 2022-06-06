using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class MovetheWallUp : MonoBehaviour
{


    public bool rightway = true;
    public bool waiter = false;

    public int hardness;

    

    


    public Vector3 positionRight = new Vector3(0.0f,8.0f,0);
    public Vector3 positionLeft = new Vector3(0.0f,4.0f,0);



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {   

        if(rightway == true && waiter == false)
        {
        
            if(hardness > 0){
                transform.Translate(Vector3.up * Time.deltaTime * 2 * hardness);
            }

            else {
                transform.Translate(Vector3.up * Time.deltaTime * 2 * 2);
            }
        }
             
        

        if(rightway == false && waiter == false){


            if(hardness > 0){
                transform.Translate(Vector3.down * Time.deltaTime * 2 * hardness);
            }

            else {
                transform.Translate(Vector3.down * Time.deltaTime * 2 * 4);
            }
        }



        if(transform.position.y >= 16.0f) {
            waiter = true;
            transform.position = new Vector3(transform.position.x, 15.9f, transform.position.z);
            rightway = false;   
            StartCoroutine(moveIt());
        }

        

        if(transform.position.y <= 4.0f) {
                waiter = true;
                transform.position = new Vector3(transform.position.x, 4.1f, transform.position.z);
                rightway = true;     
                StartCoroutine(moveIt());  
            }
    }

    IEnumerator moveIt() {

        if(hardness > 3){
    	   yield return new WaitForSeconds(Random.Range(1,5));	
            waiter = false;
        }

        else
            yield return new WaitForSeconds(Random.Range(1,5)); 
            waiter = false;
    }

}

