using UnityEngine;
using System.Collections;


//Handles onmousedown events for this button, and send it to a specific script[CameraObjectives]
public class ToggleObjectives : MonoBehaviour {

	public bool objectivesMode=false; // flag to turn on/off OBJECTIVES; attached to GUIObjectives
	public int imHit;
	private GameObject target;
//	public GUITexture oldTexture;
//	public GUITexture newTexture; //soon


	 
	void Awake(){
//		objectivesMode = target.GetComponent<CameraObjectivesManager>().objectivesMode;
	}

	void OnMouseDown(){
		target= GameObject.Find("CameraObjectives");
		objectivesMode = target.GetComponent<CameraObjectivesManager>().objectivesMode;
		imHit++;
		if(imHit>=1){
		ToggleMode();
			return;}
	}
	void ToggleMode(){

		if(!objectivesMode){
			objectivesMode=false;		
//			Debug.Log ("im here");
			target.GetComponent<CameraObjectivesManager>().objectivesMode=true;
			return;
		}
		if(objectivesMode)
		{
			objectivesMode=true;		
			target.GetComponent<CameraObjectivesManager>().objectivesMode=false;
//			Debug.Log ("im showing obj");
			return;
		}
	}

	}

