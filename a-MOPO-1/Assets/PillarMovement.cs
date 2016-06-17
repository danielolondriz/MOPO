using UnityEngine;
using System.Collections;

public class PillarMovement : MonoBehaviour {

	public int speed;
	public float friction;
	public float lerpSpeed;

	private float xDeg;
	private float yDeg;
	private Quaternion fromRotation;
	private Quaternion toRotation;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (1)) {
			xDeg -= Input.GetAxis ("Mouse X") * speed * friction;

			fromRotation = transform.rotation;
			toRotation = Quaternion.Euler (0, xDeg, 0);

			transform.rotation = Quaternion.Lerp (fromRotation, toRotation, Time.deltaTime * lerpSpeed);
		}
	}
}
