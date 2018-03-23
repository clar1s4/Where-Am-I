using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLaser1 : MonoBehaviour {
	[SerializeField]
	GameObject switchOn;

	[SerializeField]
	GameObject switchOff;

	public bool isOn = true;

	void Start (){
		gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;
	}


	void OnTriggerStay2D(Collider2D other){
		if(other.name == "Character" && Input.GetKeyDown(KeyCode.E) && isOn){
			gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
			GameObject.Find("GameManager").GetComponent<Manager> ().click.Play ();
			isOn = false;
		}
	}
}
