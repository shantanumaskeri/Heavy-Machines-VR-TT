using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour 
{
	// Singleton instance
	public static InputManager Instance;

	// public varaibles
	public GameObject firstBoom;
	public GameObject secondBoom;
	public GameObject gearHandle;
	public GameObject container360View;

	// private variables
	Quaternion initialRotation_fb;
	Quaternion initialRotation_sb;
	Quaternion initialRotation_gear;
	Quaternion initialRotation_cont;

	// Use this for initialization
	void Start () 
	{
		Instance = this;

		initialRotation_fb = firstBoom.transform.localRotation;
		initialRotation_sb = secondBoom.transform.localRotation;
		initialRotation_gear = gearHandle.transform.localRotation;
		initialRotation_cont = container360View.transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			ResetExperience ();
		}
	}

	public void ResetExperience ()
	{
		firstBoom.transform.localRotation = initialRotation_fb;
		secondBoom.transform.localRotation = initialRotation_sb;
		gearHandle.transform.localRotation = initialRotation_gear;
		container360View.transform.localRotation = initialRotation_cont;

		ExperienceManager.Instance.isGeared = false;
		ExperienceManager.Instance.isRotating = false;
		ExperienceManager.Instance.isAnimating = false;

		if (!ExperienceManager.Instance.isInside)
		{
			ExperienceManager.Instance.lcmeHotspot.SetActive (true);
			ExperienceManager.Instance.armHotspot.SetActive (true);
			ExperienceManager.Instance.trackHotspot.SetActive (true);
			ExperienceManager.Instance.interiorHotspot.SetActive (true);
		}
		else
		{
			ExperienceManager.Instance.lcmiHotspot.SetActive (true);
			ExperienceManager.Instance.leadingOutputHotspot.SetActive (true);
			ExperienceManager.Instance.gearHotspot.SetActive (true);
		}

		ExperienceManager.Instance.armInfo.SetActive (false);
		ExperienceManager.Instance.lcmeInfo.SetActive (false);
		ExperienceManager.Instance.trackInfo.SetActive (false);
		ExperienceManager.Instance.lcmiInfo.SetActive (false);
		ExperienceManager.Instance.leadingOutputInfo.SetActive (false);

		TerrainCollision.Instance.ResetCollision ();
		TerrainPhysics.Instance.ResetPhysics ();
	}
}
