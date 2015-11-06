using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;

public class BoosterShoes : UtilityTools {

	ThirdPersonCharacter Rags;

	// Use this for initialization
	void Start () {
		Rags = GameManager.god.ragsObject;

	}
	
	// Update is called once per frame
	void Update () {

		if (Rags.m_IsGrounded == false)
		{
			if (Input.GetButtonDown("Jump"))
			{
				Rags.jumpNow();
			}
		}

			}

	}
