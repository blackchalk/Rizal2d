using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
	Transform target;
	
	// Use this for initialization
	void Start () {
		
		//Function to detect the "Player" object
//		target = GameObject.Find("Player").transform;
		
	}

	void Awake(){
//		target = GameObject.Find("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {

		target = GameObject.Find("Player").transform;
		
		//Function for the camera view
		transform.position = target.position + new Vector3 (0, 0, -2);
		
	}
}

