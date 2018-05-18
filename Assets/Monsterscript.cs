using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Monsterscript : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Update () {
		NavMeshAgent agent = GetComponent<NavMeshAgent> ();
		agent.speed = 4;
		agent.destination = target.transform.position;
		}
	}
	
