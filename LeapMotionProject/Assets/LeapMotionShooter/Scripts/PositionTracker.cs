using UnityEngine;
using System.Collections;
using Leap;

public class PositionTracker : MonoBehaviour {
	
	//	GameObject shipController;


	private Vector position;
	Hand hand;
	
	Frame frame;

	[SerializeField]
	private Transform shipTransform;

	private GameObject playerBasePosition;
	private GameObject shipController;

	private Vector3 lastPosition;

	
	void Start () {
		playerBasePosition = GameObject.Find("PlayerBasePosition");
		shipController = GameObject.Find("ShipController");
	}
	

	void Update () {
		Controller controller = new Controller ();
		
		Frame frame = controller.Frame ();
		HandList hands = frame.Hands;
		Hand leap_hand = hands[0];
		PointableList pointables = frame.Pointables;
		FingerList fingers = frame.Fingers;
		ToolList tools = frame.Tools;
		
		if (leap_hand == null || playerBasePosition ==null){
			shipTransform.localPosition = lastPosition;
		} 
		else 
		{
			Quaternion direction = leap_hand.Fingers[1].Bone(Bone.BoneType.TYPE_DISTAL).Basis.Rotation();		
			Quaternion directionCorrected = direction * Quaternion.Euler(35, 0, 0); 


			shipTransform.localPosition = shipController.transform.TransformPoint(leap_hand.PalmPosition.ToUnityScaled());

			directionCorrected.x = 0f;
			directionCorrected.y = 0f;



			shipTransform.rotation = directionCorrected;
		

			lastPosition = shipTransform.localPosition;

		}

//		Debug.Log (shipTransform.localPosition);
	}
}
