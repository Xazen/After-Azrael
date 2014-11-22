using UnityEngine;
using System.Collections;

public class AstroidCollision : MonoBehaviour {
	
	private PlayerCollision playerCollision;

	// Use this for initialization
	void Start () {
		playerCollision = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerCollision>();
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
