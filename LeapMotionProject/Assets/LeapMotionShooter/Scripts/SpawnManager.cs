using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	[SerializeField]
	GameObject astroid;
	[SerializeField]
	GameObject sun;
	[SerializeField]
	GameObject mercury;
	[SerializeField]
	GameObject venus;
	[SerializeField]
	GameObject earth;
	[SerializeField]
	float astroidSpawnDistance = 50;
	[SerializeField]
	float spawnRangeX = -25;
	[SerializeField]
	float spawnRangeY = 25;
	


	public void spawnAstroid(Vector3 playerPosition)
	{
		GameObject spawningAstroid = (GameObject)GameObject.Instantiate(astroid);
		Vector3 randomPositon = new Vector3 (Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), astroidSpawnDistance);
		Vector3 spawnPosition = playerPosition + randomPositon;
		spawningAstroid.transform.position = spawnPosition;
	}
}
