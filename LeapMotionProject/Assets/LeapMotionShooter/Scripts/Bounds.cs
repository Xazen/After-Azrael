using UnityEngine;
using System.Collections;

public class Bounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		other.SendMessage("BoundsIntersection", SendMessageOptions.DontRequireReceiver);
	}
}
