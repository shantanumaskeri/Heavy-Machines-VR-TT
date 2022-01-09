using UnityEngine;
using System.Collections;

public class Machine360View : MonoBehaviour 
{
	// Singleton instance
	public static Machine360View Instance;
	
	// Use this for initialization
	void Start () 
	{
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (ExperienceManager.Instance.isRotating)
		{
			transform.Rotate (0.0f, 40.0f * Time.deltaTime, 0.0f);

			if (transform.localEulerAngles.y>=355.0f)
			{
				transform.localEulerAngles = new Vector3 (0.0f, 0.0f, 0.0f);

				ExperienceManager.Instance.isRotating = false;

				ExperienceManager.Instance.lcmeHotspot.SetActive (true);
				ExperienceManager.Instance.armHotspot.SetActive (true);
				ExperienceManager.Instance.trackHotspot.SetActive (true);
				ExperienceManager.Instance.interiorHotspot.SetActive (true);
			}
		}
	}
}