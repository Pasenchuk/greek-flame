using UnityEngine;
using System.Collections;

public class GazeDetector : MonoBehaviour, IGvrGazeResponder
{

	public WeaponControl weaponControl;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void LateUpdate ()
	{
		GvrViewer.Instance.UpdateState ();
	}

	public void OnGazeEnter ()
	{
		weaponControl.OnGazeEntered ();
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit ()
	{
		weaponControl.OnGazeLeft ();
	}

	/// Called when the trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger ()
	{
	}
}
