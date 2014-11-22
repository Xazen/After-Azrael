using UnityEngine;
using System.Collections;

public class AstroidCollision : MonoBehaviour {
	
	private PlayerCollision playerCollision;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (player) 
		{
			playerCollision = player.GetComponent<PlayerCollision> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		playerCollision.CollideWithAstroid ();
		Object.Destroy(this.gameObject);
	}
}
