using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	public DoorScripts door;
	public bool ignoreTrigger;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (ignoreTrigger)
			return;
		if (other.name == "Character")
			door.DoorTriggers ();
		}

	void OnTriggerStay2D(Collider2D other)
	{
		if (ignoreTrigger)
			return;
		if(other.name == "Character" && Input.GetKeyDown(KeyCode.E))
			door.DoorOpens ();
	}

	void OnTriggerExit2D(Collider2D other){
		if (ignoreTrigger)
			return;
		if (other.name == "Character")
			door.DoorCloses();
	}

	void Toggle(bool state)
	{
		if (state)
			door.DoorTriggers ();
		else
			door.DoorCloses ();
	}

	void OnDrawGizmos()
	{
		if (!ignoreTrigger) {
			BoxCollider2D box = GetComponent<BoxCollider2D> ();
			Gizmos.DrawWireCube (transform.position, new Vector2 (box.size.x, box.size.y));
		}
	}
}

