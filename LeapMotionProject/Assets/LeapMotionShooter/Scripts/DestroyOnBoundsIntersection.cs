using UnityEngine;
using System.Collections;

public class DestroyOnBoundsIntersection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void BoundsIntersection() {
		Object.Destroy(this.gameObject);
	}
}
