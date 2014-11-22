using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	[SerializeField]
	private int hitPoints = 100;

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void damaged(int damage)
	{
		hitPoints -= damage;
		if (hitPoints <= 0) 
		{
			Object.Destroy(player);
		}
	}
}
