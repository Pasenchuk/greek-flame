using UnityEngine;
using System.Collections;

public class EnemyCounter : MonoBehaviour {

	public static int enemyCount = 0;
	private static bool battleStarted;

	public static void IncreaseCounter() {
		enemyCount++;
		battleStarted = true;
	}

	public static void DecreaseCounter() {
		enemyCount--;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (battleStarted && enemyCount==0) 
			Application.LoadLevel(Application.loadedLevel);
	}
}
