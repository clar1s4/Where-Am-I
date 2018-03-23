using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpDoor : MonoBehaviour {

	public GameObject player;
	public Transform target;


	void Start () {
		
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.name == "Character" && Input.GetKeyDown(KeyCode.E))
		{
			GameObject.Find("GameManager").GetComponent<Manager> ().liftup.Play ();
			Invoke ("Warp", 1);
			Invoke ("liftopensound", 1.2f);
		}
	}
	void liftopensound() {
		GameObject.Find("GameManager").GetComponent<Manager> ().liftopen.Play ();
	}
		
	void Warp(){
		target.GetComponent<DoorScripts> ().DoorOpens ();
		player.transform.position = target.transform.position;
	}

}
