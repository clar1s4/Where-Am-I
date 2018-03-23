using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDoor : MonoBehaviour {
	[SerializeField]
	GameObject switchOn;

	[SerializeField]
	GameObject switchOff;

	public bool isOn = false;

	void Start (){
		gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
	}


	void OnTriggerStay2D(Collider2D other){
		if(other.name == "Character" && Input.GetKeyDown(KeyCode.E) && !isOn){
			Debug.Log ("true");
			gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;
			GameObject.Find("GameManager").GetComponent<Manager> ().click.Play ();
			isOn = true;
		}
	}
}
