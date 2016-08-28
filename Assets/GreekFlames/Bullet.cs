using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameObject.transform.position.y < -10)
			Destroy (gameObject);
	}


	void OnTriggerEnter (Collider target)
	{
		//		Debug.Log (collision.gameObject.name);
		if (target.gameObject.tag == "Enemy") {
			Destroy (gameObject);
		}

	}
}
