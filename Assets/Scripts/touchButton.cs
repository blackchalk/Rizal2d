using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class touchButton : MonoBehaviour{
	
	public int gui2;
	public int gui3;
	public int gui4;
	
	public bool stop2;
	public bool stop3;
	public bool stop4;
	
	public GameObject bb;//2nd
	public GameObject cc;//3rd
	public GameObject dd;//4th

	// Horizontal Slider Mods
	public GUIStyle myStyle;
	public GUIStyle myStyle2;
	public GUIStyle style = null;

	// for navigation
	public bool menu = true;
	public bool options = false;
	public bool extras = false;
	public bool sound = false;
	public bool savepoints = false;

	// for sounds

	public float sfxVol = 1.0f;
	public float musicVol = 1.0f;
	public AudioClip clickSFX;
//	public float newMusicVol = 1.0f;
//	public float nowMusicVol;
	private BGMusic bgmusic;


	// textures
	public Texture2D bg; // texture background
	public Texture2D title; // texture rizal title
	public Texture2D texture; // texture start game
	public Texture2D texture1; // texture options
	public Texture2D texture2; // texture extras
	public Texture2D back; // texture back button
	public Texture2D optionsTitle; // texture options title
	public Texture2D audioSettings; // texture sounds title
	public Texture2D extraTitle; // texture extra title
	public Texture2D savePointTitle;
	public Texture2D instructionScene; // texture instruction scene
	public Texture2D savePoints;
	public Texture2D gallery;
	public Texture2D credits;
	public Texture2D act1;
	public Texture2D act2;
	public Texture2D act3;
	public Texture2D act4;
	public Texture2D exits;

	public Texture2D noact2;
	public Texture2D noact3;
	public Texture2D noact4;

	public bool response;

	void releaseHideGUIs(){
		
		if(gui2 == 1){
			stop2 = true;
		}
		
		if(gui2 != 1){
			stop2 = false;
		}
		
		if(gui3 == 1){
			stop3 = true;
		}
		
		if(gui3 != 1){
			stop3 = false;
		}
		
		if(gui4 == 1){
			stop4 = true;
		}
		
		if(gui4 != 1){
			stop4 = false;
		}
	}

	void Awake(){
		PlayerPrefs.SetInt("fromActs", 0);
		//PlayerPrefs.SetInt("Set4", 0);
		bgmusic=GameObject.Find ("MusicManager").GetComponent<BGMusic>();


	}
	void Start(){
		bgmusic.audio.volume=1.0f;
	}
	void OnGUI(){
		// GUI Background and Title
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), bg);

		// Menu Interface
		if (menu) {
			GUI.backgroundColor = Color.clear;

			GUI.DrawTexture (new Rect (0, 0, (Screen.width)* 0.6f, (Screen.height)* 0.5f), title);

			if (GUI.Button(new Rect (Screen.width * 0.6f, Screen.height * 0.2f, (Screen.width)*0.4f, (Screen.height)*0.25f), texture)) {
				//Debug.Log("Start Button has been touched.");// play game
//				Application.LoadLevel("Act1S1Title");
				IsFreshLoad();
				audio.PlayOneShot(clickSFX);

			}
			if (GUI.Button (new Rect (Screen.width * 0.6f, Screen.height * 0.45f, (Screen.width)*0.4f, (Screen.height)*0.25f), texture1)) {
				menu = false;
				options = true;
				audio.PlayOneShot(clickSFX);

			}
			if (GUI.Button (new Rect (Screen.width * 0.6f, Screen.height * 0.7f, (Screen.width)*0.4f, (Screen.height)*0.25f), texture2)) {
				menu = false;
				extras = true;
				audio.PlayOneShot(clickSFX);

			}

			if (GUI.Button (new Rect (Screen.width * -0.05f, Screen.height * 0.8f, (Screen.width)*0.2f, (Screen.height)*0.13f), exits)) {
				menu = false;
				Application.Quit();
				audio.PlayOneShot(clickSFX);

			}

		}

		// Options Interface
		if (options) {
			GUI.backgroundColor = Color.clear;
			GUI.DrawTexture(new Rect( 0, 0, (Screen.width)*0.45f, (Screen.height)*0.3f), optionsTitle);

			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.5f, (Screen.width)*0.2f, (Screen.height)*0.2f), audioSettings)) {
				options = false;
				sound = true;
				audio.PlayOneShot(clickSFX);
			}
			
			if (GUI.Button (new Rect (Screen.width * 0.70f, Screen.height * 0.7f, (Screen.width)*0.2f, (Screen.height)*0.2f), back)) {
				options = false;
				menu = true;
				audio.PlayOneShot(clickSFX);
			}

			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.3f, Screen.width*0.20f, Screen.height*0.20f), savePoints)) {
				options = false;
				savepoints = true;
				audio.PlayOneShot(clickSFX);
			}
		}

		// Sound Interface
		if (sound) {	

			//			sfxVol = GUI.HorizontalSlider(new Rect(Screen.width*0.4f, Screen.height*0.5f, Screen.width/4, 30), sfxVol, 0.0f, 1.0f);
			//			GUI.Label(new Rect(Screen.width*0.5f, Screen.height*0.55f, 100, 100), "SFX: " + (sfxVol*10).ToString("f0"));

			//bgmusic.audio.volume = musicVol;

				bgmusic.audio.volume = musicVol;
				musicVol = GUI.HorizontalSlider (new Rect (Screen.width*0.4f, Screen.height*0.5f, (Screen.width)*0.2f, (Screen.height)*0.05f), musicVol,0.0f, 1.0f, myStyle, myStyle2);

			GUI.Label (new Rect (Screen.width * 0.45f, Screen.height * 0.55f, (Screen.width)*0.1f, (Screen.height)*0.1f), "VOLUME = " + (musicVol*10).ToString("f0"),style);


			GUI.backgroundColor = Color.clear;
			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.7f, (Screen.width)*0.2f, (Screen.height)*0.20f), back)) {
			
				sound = false;
				options = true;
				audio.PlayOneShot(clickSFX);
			}
		}

		// Extras Interface
		if (extras) {

			GUI.backgroundColor = Color.clear;
			GUI.DrawTexture(new Rect(0, 0, Screen.width*0.45f, Screen.height*0.3f), extraTitle);

			if (GUI.Button (new Rect (Screen.width * 0.70f, Screen.height * 0.7f, Screen.width*0.20f, Screen.height*0.20f), back)) {
				extras = false;
				menu = true;
				audio.PlayOneShot(clickSFX);
			}

			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.5f, Screen.width*0.20f, Screen.height*0.20f), instructionScene)) {
				extras = false;
				Application.LoadLevel("Instruction Scene");
				audio.PlayOneShot(clickSFX);
			}

			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.7f, Screen.width*0.20f, Screen.height*0.20f), credits)) {
				extras = false;
				Application.LoadLevel("CreditsScene");
				Debug.Log("oi");
			}

			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.3f, Screen.width*0.20f, Screen.height*0.20f), gallery)) {
				extras = false;
				Application.LoadLevel("Gallery 1");
				audio.PlayOneShot(clickSFX);
			}

		}

		if(savepoints) {

			releaseHideGUIs();

			//PlayerPrefs.SetInt ("Set4", 0);

			gui2 = PlayerPrefs.GetInt ("Set2");
			gui3 = PlayerPrefs.GetInt ("Set3");
			gui4 = PlayerPrefs.GetInt ("Set4");

			GUI.backgroundColor = Color.clear;
			GUI.DrawTexture(new Rect(0, 0, Screen.width*0.45f, Screen.height*0.3f), savePointTitle);

//			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.0f, Screen.width*0.20f, Screen.height*0.20f), act1)) {
//				savepoints = false;
//				//LoadLevel the start of Act1
//				Application.LoadLevel("Act1S1Title");
//
//			}

			if(stop2){
			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.2f, Screen.width*0.20f, Screen.height*0.20f), act2)) {
				savepoints = false;
				//LoadLevel the start of Act2
					Application.LoadLevel("Act2TitleRygn");
					PlayerPrefs.SetInt("fromAct", 1);
			}
			}

			if(stop3){
			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.4f, Screen.width*0.20f, Screen.height*0.20f), act3)) {
				savepoints = false;
				//LoadLevel the start of Act3
					Application.LoadLevel("Act3Title");
					PlayerPrefs.SetInt("fromAct", 1);
			}
			}

			if(stop4){
			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.6f, Screen.width*0.20f, Screen.height*0.20f), act4)) {
				savepoints = false;
				//LoadLevel the start of Act4
					Application.LoadLevel("Act4PART1TITLE");
					PlayerPrefs.SetInt("fromAct", 1);
			}
			}

			if (GUI.Button (new Rect (Screen.width * 0.40f, Screen.height * 0.8f, Screen.width*0.20f, Screen.height*0.20f), back)) {
				savepoints = false;
				options = true;
			}

		}
	}
	public void IsFreshLoad(){//r
		if(response==true){
			Application.LoadLevel("Instruction Scene");
		}
		if(response==false){
			Application.LoadLevel("Act1S1Title");
		}
	}
	public void Responder(bool respo){
		response=respo;
//		print (response);
	}


}