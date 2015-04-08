//using UnityEngine;
//using System.Collections;
//
//public class GameManager : MonoBehaviour {
//
//	private GameObject[] qObject;
//
//	void Awake(){
//		//Screen.SetResolution(1280,800,false); //false means not fullscreen
//
//		//get a list of gameobject with tag qIndicator
//		var aObjects = GameObject.FindGameObjectsWithTag("qIndicator");
//		//redefine the list to array
//		qObject = new GameObject[aObjects.Length];
//		//save the qobjects into the array for easy access when deactivated
//		for(int i=0;i<aObjects.Length;i++){
//			qObject[i]=aObjects[i];
//			Debug.Log(qObject[i].name);
//		}
//
//	}
//
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
//}
