using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullscreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		setfullscreen ();
	}
	
	// Update is called once per frame
	void Update () {
		setfullscreen ();
	}

	void setfullscreen(){
		Screen.fullScreen = true;
	}
}
