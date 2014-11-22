using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	private Transform _transform;

	private bool isShooting;

	[SerializeField]
	private GameObject projectilePrefab;

	[SerializeField]
	private float shootDelay = 0.5f;
	private float lastShoot = -1;

	// Use this for initialization
	void Start () {
		this._transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			this.StartShooting();
		}
		if(Input.GetButtonUp("Fire1")) {
			this.StopShooting();
		}

		if(this.isShooting) {
			if(Time.time >= this.lastShoot + this.shootDelay) {
				this.Shoot();
				this.lastShoot = Time.time;
			}
		}
	}


	public void StartShooting() {
		this.isShooting = true;
	}

	public void StopShooting() {
		this.isShooting = false;
	}


	private void Shoot() {
		GameObject projectile = (GameObject) Object.Instantiate(this.projectilePrefab, this._transform.position, Quaternion.identity);

		BulletMovement movement = projectile.GetComponent<BulletMovement>();
		movement.Fire(new Vector3(0,0,1), new Vector3(0,0,30));
	}
}
