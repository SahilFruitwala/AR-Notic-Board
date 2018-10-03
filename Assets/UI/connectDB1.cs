using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class connectDB1 : MonoBehaviour {

	public InputField i1,i2,i3,i4,i5,i6,i7,i8;
	public Button b1;

	public void CallRegister()
    {
        StartCoroutine(Registermethod());
    }

    private IEnumerator Registermethod()
    {
        WWWForm form = new WWWForm();
        form.AddField("enrollment", i1.text);
        form.AddField("fname", i2.text);
        form.AddField("lname", i3.text);
        form.AddField("phone", i4.text);
        form.AddField("email", i5.text);
        form.AddField("branch", i6.text);
        form.AddField("year", i7.text);
        form.AddField("password", i8.text);

        WWW www = new WWW("http://192.168.43.45/sqlconnect/registerUser.php", form);
        yield return www;
        Debug.Log(www.text);
      
            Debug.Log("User Created Successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    
    }

}
