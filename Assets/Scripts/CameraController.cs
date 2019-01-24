using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
	public GameObject cube;
	
	private Vector3 offset;
	private Vector3 offsetcube;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		offsetcube = transform.position - cube.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//transform.position = player.transform.position + offset;
		transform.position = cube.transform.position + offsetcube;
	}
}
