using UnityEngine;
using System.Collections;

public class WeaponControl : MonoBehaviour
{
	public GameObject bullet;

	private const float COOLDOWN_TIME = 1f;

	private bool gazeEntered;

	private float coolDown = 0;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (coolDown > 0)
			coolDown -= Time.deltaTime;

		if (coolDown <= 0 && (Input.GetMouseButton (0) || gazeEntered)) {
			coolDown = COOLDOWN_TIME;

			// Instantiate the projectile at the position and rotation of this transform
			var clone = (GameObject)Instantiate (bullet, transform.position, transform.rotation);

			// Add force to the cloned object in the object's forward direction
			clone.GetComponent<Rigidbody> ().AddForce ((clone.transform.forward + new Vector3 (0, 0.1f, 0)) * 30);
		}

		
	}

	public void OnGazeEntered ()
	{
		gazeEntered = true;
	}

	public void OnGazeLeft ()
	{
		gazeEntered = false;
	}
		
}
