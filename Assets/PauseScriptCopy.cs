using UnityEngine;
using System.Collections;

public class PauseScriptCopy : MonoBehaviour {

	public GUITexture resume;
	public GUITexture goMenu;
	public GUITexture pause;

	public bool isPaused;

	public bool activatePause;

	public bool activateNow;

	public GameObject pauseParent;

	public string playInPause;
	
	public int fromAct;


	void Start () {
	
	}

	void Awake(){
		fromAct = PlayerPrefs.GetInt("fromAct");

		if(fromAct == 0){
			this.gameObject.SetActive(false);
		}

		if(fromAct == 1){
			this.gameObject.SetActive(true);
		}
	}

	void Update () {

		playInPause = Application.loadedLevelName;


		if((playInPause == "MothDied")||(playInPause == "Act 1 Scene 3A")||(playInPause == "FOOFOOFOO2")||(playInPause == "Act 1 Scene 3A")
		   ||(playInPause == "FOOFOOFOO6")||(playInPause == "FOOFOOFOO13")||(playInPause == "FOOFOOFOO7")||(playInPause == "FOOFOOFOO10")
		   ||(playInPause == "FOOFOOFOO12")||(playInPause == "EPILOGUEAct4part3")||(playInPause == "New Act4 Part3 Scene2")
		   ||(playInPause == "New Act4 Part3 Scene3")){//Scenes that does not need a pause
			activateNow = false;//kelangan mamalaman kung kela siya ma-aactivate at madedeactivate;pause button
			pause.enabled = false;
		}

		if((playInPause == "Act 1 Scene 2")||(playInPause == "Act 1 Scene 1 Remake")||(playInPause == "New Act 2")||(playInPause == "New Act 3 Scene 1")
		   ||(playInPause == "New Act3 PArt2 Scene 1")||(playInPause == "New Act4 Part1 Scene1")||(playInPause == "New Act4 Part2 Scene4 room1")
		   ||(playInPause == "New Act4 Part3 Scene1")){// Scenes that the player is in.
			activateNow = true;
			pause.enabled = true;
		}

		if(activateNow){
		if(isPaused == false){
			pauseParent.SetActive(false);
		} else {
			pauseParent.SetActive(true);
		}

		if(Input.GetMouseButtonDown (0)) {
				if(pause.HitTest(Input.mousePosition, Camera.main)) {
					isPaused = true;
					activatePause = true;
				}
				
			if(activatePause){
				if(resume.HitTest(Input.mousePosition, Camera.main)) {
					isPaused = false;
					activatePause = false;
				}

				if(goMenu.HitTest(Input.mousePosition, Camera.main)) {
					isPaused = false;
					Application.LoadLevel("MainInterfaceVersionAug22");
					Destroy(this.gameObject);
						activatePause = false;
				}
			}
		}
		pauseActive();
	}
	}


	void pauseActive(){
		if(isPaused){
			Time.timeScale = 0;
			PlayerPrefs.SetInt("stopButton", 1);
		} else {
			Time.timeScale = 1;
			PlayerPrefs.SetInt("stopButton", 0);
		}
	}
}
