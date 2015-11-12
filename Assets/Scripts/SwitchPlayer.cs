using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;

public class SwitchPlayer : MonoBehaviour {

	public GameObject playerRags;
	public GameObject playerReason;

   ThirdPersonUserControl ragsUserControl;

    bool playerRagsActive = true;
	bool playerReasonActive = false;

    //ThirdPersonCharacter Rags;

    private GameObject defaultCamera;
	private GameObject cameraPlayerRags;
	private GameObject cameraPlayerReason;

	/*void switchToPlayer(inputToEnable, inputToDisable, cameraLocation)
	{
		inputToEnable.enabled = true;
		inputToDisable.enabled = false;

		defaultCamera.transform.position = cameraLocation.transform.position;
		defaultCamera.transform.rotation = cameraLocation.transform.rotation;}*/


	// Use this for initialization
	void Start() 
	{
       ragsUserControl = GameManager.god.ragsObject.GetComponent<ThirdPersonUserControl>();
        //player1Input = player1.GetComponent("(your controller)");
        //player2Input = player2.GetComponent("(your controller)");
    }
	
	// Update is called once per frame
	void Update() 
	{
		if (Input.GetKeyDown ("1")) {
			playerRagsActive = true;
			playerReasonActive = false;

            ragsUserControl.enabled = true;

            //defaultCamera.transform.position = cameraPlayerRags.transform.position;
            //defaultCamera.transform.rotation = cameraPlayerRags.transform.rotation;
        }

		else if (Input.GetKeyDown ("2")) {  
			playerReasonActive = true;
			playerRagsActive = false;

            //turn of thirdplayercontroller
            ragsUserControl.enabled = false;

            //defaultCamera.transform.position = cameraPlayerReason.transform.position;
			//defaultCamera.transform.rotation = cameraPlayerReason.transform.rotation;
		}
		/*if(playerRagsActive){
			switchToPlayer(player1Input, player2Input, cameraPlayer1);  
		}*/
		
		/*else if(playerReasonActive){
			switchToPlayer(player2Input, player1Input, cameraPlayer2);  
		}*/
		
	}

}
