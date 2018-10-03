using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playVideo : MonoBehaviour {
    public GameObject container;
    public bool play=false;

    // Use this for initialization
    void Start()
    {
        container = GameObject.Find("Container");
        container.SetActive(false);
    }	

    public void btn()
    {
        
        Debug.Log("Inside BTN");
        if(!play)
        { 
            container.SetActive(true);
            play = true;
        }
        else
        { 
            container.SetActive(false);
            play = false;
        }
    }
}
