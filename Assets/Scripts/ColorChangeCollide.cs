using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other){
        Vector3 temp = (-1 * other.contacts[0].normal);
        
        if((temp.x ==0.0f) && (temp.y ==1.0f) && (temp.z== 0.0f)){
            Color randomlySelected = GetRandomColor();
            GetComponent<Renderer>().material.color =Color.red;
            Debug.Log("Above");
        }

        else if((temp.x ==1.0f) && (temp.y ==0.0f) && (temp.z== 0.0f)){
            Color randomlySelected = GetRandomColor();
            GetComponent<Renderer>().material.color=Color.blue;
            Debug.Log("Left");
        
        }else if((temp.x ==-1.0f) && (temp.y ==0.0f) && (temp.z== 0.0f)){
            Color randomlySelected = GetRandomColor();
            GetComponent<Renderer>().material.color=Color.green;
            Debug.Log("Right");
        
        }else if((temp.x ==0.0f) && (temp.y ==-1.0f) && (temp.z== 0.0f)){
            Color randomlySelected = GetRandomColor();
            GetComponent<Renderer>().material.color=Color.magenta;
            Debug.Log("Bottom");
        } 
        else if((temp.x ==0.0f) && (temp.y ==0.0f) && (temp.z== 1.0f)){
            Color randomlySelected = GetRandomColor();
            GetComponent<Renderer>().material.color=Color.yellow;
            Debug.Log("Back");
        
        }else if((temp.x ==0.0f) && (temp.y ==0.0f) && (temp.z== -1.0f)){
            Color randomlySelected = GetRandomColor();
            GetComponent<Renderer>().material.color=Color.cyan;
            Debug.Log("Front");
        
        }
        }
        Color GetRandomColor(){
        return new Color(
            UnityEngine.Random.Range(0.2f, 1f),
            UnityEngine.Random.Range(0.2f, 1f),
            UnityEngine.Random.Range(0.2f, 1f));
    }
}