using UnityEngine;
using System.Collections;

public class ConstantMovement : MonoBehaviour {

	[SerializeField]
	float movementSpeed = 5;
	[SerializeField]
	float spawnDistance = 10;
	[SerializeField]
	SpawnManager spawnManager;

	Transform transform;
	float distance;
	
	void Start () {
		transform = GetComponent<Transform>();
	}

	void Update () {
		Vector3 movement = new Vector3 (0, 0, movementSpeed);

		transform.localPosition += movement * Time.deltaTime;

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
