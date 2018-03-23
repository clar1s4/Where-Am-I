using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSequence : MonoBehaviour {
	[SerializeField]
	GameObject beam;

	void Start (){
		gameObject.GetComponent<SpriteRenderer>().sprite = beam.GetComponent<SpriteRenderer>().sprite;
	}

	public void OffLaser (){
		gameObject.SetActive (false);
	}
	public void OnLaser (){
		gameObject.SetActive (true);
	}
}
