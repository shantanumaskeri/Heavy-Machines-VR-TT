using UnityEngine;
using System.Collections;

public class BoomArmController : MonoBehaviour 
{
	// Singleton instance
	public static BoomArmController Instance;

	// private variables
	Quaternion initialRotation;

	// Use this for initialization
	void Start () 
	{
		initialRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (ExperienceManager.Instance.isAnimating)
		{
			transform.Rotate (0.0f, 0.0f, -20.0f * Time.deltaTime);

			if (transform.localEulerAngles.z<320.0f)
			{
				transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y, 320.0f);
			}
		}
	}
}
