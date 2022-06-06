using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abc : MonoBehaviour
{
	//public Transform Spawnpoint;
	public GameObject Prefab;
	public int wine;
    public PositionDebugger pos;
    public float x;
    public float y;
    public float z;
    public int i;
    public Vector3[] test;
    public int a = 0;
    public GameObject[] floors;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other){

    		//Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);



        if(other.tag == "Player") {
        
            for (int i = 0; i<28; i++){

                Instantiate(floors[i], new Vector3(floors[i].transform.position.x -0.2f, floors[i].transform.position.y +1.0f, floors[i].transform.position.z +1.0f), Quaternion.identity);

                /*
                if(x-floors[i].transform.position.x > 5){

                    Destroy(floors[i]);

                    Debug.Log("Object " + i +  " Destroyed");
                }
                */
            }

        }
         
    }

    // Update is called once per frame
    void Update()
    {

        x = FindObjectOfType<PositionDebugger>().PositionXReturn();
        y = FindObjectOfType<PositionDebugger>().PositionYReturn();
        z = FindObjectOfType<PositionDebugger>().PositionZReturn();

        /*for (int i = 0; i < 19; i++) {
            floors[i] = GameObject.FindGameObjectWithTag("MainFloor").transform.position;

        }*/

        // List<GameObject> players = new List<GameObject>( GameObject.FindGameObjectsWithTag("MainFloor")) ;

    }
}
