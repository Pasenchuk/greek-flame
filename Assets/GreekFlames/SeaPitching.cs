using UnityEngine;
using System.Collections;

public class SeaPitching : MonoBehaviour
{

	private const float MAX_ANGLE = 5;

	private float angle = 0;
	private bool direction = true;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (direction) {
			angle += Time.deltaTime;
			if (angle > MAX_ANGLE + Random.Range(0f, 3f))
				direction = false;
		} else {
			angle -= Time.deltaTime;
			if (angle < -MAX_ANGLE - Random.Range(0f, 3f))
				direction = true;
		}

		transform.localEulerAngles = new Vector3 (angle, transform.localEulerAngles.y, 0);
	}
}
