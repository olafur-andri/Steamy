using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public float speed;
	public float sensitivity;
	private Vector3 lastMousePosition;
	private Vector3 mousePosition;

	// Use this for initialization
	void Start () {
		lastMousePosition = Input.mousePosition;
		mousePosition = lastMousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = Input.mousePosition;
		float moveX = mousePosition.x - lastMousePosition.x;
		float moveY = lastMousePosition.y - mousePosition.y;
		transform.Rotate (Vector3.up * moveX, Space.World);
		transform.Rotate (Vector3.forward * moveY, Space.World);

		lastMousePosition = mousePosition;
	}
}
