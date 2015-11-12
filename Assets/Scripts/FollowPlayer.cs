using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;

public class FollowPlayer : MonoBehaviour {


	public GameObject target;
	public GameObject self;

	private Vector3 offset;
	 
	
	void Awake ()
	{
		//myTransform = target;
	}

	
	// Use this for initialization
	void Start () 
	{
		offset = self.transform.position - target.transform.position;

		//GameObject go = GameObject.FindGameObjectWithTag("GameManager.god.ragsObject");
		//target = go.transform;
	}

	// Update is called once per frame
	void Update () 
	{

		self.transform.position = target.transform.position + offset;
		//myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), turnSpeed*Time.deltaTime);
		//move towards the player
		//myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

	}

}
