using UnityEngine;
using System.Collections;

public class ConstantMovement : MonoBehaviour {

	[SerializeField]
	private float movementSpeed = 5;
	[SerializeField]
	private float spawnDistance = 10;
	[SerializeField]
	private SpawnManager spawnManager;

	private Transform _transform;
	private float distance;

	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3 (0, 0, movementSpeed);

		_transform.localPosition += movement * Time.deltaTime;

		distance += movement.z * Time.deltaTime;

		if (distance >= spawnDistance) 
		{
			distance -= spawnDistance;

			if (spawnManager != null)
			{
				spawnManager.spawnAstroid(this.transform.localPosition);
			}
		}
	}
}
