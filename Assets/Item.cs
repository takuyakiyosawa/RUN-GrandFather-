using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Item : MonoBehaviour {
	public Slider slider;
	float sutamina = 1;

	void OnTriggerEnter (Collider hit){

		if (hit.CompareTag ("player")) {

			Destroy (gameObject);
		}
		if (hit.CompareTag ("player")) {
			sutamina = 1;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
