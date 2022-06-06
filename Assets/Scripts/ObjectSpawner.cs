using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

	public int wine;
	public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        wine = FindObjectOfType<GameManager>().WineReturn(); 
    }

    /*
    public void spawnCube(){

    	if(wine == 15){


    	}

    }
    */
}
