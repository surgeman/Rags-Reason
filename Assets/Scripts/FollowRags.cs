using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;

public class FollowRags : MonoBehaviour {
    
	public GameObject target;
	public GameObject self;

	private Vector3 offset;
    public float smoothing = 1f;
	
	// Use this for initialization
	void Start () 
	{
	
	}

	// Update is called once per frame
	void Update () 
	{
        self.transform.position = Vector3.Lerp(self.transform.position, target.transform.position, Time.deltaTime * smoothing);
        
	}

}
