using UnityEngine;
using System.Collections;

public class Platformer : MonoBehaviour {
	
	public float playerSpeed = 2f);
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if ( Input.GetKeyDown ( KeyCode.LeftArrow)) {
			rigidbody.AddRelativeForce ( Vector3.left * playerSpeed );
		}
		
		if ( Input.GetKeyDown ( KeyCode.RightArrow)) {
			rigidbody.AddForce ( Vector3,right * playerSpeed ) ;
		}
		
		if (Input.GetKeyDown ( KeyCode.UpArrow)) {
			rigidbody.AddRelativeForce (Vector3.forward * playerSpeed );
		}
		
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			rigidbody.AddRelativeForce (Vector3.back * playerSpeed);
		
		}
		
		if (Input.GetKeyDown
		
		if (Input.GetKeyDown ( KeyCode.Space)) {
			rigidbody.
			
		
// basic movement
//	if ( player pushes left arrow )
//	AddForce (left);
//	if ( player pushes right arrow )
//	AddForce (right);
// if you haven't already, TEST, with just basic movement coded in!
// jump, but only if player is on the ground
//	if ( player pushes spacebar ) {
// detect if player is grounded by raycasting downwards just past feet
// note: raycast from CENTER, so it won't hit inside of capsule
//	if ( Raycast( from center of player, downwards, right below feet ) ) {
//	AddForce ( up );
		
		
		
	}
}
