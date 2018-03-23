using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	[SerializeField]
	GameObject switchstate;

	[SerializeField]
	GameObject laserstate1;

	[SerializeField]
	GameObject laserstate2;

	[SerializeField]
	GameObject laserstateX;

	[SerializeField]
	GameObject exitDoor;

	[SerializeField]
	GameObject laser1;

	[SerializeField]
	GameObject laser2;

	[SerializeField]
	GameObject laserX1;

	[SerializeField]
	GameObject laserX2;

	[SerializeField]
	public AudioSource liftup;

	[SerializeField]
	public AudioSource liftopen;

	[SerializeField]
	public AudioSource click;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (switchstate != null && switchstate.GetComponent<SwitchDoor> ().isOn) {
			exitDoor.GetComponent<ExitSequence> ().OpenDoor ();
			exitDoor.GetComponent<loadLevel> ().isUnlock = true;
			Debug.Log("unlock");
		}

		if (laserstateX != null && laserstateX.GetComponent<SwitchLaser2> ().left == false) {
			laserX1.GetComponent<LaserSequence> ().OffLaser ();
			laserX2.GetComponent<LaserSequence> ().OnLaser ();
			Debug.Log ("laser 1");
		} else if (laserstateX != null && laserstateX.GetComponent<SwitchLaser2> ().left == true) {
			laserX1.GetComponent<LaserSequence> ().OnLaser ();
			laserX2.GetComponent<LaserSequence> ().OffLaser ();
			Debug.Log ("laser 2");
		} 

		if (laserstate1 != null && laserstate1.GetComponent<SwitchLaser1> ().isOn  == false) {
			laser1.GetComponent<LaserSequence> ().OffLaser ();
			Debug.Log ("laser 1 mati");
		}
		if (laserstate2 != null && laserstate2.GetComponent<SwitchLaser1> ().isOn  == false){
			laser2.GetComponent<LaserSequence> ().OffLaser ();
			Debug.Log ("laser 1 mati");
		}
	}
}
