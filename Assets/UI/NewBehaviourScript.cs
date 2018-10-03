using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject g1,g2,g3;
	// Use this for initialization
	void Start () {
		g1.SetActive(true);
		g2.SetActive(false);
		g3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void homelogin()
    {
    	g2.SetActive(true);
    	g1.SetActive(false);
    	g3.SetActive(false);
    }

    public void homeregister()
    {
    	g3.SetActive(true);
    	g1.SetActive(false);
    	g2.SetActive(false);
    }
}