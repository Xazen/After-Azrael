using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	private bool isShooting;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire")) {
			this.StartShooting();
		}
	}


	public void StartShooting() {
		Debug.Log("Shoting not implemented!");
		this.isShooting = true;
	}

	public void StopShooting() {
		this.isShooting = false;
	}
}
