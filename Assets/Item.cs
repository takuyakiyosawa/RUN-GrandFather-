﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Item : MonoBehaviour {
	public Slider slider;
	int sutamina = 0;
	void OnTriggerEnter (Collider hit){
		
		if (hit.CompareTag ("player")) {
			sutamina = sutamina + 1;
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
