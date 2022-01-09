using UnityEngine;
using System.Collections;

public class TerrainCollision : MonoBehaviour 
{
	// Singleton instance
	public static TerrainCollision Instance;

	// public variables
	public bool isCollidedWithRocks = false;

	// private variables
	bool isCollided = false;

	// Use this for initialization
	void Start () 
	{
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag.Equals ("Bucket"))
		{
			if (!isCollided)
			{
				isCollided = true;

				Invoke ("DelayInCollision", 0.3f);
			}
		}
	}

	void DelayInCollision ()
	{
		isCollidedWithRocks = true;
	}

	public void ResetCollision ()
	{
		isCollided = false;
		isCollidedWithRocks = false;

		CancelInvoke ("DelayInCollision");
	}
}
