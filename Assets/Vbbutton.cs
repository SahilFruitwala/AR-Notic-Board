using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vbbutton : MonoBehaviour {

    

    
	// Use this for initialization
	void Start () {
        transferscript s1 = new transferscript();
        string data = s1.setdata();
        Debug.Log(data);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void clickbutton()
    {
        transferscript n1 = new transferscript();
        n1.setdata();
        SceneManager.LoadScene(2);
    }
    public void clickbutton2()
    {
        SceneManager.LoadScene(3);
    }

    public void backButton()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 | SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(1);
        }
    }
}
