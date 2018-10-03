using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonDance : MonoBehaviour,IVirtualButtonEventHandler{

    public GameObject cube;
    VirtualButtonBehaviour vrb;

	// Use this for initialization
	void Start () {
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);
        cube.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
        throw new System.NotImplementedException();
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
        throw new System.NotImplementedException();
    }
}
