using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLaser2 : MonoBehaviour {
	[SerializeField]
	GameObject switch1;

	[SerializeField]
	GameObject switch2;

	public bool left = true;
	public bool inside = false;

	void Start (){
		gameObject.GetComponent<SpriteRenderer>().sprite = switch1.GetComponent<SpriteRenderer>().sprite;
	}

	void Update(){
		if (inside && Input.GetKeyDown(KeyCode.E) && left) {
			GameObject.Find("GameManager").GetComponent<Manager> ().click.Play ();
			gameObject.GetComponent<SpriteRenderer> ().sprite = switch2.GetComponent<SpriteRenderer> ().sprite;
			left = false;
		} else if (inside && Input.GetKeyDown(KeyCode.E) && !left) {
			GameObject.Find("GameManager").GetComponent<Manager> ().click.Play ();
			gameObject.GetComponent<SpriteRenderer> ().sprite = switch1.GetComponent<SpriteRenderer> ().sprite;
			left = true;
		}
		Debug.Log (left);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Character") inside = true;
	}
	void OnTriggerStay2D(Collider2D other){
		if(other.name == "Character")inside = true;
	}
	void OnTriggerExit2D(Collider2D other){
		if(other.name == "Character")inside = false;
	}
}
