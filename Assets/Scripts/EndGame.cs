using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
	public int value;
    public bool endGame = false;

    public AudioSource endSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) {

        value = FindObjectOfType<GameManager>().WineReturn();

        if(other.tag == "Player" && value > 0) { // && Input.GetButtonDown("[F]")
      //  //&& Input.GetKeyDown(KeyCode.F)

            Destroy(gameObject);

            endGame = true;

            endSound.Play();


            SceneManager.LoadScene("MainMenu");    

            //Debug.Log(endGame);
            // SceneManager.LoadScene("WinGame");
       }
    }

    public bool IsEnded(){


        return endGame;

    }

    public void IsEnded1(){

        Debug.Log("Success");
    }
    
}
