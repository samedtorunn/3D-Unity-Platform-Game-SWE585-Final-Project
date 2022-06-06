using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
	public int intScore1;
	public float score1;
	public float score2;
	public bool isScoreEnded;
	public float timeValue;
	public TheTimer timeScore;
	public float totalScore;

	public bool endGame; // oyun devam mı değil mi?

    // Start is called before the first frame update
    void Start()
    {
    	timeValue = FindObjectOfType<TheTimer>().TimeValueReturner();
        
    }

    // Update is called once per frame
    void Update()
    {

    	endGame = FindObjectOfType<EndGame>().IsEnded();

        timeValue = FindObjectOfType<TheTimer>().TimeValueReturner();

		intScore1 = FindObjectOfType<GameManager>().WineReturn();  

		score1 = (float)intScore1;
        score2 = timeValue;
              
        totalScore = 2 * score2 + (score1 * score2/100);
        //Debug.Log(totalScore);

        ScoreReturner();
    }

   
   public float ScoreReturner() {
    
   		return totalScore;

    }


    
}
