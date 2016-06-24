using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float rotationSpeed = 9.0f;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;

		//Rotate player object (parent)
		transform.localRotation = transform.localRotation * Quaternion.Euler (0, mouseX, 0);

		//Grab the camera object and rotate it (Child)
		Camera camera = GetComponentInChildren<Camera> ();
		camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler (-mouseY, 0, 0);
		//transform.localRotation = transform.localRotation * Quaternion.Euler (0, 1, 0);
	}
}
