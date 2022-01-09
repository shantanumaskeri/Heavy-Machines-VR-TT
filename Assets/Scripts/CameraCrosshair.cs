using UnityEngine;
using System.Collections;

public class CameraCrosshair : MonoBehaviour 
{
	// Singleton instance
	public static CameraCrosshair Instance;

	// public variables
	public Camera cameraFacing;

	// Use this for initialization
	void Start () 
	{
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = cameraFacing.transform.position + cameraFacing.transform.rotation * Vector3.forward;
		transform.LookAt (cameraFacing.transform.position);
	}
}
