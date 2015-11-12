using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.Vehicles.Ball;

public class GameManager : MonoBehaviour {

	public static GameManager god { get; private set; }

    public SwitchPlayer ragsReason;
	public ThirdPersonCharacter ragsObject;
    public Ball reasonObject;




    // Use this for initialization
    void Awake () {
		god = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
