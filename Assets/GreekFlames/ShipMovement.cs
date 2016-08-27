using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddRelativeForce (new Vector3 (0, 0, Input.GetAxis ("Vertical") * Time.deltaTime * 100));
		var currentVelocity = rb.velocity;


		rb.velocity = new Vector3 (Clamp (currentVelocity.x), Clamp (currentVelocity.y), Clamp (currentVelocity.z));
		gameObject.transform.Rotate (Vector3.up * Input.GetAxis ("Horizontal") * Time.deltaTime * 4);

		//Debug.Log (currentVelocity);
	}

	private float Clamp (float f) {
		return Mathf.Clamp (f, -1, 1);
	}
}
