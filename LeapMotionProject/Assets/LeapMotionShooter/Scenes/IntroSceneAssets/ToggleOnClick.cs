using UnityEngine;
using System.Collections;

public class ToggleOnClick : MonoBehaviour {
	
	[SerializeField]
	private GameObject[] hide;
	[SerializeField]
	private GameObject[] show;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			foreach(GameObject obj in this.hide) {
				obj.SetActive(false);
			}
			foreach(GameObject obj in this.show) {
				obj.SetActive(true);
			}
		}
	}
}
