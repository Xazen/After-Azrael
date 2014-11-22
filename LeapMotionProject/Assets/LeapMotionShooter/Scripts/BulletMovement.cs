using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	private Transform _transform;

	private Vector3 movementDirection;
	private float movementSpeed = 20f;

	// Use this for initialization
	void Start () {
		this._transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		this._transform.localPosition += movementDirection * movementSpeed * Time.deltaTime;
	}


	private void Fire(Vector3 direction) {
		this.movementDirection = direction.normalized;
	}
}
