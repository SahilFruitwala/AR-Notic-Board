using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class connectDB : MonoBehaviour {

	public GameObject g1;
	public InputField i1,i2;
	public Button b1;
    public static string name1;
    

	// void Start(){
	// 	g1 = GameObject.Find("home1");
	// 	g1.SetActive(false);

	// }

	void Update(){

	}

    


    public void CallRegister()
    {
        StartCoroutine(Registermethod());
        
    }

    private IEnumerator Registermethod()
    {
        
        WWWForm form = new WWWForm();
        form.AddField("name", i1.text);
        form.AddField("password", i2.text);

        WWW www = new WWW("http://192.168.43.45 /sqlconnect/login.php", form);
        yield return www;
        // Debug.Log(www.text);
       	if(www.text == "1")
       	{
           Debug.Log("User Created Successfully");
            //g1.SetActive(true);
            transferscript s1 = new transferscript();
            s1.getdata(i1.text);
            SceneManager.LoadScene(1);
           // UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
        else
        {
            Debug.Log("User Creation Failed. Error # " + www.text);
        }
    }

   

    // public void VerifyInput()
    // {
    //     b1.interactable = (i1.text.Length >= 5 && i2.text.Length >= 5);
    // }
}
