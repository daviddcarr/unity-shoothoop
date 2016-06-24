using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	//Create field to input prefab model in inspector
	public GameObject ballPrefab;
	public float ballSpeed = 15.0f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		//if (Input.GetButtonDown ("Fire1")) {
		//	InstantiateBall (ballSpeed);
		//}

		if (Input.GetKeyDown (KeyCode.Space)) {
			InstantiateBall (ballSpeed);
		}

	}

	void InstantiateBall (float speed) {
		GameObject instance = Instantiate (ballPrefab);
		instance.transform.position = transform.position;
		Rigidbody rb = instance.GetComponent<Rigidbody> ();
		Camera camera = GetComponentInChildren<Camera>();
		rb.velocity = (camera.transform.rotation * Vector3.forward) * speed;
	}
}
