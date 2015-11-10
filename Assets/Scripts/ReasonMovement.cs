using UnityEngine;
using System.Collections;

public class ReasonMovement : MonoBehaviour {
	public float moveSpeed;
	public float turnSpeed;
	public int turnSmoothing;
	public int maxDistance;
	
	private Vector3 movement;
	private Vector3 turning;
	private Animator anim;
	private Rigidbody playerRigidBody;

	void Awake() {
		//get reference
		//anim = GetComponent<Animator> ();
		//playerRigidBody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float lh = Input.GetAxisRaw ("Horizontal");
		float lv = Input.GetAxisRaw ("Vertical");

		Move(lh, lv);
		Animating(lh, lv);
	}

	void Move(float lh, float lv)
	{
		//move the player
		movement.Set (lh, 0f, lv);

		movement = movement.normalized * moveSpeed * Time.deltaTime;

		playerRigidBody.MovePosition(transform.position + movement);

		if(lh != 0f || lv != 0f)
		{
			Rotation(lh, lv);
		}

	}

	void Rotation(float lh, float lv)
	{
		Vector3 targetDirection = new Vector3 (lh, 0f, lv);

		Quaternion targetRotation = Quaternion.LookRotation (targetDirection, Vector3.up);

		Quaternion newRotation = Quaternion.Lerp (GetComponent<Rigidbody> ().rotation, targetRotation, turnSmoothing * Time.deltaTime);

		GetComponent<Rigidbody> ().MoveRotation (newRotation);
	}
	void Animating(float lh, float lv)
	{
		//bool running = lh != 0f || lv != 0f;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
