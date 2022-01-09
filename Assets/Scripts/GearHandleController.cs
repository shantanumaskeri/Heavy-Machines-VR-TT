using UnityEngine;
using System.Collections;

public class GearHandleController : MonoBehaviour 
{
	// Singleton instance
	public static GearHandleController Instance;

	// Use this for initialization
	void Start () 
	{
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (ExperienceManager.Instance.isGeared)
		{
			transform.Rotate (0.0f, 0.0f, -20.0f * Time.deltaTime);

			if (transform.localEulerAngles.z<340.0f)
			{
				transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y, 340.0f);

				ExperienceManager.Instance.isAnimating = true;
			}
		}
	}
}
