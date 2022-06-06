using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionDebugger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public float PositionXReturn(){

    	return transform.position.x;
    }

    public float PositionYReturn(){

    	return transform.position.y;
    }

    public float PositionZReturn(){

    	return transform.position.z;
    }
}
