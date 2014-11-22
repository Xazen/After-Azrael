using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	[SerializeField]
	private GameObject astroid;
	[SerializeField]
	private float minX = -10;
	[SerializeField]
	private float maxX = 10;
	[SerializeField]
	private float minY = -10;
	[SerializeField]
	private float maxY = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void spawnAstroid(Vector3 playerPosition)
	{
		GameObject astroid = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		Vector3 randomPositon = new Vector3 (Random.Range(minX, maxX), Random.Range(minY, maxY), 100);
		Vector3 spawnPosition = playerPosition + randomPositon;
		astroid.transform.position = spawnPosition;
	}
}
