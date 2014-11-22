using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	[SerializeField]
	private GameObject regular;
	[SerializeField]
	private GameObject hover;
	
	void OnMouseEnter() {
		this.regular.SetActive(false);
		this.hover.SetActive(true);
	}
	
	void OnMouseExit() {
		this.regular.SetActive(true);
		this.hover.SetActive(false);
	}
}
