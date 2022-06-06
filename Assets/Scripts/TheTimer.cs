using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheTimer : MonoBehaviour
{

	public float timeValue = 30;
	public Text timerText;
    public bool timerIsRunning;
    public bool endGame;
    public GameObject _gameObject; //= GameObject.FindGameObjectsWithTag("Finish");


    void Start(){
        
        //_EnderScript = GetComponent<EndGame>();

        //_EnderScript.IsEnded1();

        //_EnderScript.IsEnded1();

        timerIsRunning = true;
    }   

    void FixedUpdate()
    {
    

    endGame = FindObjectOfType<EndGame>().IsEnded();

    if(endGame == false){   


       if(timeValue > 0){ //&& timerIsRunning == true){
            
    		timeValue -= Time.deltaTime;
    	      
        }

    	else {

            timeValue = 0;

            //timerIsRunning = false;

            //Debug.Log("Oh fuck!");
            }

        }

    DisplayTime(timeValue);	
        
    }

    void DisplayTime(float timeToDisplay){

    	if(timeToDisplay < 0){

    		timeToDisplay = 0;
    	}

    	float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    	float seconds = Mathf.FloorToInt(timeToDisplay % 60);

    	timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    public float TimeValueReturner()
    {
        return timeValue;

    }

    

}
