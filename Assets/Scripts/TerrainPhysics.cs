using UnityEngine;
using System.Collections;

public class TerrainPhysics : MonoBehaviour 
{
	// Singleton instance
	public static TerrainPhysics Instance;

	// private variables
	Rigidbody rbody;
	Vector3 initialPosition;
	Quaternion initialRotation;

	// Use this for initialization
	void Start () 
	{
		Instance = this;

		rbody = GetComponent<Rigidbody>();
		rbody.constraints = RigidbodyConstraints.FreezeAll;

		initialPosition = transform.localPosition;
		initialRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (TerrainCollision.Instance.isCollidedWithRocks)
		{
			rbody.constraints = RigidbodyConstraints.None;
		}
		else
		{
			ResetPhysics ();
		}
	}
		
	public void ResetPhysics ()
	{
		TerrainCollision.Instance.isCollidedWithRocks = false;

		transform.localPosition = initialPosition;
		transform.localRotation = initialRotation;

		rbody.constraints = RigidbodyConstraints.FreezeAll;
	}
}
