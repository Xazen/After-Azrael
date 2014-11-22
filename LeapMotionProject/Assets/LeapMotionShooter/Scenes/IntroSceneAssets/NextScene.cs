using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {

	[SerializeField]
	private string name;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			Application.LoadLevel(this.name);
		}
	}
}
