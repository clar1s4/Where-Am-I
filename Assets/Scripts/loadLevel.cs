using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

// Buat ngeload level yang baru
[RequireComponent(typeof(AudioSource))]
public class loadLevel : MonoBehaviour {

	private bool playerInZone;
	public bool isUnlock = false;
	public string levelToLoad;
	public AudioSource door;
	// Use this for initialization
	void Start () {
		playerInZone = false;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E) && playerInZone && isUnlock)
		{
			
			door.Play ();
			Invoke ("load", 1);
		}
	}

	void load(){
		SceneManager.LoadScene(levelToLoad);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Character")
		{
			playerInZone = true;
		}
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if(other.name == "Character")
		{
			playerInZone = true;
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.name == "Character")
		{
			playerInZone = false;
		}
	}
}