using UnityEngine;
using System.Collections;

public class constantMovement : MonoBehaviour {

	[SerializeField]
	private float movementSpeed = 5;

	private Transform _transform;

	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3 (0, 0, movementSpeed);

		_transform.localPosition += movement * Time.deltaTime;
	}
}
