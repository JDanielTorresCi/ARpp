using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereScript : MonoBehaviour {

	public GameObject plane;
	public GameObject spawnPoint;
	// Use this for initialization
	void Start () {
//		transform.position = spawnPoint.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position.y < plane.transform.position.y - 10){

			transform.position = spawnPoint.transform.position;
			
		}
		
	}
}
