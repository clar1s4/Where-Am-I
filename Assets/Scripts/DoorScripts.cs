using UnityEngine;
using System.Collections;

public class DoorScripts : MonoBehaviour {
	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}

	void Update () {
		
	}

	public void DoorOpens()
	{
		anim.SetBool ("Open", true);
		anim.SetBool ("Trigger", false);
		anim.SetBool ("Close", false);
	}
	public void DoorTriggers()
	{
		anim.SetBool ("Trigger", true);
		anim.SetBool ("Open", false);
		anim.SetBool ("Close", false);
	}
	public void DoorCloses()
	{
		anim.SetBool ("Close", true);
		anim.SetBool ("Open", false);
		anim.SetBool ("Trigger", false);

	}
	void CollEnable()
	{
		GetComponent<Collider2D>().enabled = true;
	}

	void CollDisable()
	{
		GetComponent<Collider2D>().enabled = false;
	}
}