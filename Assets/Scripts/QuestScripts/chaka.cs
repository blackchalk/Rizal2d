using UnityEngine;
using System.Collections;

public class chaka : MonoBehaviour {
	public Texture2D image1;
	public Texture2D image2;


	public bool forImage1 = true;
	public bool forImage2 = false;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
//	void Update () {
//
//		if(Input.touchCount>0){
//
//			Touch t = Input.GetTouch(0);
//
//			if(forImage1.phase == TouchPhase.Began){
//
////				if(forImage1.HitTest(t.position, Camera.main)){
//////					forImage1.SetActive("false");
////					Debug.Log("hit at"+t.position+" with phase:"+forImage1.phase);
////
////				}
//			}
//	
//		}
//	}

	void OnGui(){

		if(forImage1){

			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), image1);

			}

		if(forImage2){

			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), image2);

		}
	}
}
