using UnityEngine;
using System.Collections;

//receives the toggle(ToggleObjectives) and manages the enable/disable of the cameraobjectives
public class CameraObjectivesManager : MonoBehaviour {

	public bool objectivesMode;
	public bool isPaused;
	public GameObject stpMovements;
	public GameObject stpJoystick;
//	public GameObject showScreen;

	// Use this for initialization
	void Start () {
		this.gameObject.camera.enabled=false;
//		showScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
//		Active(false);
		if(objectivesMode){
			GameObject.Find("CameraObjectives").GetComponent<Camera>().camera.enabled=true;
			stpJoystick.GetComponent<MPJoyStick>().enabled=false;
			stpMovements.GetComponent<PlayerMovements>().enabled=false;
//			showScreen.SetActive(true);
			PausedGame();
			return; 
		}
		else 
		{
			GameObject.Find("CameraObjectives").GetComponent<Camera>().camera.enabled=false;
			camera.enabled=false;
			stpJoystick.GetComponent<MPJoyStick>().enabled=true;
			stpMovements.GetComponent<PlayerMovements>().enabled=true;
//			showScreen.SetActive(false);
			ResumeGame();
			return;
		}
	}
	private void PausedGame(){
//		Time.timeScale=0.0f;
//		Debug.Log ("GamePaused");
		isPaused =true;
	}
	private void ResumeGame(){
//		Time.timeScale=1.0f;
//		Debug.Log ("resum Game");
		isPaused = false;
	}

}
