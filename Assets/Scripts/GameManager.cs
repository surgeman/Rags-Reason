using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class GameManager : MonoBehaviour {

	public static GameManager god { get; private set; }

	public ThirdPersonCharacter ragsObject;

	// Use this for initialization
	void Awake () {
		god = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
