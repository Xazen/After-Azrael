using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire")) {
			this.Shoot();
		}
	}


	public void Shoot() {
		Debug.Log("Shoting not implemented!");
	}
}
