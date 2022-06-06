using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	public int currentWine;
	public Text wineText;
    public Text scoreText;
    public Material wineMaterial;
    public float score;
    public ScoreBoard scoreBoard;
    public float totalScore;

    public bool endGame;

    public string totalRounded;

     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        endGame = FindObjectOfType<EndGame>().IsEnded();

        WineReturn();

        totalScore = FindObjectOfType<ScoreBoard>().ScoreReturner();

        score = totalScore;

        DisplayScore(totalScore);

        /*

        if(endGame == true){

            //Debug.Log(endGame);

            scoreText.text = "Score: " + score + " points!"; 
        }

        else if(endGame == false) {

            scoreText.text = "Go faster";
            //Debug.Log(endGame);
        }
        */

        
    }

    public void AddWine(int wineToDrink) {

    	currentWine = currentWine + wineToDrink;

        wineText.text = "Wine Drunk: " + currentWine + " cl"; 

    }

    public int WineReturn(){
        return currentWine;
    }

    void DisplayScore(float scoreToDisplay){


        totalRounded = scoreToDisplay.ToString("#.00");

        scoreText.text = "Score: " + totalRounded + " points!"; 


    }

}
