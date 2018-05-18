using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	public AudioSource oziityanJump;
	public AudioSource oziityanslide;
	public AudioSource oziityandie;
	public AudioSource oziityanmusic;
	// Use this for initialization
	void Start () {
		oziityanJump = GetComponent<AudioSource>();
		oziityanslide = GetComponent<AudioSource>();
		oziityandie = GetComponent<AudioSource> ();
		oziityanmusic = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			oziityanJump.Play ();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			oziityanslide.Play ();
		}
	}
	void OnTriggerEnter (Collider hit){

		if (hit.CompareTag ("Low")) {
			oziityandie.Play ();
		}
		if (hit.CompareTag ("High")) {
			oziityandie.Play ();
		}
	}
}
