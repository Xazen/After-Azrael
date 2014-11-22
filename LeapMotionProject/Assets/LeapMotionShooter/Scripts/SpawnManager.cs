using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	[SerializeField]
	private GameObject astroid;
	[SerializeField]
	private float astroidSpawnDistance = 50;
	[SerializeField]
	private float spawnRangeX = -25;
	[SerializeField]
	private float spawnRangeY = 25;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void spawnAstroid(Vector3 playerPosition)
	{
		GameObject spawningAstroid = (GameObject)GameObject.Instantiate(astroid);
		Vector3 randomPositon = new Vector3 (Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), astroidSpawnDistance);
		Vector3 spawnPosition = playerPosition + randomPositon;
		spawningAstroid.transform.position = spawnPosition;
	}
}
