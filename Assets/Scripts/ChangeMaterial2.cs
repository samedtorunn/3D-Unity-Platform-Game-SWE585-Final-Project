using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial2 : MonoBehaviour
{


	public Material[] material;
	public Renderer rend;
	//public GameManager x;
    public int wine;


	//public int c;
	


    // Start is called before the first frame update
    void Start()

    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
    	


    }

    void FixedUpdate() {

        wine = FindObjectOfType<GameManager>().WineReturn(); 

        //Debug.Log(wine);

            rend.sharedMaterial = material[0];
        

    }

    /*    
    public void OnCollisionEnter(Collision col){

    	if (col.gameObject.tag == "Player" ) {

    		rend.sharedMaterial = material[1];
    	}

    	else {

    		rend.sharedMaterial = material[2];
    	}
    }*/
    

    /*
    public void Changer(){



    	if(c > 10 && c < 20 ){



    	rend.sharedMaterial = material[1];

    	}

    	else {

    		rend.sharedMaterial = material[2];

    	}


    }
    */


    /*
    	x = GameObject.FindGameObjectWithTag("Wine").GetComponent<GameManager>();

    	c =  x.WineReturn();

    	Debug.Log(c);

        if( x.WineReturn() > 10 && x.WineReturn() < 20) {

    	rend.sharedMaterial = material[1];

    	}
    	*/
}
