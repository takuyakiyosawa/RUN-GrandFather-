using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenescript : MonoBehaviour {

	void Update(){

		if (Input.GetMouseButtonDown (0)) {
			
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("downstreet")) {
			SceneManager.LoadScene ("blue");
			if (col.gameObject.CompareTag ("upstreet")) {
				SceneManager.LoadScene ("green");
				if (col.gameObject.CompareTag ("Goal")) {
					SceneManager.LoadScene ("black");
				}

			}
		}
	}

	public void TitleScene(){
		SceneManager.LoadScene ("Title");
	}

	public void MaeScene(){
		SceneManager.LoadScene ("maedannkai");
	}
}

