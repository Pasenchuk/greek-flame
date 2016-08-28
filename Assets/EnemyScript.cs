using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

	public int hp = 100;
	public bool dead = false;

	// Use this for initialization
	void Start ()
	{
		transform.localEulerAngles = new Vector3 (0, Random.Range (-180, 180), 0);
		EnemyCounter.IncreaseCounter ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameObject.transform.position.y < -10)
			Destroy (gameObject);
		
		if (dead) {
			transform.Translate (Vector3.down * Time.deltaTime);
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x + Time.deltaTime, transform.localEulerAngles.y, 0);
		}
	}

	void OnTriggerEnter (Collider target)
	{
//		Debug.Log (collision.gameObject.name);
		if (target.gameObject.tag == "PlayerBullet") {
			if (!dead) {
				hp -= 25;
				if (hp <= 0) {
					dead = true;
					EnemyCounter.DecreaseCounter ();
				}
			}
		}

	}
}
