using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
	
	private PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {
		playerHealth = this.gameObject.GetComponent<PlayerHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CollideWithAstroid()
	{
		Debug.Log ("collide with astroid");
		playerHealth.damaged (10);


	}
}
