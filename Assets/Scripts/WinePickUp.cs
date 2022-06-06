using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinePickUp : MonoBehaviour
{

	public int value;



    public AudioSource wineSound;

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
        
        

    }

    public void OnTriggerEnter(Collider other) {


    	if(other.tag == "Player") { // && Input.GetButtonDown("[F]")
      //  //&& Input.GetKeyDown(KeyCode.F)

    		FindObjectOfType<GameManager>().AddWine(value);

            Destroy(gameObject);
            
            wineSound.Play();

    	

    	}
     }

    /* 
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody == true && other.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {

            FindObjectOfType<GameManager>().AddGold(value);

            // wineSound.Play();

            Destroy(gameObject);
        }
    }
    */
}