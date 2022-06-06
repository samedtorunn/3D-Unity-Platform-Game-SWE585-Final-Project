using UnityEngine;

public class CameraFollow : MonoBehaviour
{


	public Transform target;

	public float smoothSpeed = 0.125f;

	public Vector3 offset;


	void LateUpdate (){

		transform.position = target.position + offset;
         
     
	}


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
      

        if (Input.GetKeyDown("up")) 
         {
             
             transform.position = target.position + offset;

         }
    }

}



