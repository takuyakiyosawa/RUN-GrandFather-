using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Maincamera : MonoBehaviour {
	public GameObject player;
	public GameObject mainCamera;
	Camera cam;
	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		mainCamera.transform.position = new Vector3(4.8f,2.1f,player.transform.position.z);

		}
}
