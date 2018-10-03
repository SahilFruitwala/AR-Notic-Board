using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class register_user2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static string name1;

    public void CallRegister()
    {

        transferscript s1 = new transferscript();
        name1 = s1.setdata();
        StartCoroutine(Registermethod());
     
    }

    private IEnumerator Registermethod()
    {
        Debug.Log("Inserting event");
        WWWForm form = new WWWForm();
        form.AddField("enrollment", name1);
        form.AddField("event", "2Dance");

        WWW www = new WWW("http://192.168.43.45/sqlconnect/registerEvent.php", form);
        yield return www;
        // Debug.Log(www.text);
        
        
            Debug.Log("User Created Successfully");
            //g1.SetActive(true);
            SceneManager.LoadScene(1);
            // UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        
     
        
      
        
    }
}
