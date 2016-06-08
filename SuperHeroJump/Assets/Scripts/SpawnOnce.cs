﻿using UnityEngine;
using System.Collections;

public class SpawnOnce : MonoBehaviour {
	
	public GameObject[] prefabs;
	public float delay = 0.0f;
	public bool active = true;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (EnemyGenerator ());
	}
	
	IEnumerator EnemyGenerator(){
		yield return new WaitForSeconds (delay);
		
		if(active){
			var newTransform = transform;
			
			Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position, Quaternion.identity);
		}
	}
}
