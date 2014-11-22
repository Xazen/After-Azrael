using UnityEngine;
using System.Collections;
using Leap;

// Leap Motion hand script that detects pinches and grabs the
// closest rigidbody with a spring force if it's within a given range.
public class PinchShot : MonoBehaviour {
	
	public const float TRIGGER_DISTANCE_RATIO = 0.7f;
	
	public float forceSpringConstant = 100.0f;
	public float magnetDistance = 2.0f;
	
	protected bool pinching_;
	protected Collider grabbed_;
	
	void Start() {
		pinching_ = false;
		grabbed_ = null;
	}
	
	void OnPinch(Vector3 pinch_position) {

		Debug.Log ("PINCH");
		pinching_ = true;
		

	}
	
	void OnRelease() {
		grabbed_ = null;
		pinching_ = false;
	}
	
	void Update() {
		bool trigger_pinch = false;
		HandModel hand_model = GetComponent<HandModel>();
		Hand leap_hand = hand_model.GetLeapHand();
		
		if (leap_hand == null)
			return;
		
		// Scale trigger distance by thumb proximal bone length.
		Vector leap_thumb_tip = leap_hand.Fingers[0].TipPosition;
		float proximal_length = leap_hand.Fingers[0].Bone(Bone.BoneType.TYPE_PROXIMAL).Length;
		float trigger_distance = proximal_length * TRIGGER_DISTANCE_RATIO;
		
		// Check thumb tip distance to joints on all other fingers.
		// If it's close enough, start pinching.
		for (int i = 1; i < HandModel.NUM_FINGERS && !trigger_pinch; ++i) {
			Finger finger = leap_hand.Fingers[i];
			
			for (int j = 0; j < FingerModel.NUM_BONES && !trigger_pinch; ++j) {
				Vector leap_joint_position = finger.Bone((Bone.BoneType)j).NextJoint;
				if (leap_joint_position.DistanceTo(leap_thumb_tip) < trigger_distance)
					trigger_pinch = true;
			}
		}
		
		Vector3 pinch_position = hand_model.fingers[0].GetTipPosition();
		
		// Only change state if it's different.
		if (trigger_pinch && !pinching_)
			OnPinch(pinch_position);
		else if (!trigger_pinch && pinching_)
			OnRelease();
		
		// Accelerate what we are grabbing toward the pinch.
		if (grabbed_ != null) {
			Vector3 distance = pinch_position - grabbed_.transform.position;
			grabbed_.rigidbody.AddForce(forceSpringConstant * distance);
		}
	}
}

