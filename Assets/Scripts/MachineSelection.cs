using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class MachineSelection : MonoBehaviour 
{
	// Singleton instance
	public static MachineSelection Instance;

	// public variables
	public Transform cameraEyeAnchor;
	public GameObject firstSelection;
	public GameObject secondSelection;

	// private variables
	Vector3 pos;

	// Use this for initialization
	void Start () 
	{
		Instance = this;
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0))
		{
			pos = Input.mousePosition;
		}
			
		if (Input.GetMouseButtonUp (0)) 
		{
			var delta = Input.mousePosition-pos;

			if (delta == new Vector3 (0.0f, 0.0f, 0.0f))
			{
				CheckCollisions ();
			}
		}
	}

	void CheckCollisions ()
	{
		Ray ray = new Ray (cameraEyeAnchor.position, -cameraEyeAnchor.forward);
		RaycastHit hit;

		int layerMask = 1 << 8;

		if (Physics.Raycast (ray, out hit, layerMask))
		{
			switch (hit.collider.gameObject.name)
			{
			case "Selection 1":
			case "Selection 2":
			case "Selection 3":
			case "Selection 4":
			case "Selection 5":
			case "Selection 6":
			case "Selection 7":
				firstSelection.SetActive (false);
				secondSelection.SetActive (true);
				break;
			}
		}
	}
}
