using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;

public class BoosterShoes : UtilityTools {
	public int boostCounter = 3;
	private int boostLimit = 0;
	ThirdPersonCharacter Rags;

	// Use this for initialization
	void Start () {
		Rags = GameManager.god.ragsObject;
		boostLimit = boostCounter;
	}
	
	// Update is called once per frame
	void Update () {

		//Checks if Rags is in the air
		if (Rags.m_IsGrounded == false) {
			//Sets the amount of boost jumps
			if (boostCounter > 0) {
				if (Input.GetButtonDown ("Jump")) {
					Rags.jumpNow ();
					boostCounter--;
				}
			}
		//Resets the boost counter once you land	
		} else if (Rags.m_IsGrounded == true) {
			boostCounter = boostLimit;
		}
	}
}
