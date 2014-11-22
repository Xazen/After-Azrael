using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	[SerializeField]
	private int hitPoints = 100;
	
	[SerializeField]
	private AudioClip deathSound;

	[SerializeField]
	private AudioClip takeDamage;

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
		if(this.takeDamage != null && this.audio != null) {
			this.audio.PlayOneShot(this.takeDamage);
		}

		if (hitPoints <= 0) 
		{
			if(this.deathSound != null && this.audio != null) {
				this.audio.PlayOneShot(this.deathSound);
			}

			Object.Destroy(player);

		}
	}
}
