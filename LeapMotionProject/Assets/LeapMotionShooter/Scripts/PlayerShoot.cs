using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	private bool isShooting;

	[SerializeField]
	private GameObject projectilePrefab;

	[SerializeField]
	private float shootDelay;
	private float lastShoot = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			this.StartShooting();
		}

		if(this.isShooting) {
			if(Time.time >= this.lastShoot + this.shootDelay) {
				this.Shoot();
				this.lastShoot = Time.time;
			}
		}
	}


	public void StartShooting() {
		Debug.Log("Shoting not implemented!");
		this.isShooting = true;
	}

	public void StopShooting() {
		this.isShooting = false;
	}


	private void Shoot() {
		GameObject projectile = (GameObject) Object.Instantiate(this.projectilePrefab);

		BulletMovement movement = projectile.GetComponent<BulletMovement>();
		movement.Fire(Vector3.zero, new Vector3(0,0,20));
	}
}
