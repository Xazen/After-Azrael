using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	private Transform _transform;

	private Vector3 movementDirection;
	private Vector3 baseSpeed;
	private float movementSpeed = 20f;

	// Use this for initialization
	void Start () {
		this._transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		this._transform.localPosition += (movementDirection * movementSpeed + this.baseSpeed) * Time.deltaTime;
	}


	public void Fire(Vector3 direction, Vector3 baseSpeed) {
		this.movementDirection = direction.normalized;
		this.baseSpeed = baseSpeed;
	}
}
