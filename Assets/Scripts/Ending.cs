using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ending : MonoBehaviour {
	public string mainMenu;
	public GameObject endingCanvas;

	void Start(){
		endingCanvas.SetActive (true);
	}

	void Update () {

	}

	public void MainMenu(){
		SceneManager.LoadScene (mainMenu);
	}
	public void Quit(){
		Application.Quit ();
	}
}
