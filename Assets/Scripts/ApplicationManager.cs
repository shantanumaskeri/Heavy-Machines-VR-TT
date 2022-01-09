using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour 
{
	// Singleton instance
	public static ApplicationManager Instance;

	// public variables
	public bool isMoveAllowed;
	public GameObject firstSelection;
	public GameObject secondSelection;
	public GameObject mainExperience;
	public GameObject ovrPlayerController;

	// private variables
	Vector3 initialPosition;

	// Use this for initialization
	void Start () 
	{
		Instance = this;

		isMoveAllowed = false;

		firstSelection.SetActive (true);
		secondSelection.SetActive (false);
		mainExperience.SetActive (false);

		initialPosition = ovrPlayerController.transform.position;

		//ovrPlayerController.GetComponent<MouseCameraView>().enabled = false;
	}

	public void InitializeApplication ()
	{
		isMoveAllowed = true;

		secondSelection.SetActive (false);
		mainExperience.SetActive (true);
	}

	public void ResetApplication ()
	{
		isMoveAllowed = false;

		ovrPlayerController.transform.position = initialPosition;

		secondSelection.SetActive (true);
		mainExperience.SetActive (false);
	}
}
