using UnityEngine;
using System.Collections;

public class ExitOnClick : MonoBehaviour {

	void OnMouseUpAsButton() {
		Application.Quit();
	}
}
