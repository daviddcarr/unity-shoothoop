using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 3.0f;
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Rigidbody rb = InstantiateBall ();
			rb.velocity = Vector3.left * speed;
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Rigidbody rb = InstantiateBall ();
			rb.velocity = Vector3.right * speed;
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Rigidbody rb = InstantiateBall ();
			rb.velocity = Vector3.forward * speed;
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Rigidbody rb = InstantiateBall ();
			rb.velocity = Vector3.back * speed;
		}

	}

	Rigidbody InstantiateBall () {
		GameObject instance = Instantiate (ballPrefab);
		Rigidbody rb = instance.GetComponent<Rigidbody> ();
		return rb;
	}
}
