using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenescript : MonoBehaviour {

	void Update(){

		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("maedannkai");
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("downstreet")) {
			SceneManager.LoadScene ("blue");
			if (col.gameObject.CompareTag ("upstreet")) {
				SceneManager.LoadScene ("green");
				if (col.gameObject.CompareTag ("hospital")) {
					SceneManager.LoadScene ("black");
			}
		}
	}
}
}
