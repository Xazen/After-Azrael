using UnityEngine;
using System.Collections;
using Leap;


public class PinchShot : MonoBehaviour {

	PlayerShoot playerShoot;
	
	public const float TRIGGER_DISTANCE_RATIO = 0.7f;
	[SerializeField]
	private float forceSpringConstant = 100.0f;

	[SerializeField]
	private float magnetDistance = 2.0f;


	void Start(){
		playerShoot = GameObject.Find ("player").GetComponent<PlayerShoot> ();
	}

	void Update() {

		HandModel hand_model = GetComponent<HandModel>();

		Controller controller = new Controller ();
		
		Frame frame = controller.Frame ();
		HandList hands = frame.Hands;
		Hand leap_hand = hands[0];
		
		if (leap_hand == null)
			return;

		Vector leap_thumb_tip = leap_hand.Fingers[0].TipPosition;
		Vector leap_index_tip = leap_hand.Fingers[1].TipPosition;

		float trigger_distance = (leap_thumb_tip - leap_index_tip).Magnitude;

//		Debug.Log(trigger_distance);


		if (trigger_distance != 0 && trigger_distance < 60) {
			playerShoot.StartShooting();
		} else {
			playerShoot.StopShooting();
		}
	}
}

