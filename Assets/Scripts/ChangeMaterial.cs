using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
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

        if(wine == 0){

            rend.sharedMaterial = material[0];
        } 

        else if(wine == 15){

            rend.sharedMaterial = material[1];
        } 

        else if(wine == 30){

            rend.sharedMaterial = material[2];
        } 

        else if(wine == 45){

            rend.sharedMaterial = material[3];
        } 

        else if(wine == 60){

            rend.sharedMaterial = material[4];
        } 

        else if(wine == 75){

            rend.sharedMaterial = material[5];
        } 

        else if(wine == 90){

            rend.sharedMaterial = material[6];
        } 

        else if(wine == 105){

            rend.sharedMaterial = material[7];
        } 

        else if(wine == 120){

            rend.sharedMaterial = material[8];
        } 

        else if(wine == 135){

            rend.sharedMaterial = material[9];
        } 

        else if(wine == 150){

            rend.sharedMaterial = material[10];
        } 

        else if(wine == 165){

            rend.sharedMaterial = material[11];
        } 

        else if(wine == 180){

            rend.sharedMaterial = material[12];
        } 

        else if(wine == 195){

            rend.sharedMaterial = material[13];
        } 

        else if(wine == 210){

            rend.sharedMaterial = material[14];
        } 

        else if(wine == 225){

            rend.sharedMaterial = material[15];
        } 

        else if(wine == 240){

            rend.sharedMaterial = material[16];
        } 

        else if(wine == 255){

            rend.sharedMaterial = material[17];
        } 

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
