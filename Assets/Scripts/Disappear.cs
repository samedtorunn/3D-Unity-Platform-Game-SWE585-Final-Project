using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{

	int lifeTime = 4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitThenDie());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 	IEnumerator WaitThenDie()
 	{
    	 yield return new WaitForSeconds(lifeTime);
     	Destroy(gameObject);
 	}

 }