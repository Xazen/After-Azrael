using UnityEngine;
using System.Collections;

public class MotionLine : MonoBehaviour {

	[SerializeField]
	private float speed = 0.5f;

	// Use this for initialization
	void Start () {
		Animator animation = GetComponent<Animator> ();
		animation.speed = speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
