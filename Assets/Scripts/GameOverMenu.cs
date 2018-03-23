using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour {
	public string mainMenu,currentLevel;
	public bool isDead;
	public GameObject gameOverCanvas;

	void Start(){
		isDead = false;
	}
	void Update () {
		if (isDead) {
			gameOverCanvas.SetActive (true);
		} else {
			gameOverCanvas.SetActive (false);
		}

	}
		
	public void MainMenu(){
		SceneManager.LoadScene (mainMenu);
	}

	public void Load(){
		SceneManager.LoadScene (currentLevel);
	}
}
