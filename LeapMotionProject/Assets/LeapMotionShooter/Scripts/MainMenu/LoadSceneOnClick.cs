using UnityEngine;
using System.Collections;

public class LoadSceneOnClick : MonoBehaviour {

	[SerializeField]
	private string sceneName;

	void OnMouseUpAsButton() {
		Application.LoadLevel(this.sceneName);
	}
}
