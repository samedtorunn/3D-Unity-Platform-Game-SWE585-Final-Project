using UnityEngine;

public class ObjectFollow : MonoBehaviour
{


	public Transform target;

	public float smoothSpeed = 0.125f;

	public Vector3 offset;

    public int wine;

    public float x_Player;
    public float y_Player;
    public float z_Player;

    public bool valueTaken = false;
    public bool valueTaken2 = false;
    public bool valueTaken3 = false;
    public bool valueTaken4 = false;
    public bool valueTaken5 = false;
    public bool valueTaken6= false;
    public bool valueTaken7 = false;
    public bool valueTaken8 = false;
    public bool valueTaken9 = false;
    public bool valueTaken10 = false;
    public bool valueTaken11 = false;
    public bool valueTaken12 = false;
    public bool valueTaken13 = false;
    public bool valueTaken14 = false;
    public bool valueTaken15 = false;



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


        

        

        wine = FindObjectOfType<GameManager>().WineReturn(); 

        if(wine>10 && !valueTaken){

            offset.x = Random.Range(-0.2f, 0.2f);
            offset.y = Random.Range(0.0f, 0.1f);
            offset.z = Random.Range(0.0f, -0.1f);

            valueTaken = true;
        }

        if(wine>30 && !valueTaken2){

            offset.x = Random.Range(-0.4f, 0.4f);
            offset.y = Random.Range(0.0f, -0.1f);
            offset.z = Random.Range(0.0f, 0.1f);

            valueTaken2 = true;
        }

        if(wine>44 && !valueTaken3){

            offset.x = Random.Range(-0.6f, 0.6f);
            offset.y = Random.Range(0.0f, -0.1f);
            offset.z = Random.Range(0.0f, 0.1f);

            valueTaken3 = true;
        }

        if(wine>59 && !valueTaken4){

            offset.x = Random.Range(-0.8f, 0.8f);
            offset.y = Random.Range(0.0f, -0.2f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken4 = true;
        }

        if(wine>74 && !valueTaken5){

            offset.x = Random.Range(-1.0f, 1.0f);
            offset.y = Random.Range(0.0f, -0.2f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken5 = true;
        }

        if(wine>89 && !valueTaken6){

            offset.x = Random.Range(-1.2f, 1.2f);
            offset.y = Random.Range(0.0f, -0.2f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken6 = true;
        }

        if(wine>=105 && !valueTaken7){

            offset.x = Random.Range(-1.4f, 1.4f);
            offset.y = Random.Range(0.0f, -0.3f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken7 = true;
        }

        if(wine>=105 && !valueTaken8){

            offset.x = Random.Range(-1.6f, 1.6f);
            offset.y = Random.Range(0.0f, -0.3f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken8 = true;
        }

        if(wine>=120 && !valueTaken9){

            offset.x = Random.Range(-1.8f, 1.8f);
            offset.y = Random.Range(0.0f, -0.3f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken9 = true;
        }

        if(wine>=135 && !valueTaken10){

            offset.x = Random.Range(-2.0f, 2.0f);
            offset.y = Random.Range(0.0f, -0.4f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken10 = true;
        }

        if(wine>=150 && !valueTaken11){

            offset.x = Random.Range(-2.4f, 2.4f);
            offset.y = Random.Range(0.0f, -0.6f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken11 = true;
        }

        if(wine>=165 && !valueTaken12){

            offset.x = Random.Range(-2.8f, 2.8f);
            offset.y = Random.Range(0.0f, -1.0f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken12 = true;
        }

        if(wine>=180 && !valueTaken13){

            offset.x = Random.Range(-3.3f, 3.3f);
            offset.y = Random.Range(0.0f, -1.2f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken13 = true;
        }

        if(wine>=195 && !valueTaken14){

            offset.x = Random.Range(-4.0f, 4f);
            offset.y = Random.Range(0.0f, -1.4f);
            offset.z = Random.Range(0.0f, 0.2f);

            valueTaken14 = true;
        }


        
               
        z_Player = FindObjectOfType<PositionDebugger>().PositionZReturn();


        
        if(z_Player-transform.position.z > 5){

                    
            Destroy(gameObject);        

        
        }
    }

    /*
    void FixedUpdate()
    {
      

        if (Input.GetKeyDown("up")) 
         {
             
             transform.position = target.position + offset;

         }
    }
    */

}



