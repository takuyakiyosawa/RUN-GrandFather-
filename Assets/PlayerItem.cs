using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerItem : MonoBehaviour {

	public static int sutamina = 0;

	void OnTriggerEnter (Collider hit){

		if (hit.CompareTag ("Item")) {

			sutamina += sutamina + 1;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
