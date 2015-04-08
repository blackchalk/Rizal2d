using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]
public class NewAct2 : MonoBehaviour {

//	public float checker;
//	public float checkery;
//	public float che;
//	public float cher;
	/// <summary>
	/// ///////////
	/// </summary>
	public float xLabel; //r gui.label
	public float yLabel;
	public string levelToLoad;

	//Pixel Resizing
	public GUITexture buttonsA;
	public GUITexture Acts;
	public GUITexture Objectivez;
	public GUITexture textWindowz;
	//	public GUITexture controllerz;
	public GUITexture objectivesz;
	public GUITexture itemHolderz;
	public GUIText displayTickerz;

	private PlayerMovements touch;
	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene
	
	public AudioClip[] clip;//r array of sound effects

	public GUIStyle forFont;

	public GUITexture bt;
	public GUITexture wax;
	public GUITexture wax1;
	public GUITexture wax2;
	public GUITexture wax3;
	public GUITexture wax4;
	public GUITexture Transition1;
	public GUIText Monotext1;

	public string[] talkLinesNPC1;
	public int currentLine1 = 0;
	public string[] talkLinesNPC2;
	public int currentLine2 = 0;
	public string[] talkLinesNPC3;
	public int currentLine3 = 0;
	public string[] talkLinesNPC4;
	public int currentLine4 = 0;
	public string[] talkLinesNPC5;
	public int currentLine5 = 0;
	public string[] talkLinesNPC6;
	public int currentLine6 = 0;
	public string[] talkLinesObject;
	public int currentLine = 0;
	public int otherLine1 = 0;
	public string[] transitionLines1;
	public int transLine1 = 0;
	public string[] transitionLines2;
	public int transLine2 = 0;

	public int hitcount = 0;
	public int randomNumber = 0;

	//checkers
	public bool isTrigShow = false;
	public bool isHide = false;
	public bool isButtonPressedNPC = false;
	public bool isButtonPressedObject = false;
	public bool isPressedUnknown1 = false;
	public bool isHideWax = false;
	public bool isDisableBt = false;
	private bool isTextWindow =false; //r

	public bool isWax = false;
	public bool isWax1 = false;
	public bool isWax2 = false;
	public bool isWax3 = false;
	public bool isWax4 = false;

	public bool onQuest1a = true;
	public bool onQuest1b = false;
	public bool onQuest2 = false;
	public bool onTransition1 = false;
	public bool onQuest3 = false;
	public bool onQuest4 = false;
	public bool onQuest5 = false;
	public bool onQuest6 = false;
	public bool onQuest7 = false;
	public bool onQuest8 = false;
	public bool hideTransition1 = true;

	public bool ableTrans;

	//NPC and OBJECTS
	public bool NPC1 = false;
	public bool NPC2 = false;
	public bool NPC3 = false;
	public bool NPC4 = false;
	public bool NPC5 = false;
	public bool NPC6 = false;
	public bool Object1 = false;
	public bool Object2 = false;
	public bool insta1 = false;
	public bool insta2 = false;
	public bool insta3 = false;
	// Use this for initialization

	//Calls the class of type <NameOfClass> ticker class /r
	private TickerMessage tickerMsg;
	private QuestUnlocked newQuest;
	private QuestUnlocked wsQuest;
	private string qUnlock="Quest Unlocked!";

	void Awake(){//calls component of a gameobject
		touch = GameObject.Find("Player").GetComponent<PlayerMovements>();
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>();
		newQuest = GameObject.Find ("GUIQUnlock").GetComponent<QuestUnlocked>();
		wsQuest = GameObject.Find("GUIworkshop").GetComponent<QuestUnlocked>();
		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r //comment this if you are about to edit the scene
	}

	void Start () {
		MusicAudioListener.enabled=false;
		PlayerPrefs.SetInt("stopButton", 0);
		changeGUITexture(false,"book");
		changeGUITexture(false,"medal");
		//Objective: Go to the library and talk to the student.
		newQuest.displayEnd(qUnlock);
		audio.PlayOneShot(clip[0]);

	}

	void waxModel(){

		if (hitcount == 3) {
			isWax = false;
			isWax1 = true;
			//Debug.Log ("First Transform!");
			newQuest.displayEnd("Preparing Clay");
			} else if (hitcount == 6) {
				isWax1 = false;
				isWax2 = true;
				//Debug.Log ("Second Transform!");
				newQuest.displayEnd("Kneading with hands");
			} else if (hitcount == 9) {
				isWax2 = false;
				isWax3 = true;
				//Debug.Log ("Third Transform!");
				newQuest.displayEnd("Shaping the Clay");
			} else if (hitcount == 11) {
				isWax3 = false;
				isWax4 = true;
				//Debug.Log ("Fourth Transform!");
				newQuest.displayEnd("Eureka!A Medallion!");

			} else if (hitcount > 11){
				isWax4 = false;
				touch.release();
				onQuest6 = false;
				onQuest7 = true;
				isDisableBt = false;
				isTrigShow = false;
				isHide = false;
				Object2 = false;
			//O: SUBMIT YOUR WORK ON THE STUDENT LOCATED AT THE TOP OF THE CAMPUS. COMPLETE CLAY
			tickerMsg.displayStart("submit your\nwork to the\nhead student\nhe's at the\ntop of the\nhallway");
			newQuest.displayEnd(qUnlock);
			audio.PlayOneShot(clip[0]);
			changeGUITexture(true,"medal");


		}
	}

	void hideWax(){
		if (isHideWax == false) {
			GameObject.Find ("wax").guiTexture.enabled = false;
			GameObject.Find ("wax1").guiTexture.enabled = false;
			GameObject.Find ("wax2").guiTexture.enabled = false;
			GameObject.Find ("wax3").guiTexture.enabled = false;
			GameObject.Find ("wax4").guiTexture.enabled = false;
		} else {
			GameObject.Find ("wax").guiTexture.enabled = true;
			GameObject.Find ("wax1").guiTexture.enabled = true;
			GameObject.Find ("wax2").guiTexture.enabled = true;
			GameObject.Find ("wax3").guiTexture.enabled = true;
			GameObject.Find ("wax4").guiTexture.enabled = true;
		}

		if (isWax == true) {
						GameObject.Find ("wax").guiTexture.enabled = true;
				} else {
			GameObject.Find ("wax").guiTexture.enabled = false;
		}

		if (isWax1 == true) {
						GameObject.Find ("wax1").guiTexture.enabled = true;
				} else {
			GameObject.Find ("wax1").guiTexture.enabled = false;
		}

		if (isWax2 == true) {
						GameObject.Find ("wax2").guiTexture.enabled = true;
				} else {
			GameObject.Find ("wax2").guiTexture.enabled = false;		
		}

		if (isWax3 == true) {
						GameObject.Find ("wax3").guiTexture.enabled = true;
				} else {
			GameObject.Find ("wax3").guiTexture.enabled = false;
		}

		if (isWax4 == true) {
						GameObject.Find ("wax4").guiTexture.enabled = true;
				} else {
			GameObject.Find ("wax4").guiTexture.enabled = false;
		}
	}
	void disableBt(){

		isDisableBt = false;

	}

	void enableBt(){

		isDisableBt = true;

	}
	
	// Update is called once per frame
	void Update () {
		
		buttonsA.pixelInset = new Rect (Screen.width*0.85f, Screen.height*0.1f, (Screen.width)*0.1f, (Screen.height)*0.18f);
		Acts.pixelInset = new Rect (Screen.width*0f, Screen.height*0.8f, (Screen.width)*0.2f, (Screen.height)*0.17f);
		Objectivez.pixelInset = new Rect (Screen.width*0.78f, Screen.height*0.81f, (Screen.width)*0.2f, (Screen.height)*0.17f);
		textWindowz.pixelInset = new Rect (Screen.width*0f, Screen.height*0f, (Screen.width)*0.7f, (Screen.height)*0.37f);
		objectivesz.pixelInset = new Rect(Screen.width*0.75f,Screen.height*0.75f,(Screen.width)*-0.5f,(Screen.height)*-0.5f);
		itemHolderz.pixelInset = new Rect(Screen.width*0.0f, Screen.height*0.35f, (Screen.width)*0.2f, (Screen.height)*0.45f);
		
		displayTickerz.pixelOffset= new Vector2(Screen.width*0.27f,Screen.height*0.7f);

//		if(PlayerPrefs.GetInt("stopButton") == 1){
//			isDisableBt = false;
//		}
//		
//		if(PlayerPrefs.GetInt("stopButton") == 0){
//			isDisableBt = true;
//		}

		if(onQuest1a){//r
			showTicker("Find the\nHallway and\ntalk to the\nstudent at the\nlibrary");
			}

		if(isDisableBt){

		if (Input.touchCount > 0) {
			Touch t = Input.GetTouch (0);

			if (t.phase == TouchPhase.Began) {
				if (bt.HitTest (t.position, Camera.main)) {

						touch.stopMovements();
					if(NPC1){
							isHide = true;
							isTextWindow=true;//r
						////Debug.Log("Hit!");
						isButtonPressedNPC = true;
						if(onQuest1a == true){
							currentLine1++;
						}else{
							otherLine1++;
						}
					}
					
					if(Object1){
							isTextWindow=true;//r
							isHide = true;
						isButtonPressedObject = true;
						if(onQuest1b == true){
							currentLine++;
						}
					}
					
					if(NPC2){
							isHide = true;
							isTextWindow=true;//r
						isButtonPressedNPC = true;
						if(onQuest2 == true){
							currentLine2++;
						}else{
							otherLine1++;
						}
					}
					
					if(NPC3){
							isHide = true;
							isTextWindow=true;//r
						isButtonPressedNPC = true;
						if(onQuest3 == true){
							currentLine3++;
						}else{
							otherLine1++;
						}
					}
					
					if(NPC4){
						isHide = true;
						isTextWindow=true;//r
						isButtonPressedNPC = true;
						if(onQuest7 == true){
							currentLine4++;
						}else{
							otherLine1++;
						}
					}
					
					if(NPC5){
						isHide = true;
						isTextWindow=true;//r
						isButtonPressedNPC = true;
						if(onQuest8 == true){
							currentLine5++;
						}else{
							otherLine1++;
						}
					}

					if(NPC6){
						isHide = true;
						isTextWindow=true;//r
						isButtonPressedNPC = true;
						currentLine6++;
					}
					
					//Random Hits! //random here//
					if(Object2){
						if(onQuest6){
							randomNumber = Random.Range(1, 100);
							if(randomNumber > 50){
								hitcount++;
									wsQuest.displayEnd("Success");//r workshop quest dec11
									audio.PlayOneShot(clip[0]);
							}
							
							if(randomNumber < 51){
								hitcount = hitcount;
									wsQuest.displayEnd("Try Again");
							}
							waxModel();//r work here, on success hits and failed
						}
					}
					
					if(insta1){
						isButtonPressedObject = true;
						isTextWindow=true;//r
						transLine1++;
					}
					
					if(insta3){
						isPressedUnknown1 = true;
						isTextWindow=true;//r
						transLine2++;
					}
					
					//HideTextures();


				}
			}

		}

	}
		/*
		if (Input.GetMouseButtonDown (0)) {

			if (bt.HitTest (Input.mousePosition, Camera.main)) {

				if(NPC1){
					////Debug.Log("Hit!");
					isButtonPressedNPC = true;
					if(onQuest1a == true){
						currentLine1++;
					}else{
						otherLine1++;
					}
				}

				if(Object1){
					isButtonPressedObject = true;
					if(onQuest1b == true){
						currentLine++;
					}
				}

				if(NPC2){
					isButtonPressedNPC = true;
					if(onQuest2 == true){
						currentLine2++;
					}else{
						otherLine1++;
					}
				}

				if(NPC3){
					isButtonPressedNPC = true;
					if(onQuest3 == true){
						currentLine3++;
					}else{
						otherLine1++;
					}
				}

				if(NPC4){
					isButtonPressedNPC = true;
					if(onQuest7 == true){
						currentLine4++;
					}else{
						otherLine1++;
					}
				}

				if(NPC5){
					isButtonPressedNPC = true;
					if(onQuest8 == true){
						currentLine5++;
					}else{
						otherLine1++;
					}
				}

				//Random Hits!
				if(Object2){
					if(onQuest6){
						randomNumber = Random.Range(1, 100);
						if(randomNumber > 50){
							hitcount++;
						}

						if(randomNumber < 51){
							hitcount = hitcount;
						}
						waxModel();
					}
				}

				if(insta1){
					isButtonPressedObject = true;
					transLine1++;
				}

				if(insta3){
					isPressedUnknown1 = true;
					transLine2++;
				}

				isHide = true;
				//HideTextures();
			}
		}*/
		HideTextures();
		HideBt ();
		Transition();
		hideWax ();
		HideTextWindow();
	}

	void OnGUI(){
		GUI.skin.label = forFont;

		if(Object2){
			if(hitcount == 12){
				isHide = false;
				HideTextures();
				Object2 = false;
			}
		}

		if (isButtonPressedNPC) {
			if(NPC1){
				if(onQuest1a == true){

					if(currentLine1 < talkLinesNPC1.Length) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC1[currentLine1]+"\n");
					}else if(currentLine1 == 6){ //set to right amount of text in array
						touch.release();
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						isButtonPressedNPC = false;
						isHide = false;
						HideTextures();
						onQuest1a = false;
						onQuest1b = true;
						//O: Find a Book inside the library related to philosophy. 
						tickerMsg.displayStart("Find the book\nin the shelves\nrelated to\nphilosophy");
						newQuest.displayEnd(qUnlock);
						audio.PlayOneShot(clip[0]);
					}

				}else{
					if(otherLine1 == 1) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), "Good day to you. What a good library this is");
					}else{
						touch.release();
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						HideTextures();
					}
				}
			}

			if(NPC2){

				if(onQuest2 == true){
					if(currentLine2 < talkLinesNPC2.Length) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC2[currentLine2]+"\n");
					}else if(currentLine2 == 5){ //set to right amount of text in array //r was here dec6scriptinsert
						touch.release();
						isButtonPressedNPC = false;
						isHide = false;
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						HideTextures();
						onQuest2 = false;
						//continued with black screen indicating the end of scene where rizal is going to class first.
						hideTransition1 = false;
						StartCoroutine(myTransition1(5.0f));
						onTransition1 = true;
						//O:Go Outside,.
						tickerMsg.displayStart("Go back to\nyour room.");
						newQuest.displayEnd(qUnlock);
					}
				}else{
					if(otherLine1 == 1) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), "Attending class is pretty tiring.");
					}else{
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						touch.release();
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						HideTextures();
					}
				}
			}

			if(NPC3){
				if(onQuest3){
					if(currentLine3 < talkLinesNPC3.Length) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC3[currentLine3]+"\n");
					}else if(currentLine3 == 10){ //set to right amount of text in array

						touch.release();
						isButtonPressedNPC = false;
						isTextWindow=false;//r
						isHide = false;
						isDisableBt = false;
						isTrigShow = false;
						HideTextures();
						onQuest3 = false;
						onQuest4 = true;
						//O: Go to your room / New Objective after:@ Go to the Workshop.
						tickerMsg.displayStart("Go back to\nuniversity and\n go to your room.");
						newQuest.displayEnd(qUnlock);
						audio.PlayOneShot(clip[0]);
					}
				}else{
					if(otherLine1 == 1) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), "...");
					}else{
						isDisableBt = false;
						isTextWindow=false;//r
						isTrigShow = false;
						touch.release();
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						HideTextures();
					}
				}
			}

			if(NPC4){
				if(onQuest7){
					if(currentLine4 < talkLinesNPC4.Length) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC4[currentLine4]+"\n");
					}else if(currentLine4 == 8){ //set to right amount of text in array //R HERE DEC6
						changeGUITexture(false,"medal");//r where medal will be removed from the inventory
						touch.release();
						isButtonPressedNPC = false;
						isHide = false;
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						HideTextures();
						onQuest7 = false;
						hideTransition1 = false;
						Application.LoadLevel ("New Act 2 - Copy");
						StartCoroutine(myTransition3(10.0f));
						onQuest8 = true;
						NPC4 = false;
					
					}
				}else{
					if(otherLine1 == 1) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), "Oh are you joining the competition?");
					}else{
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						touch.release();
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						HideTextures();
					}
				}
			}

			if(NPC5){
				if(onQuest8){
					if(currentLine5 < talkLinesNPC5.Length) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC5[currentLine5]+"\n");
					}else if(currentLine5 == 11){ //set to right amount of text in array
						touch.release();
						isButtonPressedNPC = false;
						isHide = false;
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						HideTextures();
						onQuest8 = false;
						PlayerPrefs.SetInt("Set2", 1);
						Application.LoadLevel(levelToLoad);//r
						GameObject.FindWithTag("MainCamera").GetComponent<DontDestroy>().enabled=false;
						Destroy(GameObject.Find("Player"));
						Destroy(GameObject.FindWithTag("MainCamera"));
						Destroy(GameObject.Find("GUI-groupAct2"));
						Destroy(GameObject.Find("GUIControls"));
						MusicAudioListener.enabled=true;
					}
				}else{
					if(otherLine1 == 1) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), "....!?");
					}else{
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						touch.release();
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						HideTextures();
					}
				}
			}

			if(NPC6){
					if(currentLine6 < talkLinesNPC6.Length) {
					GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC6[currentLine6]+"\n");
					}else if(currentLine6 == 3){ //set to right amount of text in array
						isTextWindow=false;//r
						touch.release();
					    currentLine6 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						isDisableBt = false;
						isTrigShow = false;
						HideTextures();
					}
			}
		}

		if(isButtonPressedObject){

			if(Object1){
				if(onQuest1b){

					if(currentLine < talkLinesObject.Length) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesObject[currentLine]+"\n");
					}else if(currentLine == 2){ //set to right amount of text in array
						changeGUITexture(true,"book"); //r
						isTextWindow=false;//r
						isDisableBt = false;
						isTrigShow = false;
						touch.release();
						isButtonPressedObject = false;
						isHide = false;
						HideTextures();
						onQuest1b = false;
						onQuest2 = true;
						Object1 = false;
						//O: Head to the classroom and talk to the student about to take the class.
						tickerMsg.displayStart("Head to\nClassroom and\n talk to the\nstudent near the\nroom");//msgnot yet complete
						newQuest.displayEnd(qUnlock);
						audio.PlayOneShot(clip[0]);
					}
				}
			}

			if(insta1){
				if(onTransition1){
					if(transLine1 < transitionLines1.Length) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+transitionLines1[transLine1]+"\n");
					}else if(transLine1 == 3){ //set to right amount of text in array
						isDisableBt = false;
						isTrigShow = false;
						insta1 = false;
						isButtonPressedObject = false;
						onTransition1 = false;
						isHide = false;
						isTextWindow=false;//r
						HideTextures();
						touch.release();
						onQuest3 = true;
						//O: Visit Mother at prison.
						tickerMsg.displayStart("Visit mother\nin her cell\nby entering the" +
							"\njail\nat Downtown");
						newQuest.displayEnd(qUnlock);
						audio.PlayOneShot(clip[0]);
					}
				}
			}
		}

		if(isPressedUnknown1){
			if(insta3){
				if(onQuest5){
					if(transLine2 < transitionLines2.Length) {
						GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+transitionLines2[transLine2]+"\n");
					}else if(transLine2 == 2){ //set to right amount of text in array
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow=false;//r
						isButtonPressedObject = false;
						insta3 = false;
						isPressedUnknown1 = false;
						onQuest5 = false;
						isHide = false;
						HideTextures();
						touch.release();
						onQuest6 = true;
						//O: Go to a nearby molding workstation and start molding a design.
						tickerMsg.displayStart("go to a\nnearby molding\nstation and\nstart molding");
						newQuest.displayEnd(qUnlock);
						audio.PlayOneShot(clip[0]);
					}
				}
			}
		}

	}

	void HideBt() {

		if (isTrigShow) {
			
			GameObject.Find ("bt").guiTexture.enabled = true;
			
		} else {
			
			GameObject.Find ("bt").guiTexture.enabled = false;
			
		}

	}

	void HideTextures(){
		
		if (isHide) {
			
			GameObject.Find ("Single Joystick").guiTexture.enabled = false;
		} else {
			
			//example2.SetActive (true);
			
			GameObject.Find ("Single Joystick").guiTexture.enabled = true;
		}
	}

	void Transition(){//r

		if (hideTransition1) {
			GameObject.Find ("transition1").guiTexture.enabled = false;
			GameObject.Find("MonoText1").guiText.enabled = false;
			GameObject.Find("MonoText2").guiText.enabled = false;
			GameObject.Find("MonoText3").guiText.enabled = false;
			} else {
			GameObject.Find ("transition1").guiTexture.enabled = true;
		}
	}
	void HideTextWindow(){//text window/chatbox
		if (isTextWindow) {
			
			GameObject.Find ("Text Window").guiTexture.enabled = true;
			
		} else {
			
			GameObject.Find ("Text Window").guiTexture.enabled = false;
			
		}
	}
	
	void OnTriggerEnter2D(Collider2D col) {

		//Portals
		if (col.gameObject.tag == "Portal1") {
			DontDestroyOnLoad (this);
			Application.LoadLevel("Act2Scene3 - Copy");
			renderer.sortingOrder = 23;
			StartCoroutine(MyLoadLevelPortal1(0.0f));
		}

		if (col.gameObject.tag == "Portal2") {
			Application.LoadLevel("New Act 2 - Copy");
			//renderer.sortingOrder = 23;
			StartCoroutine(MyLoadLevelPortal2(0.0f));
		}

		if (col.gameObject.tag == "Portal3") {
			Application.LoadLevel("new Act 2 room 1");
			renderer.sortingOrder = 30;
			StartCoroutine(MyLoadLevelPortal3(0.0f));
		}

		if (col.gameObject.tag == "Portal4") {
			Application.LoadLevel("Act2Scene3 - Copy");
			renderer.sortingOrder = 23;
			StartCoroutine(MyLoadLevelPortal4(0.0f));
		}

		if (col.gameObject.tag == "Portal5") {
			Application.LoadLevel("Act2Scene1");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal5(0.0f));
		}

		if (col.gameObject.tag == "Portal6") {
			Application.LoadLevel("Act2Scene3 - Copy");
			renderer.sortingOrder = 23;
			StartCoroutine(MyLoadLevelPortal6(0.0f));
		}

		if (col.gameObject.tag == "Portal7") {
			Application.LoadLevel("new act 2 village");
			renderer.sortingOrder = 31;
			StartCoroutine(MyLoadLevelPortal7(0.0f));
		}

		if (col.gameObject.tag == "Portal8") {
			Application.LoadLevel("Act2Scene1");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal8(0.0f));
		}

		if (col.gameObject.tag == "Portal9") {
			Application.LoadLevel("new act 2 prison");
			renderer.sortingOrder = 23;
			StartCoroutine(MyLoadLevelPortal9(0.0f));
		}

		if (col.gameObject.tag == "Portal10") {
			Application.LoadLevel("new act 2 village");
			renderer.sortingOrder = 23;
			StartCoroutine(MyLoadLevelPortal10(0.0f));
		}

		if (col.gameObject.tag == "Portal11") {
			Application.LoadLevel("new act 2 prison room");
			renderer.sortingOrder = 23;
			StartCoroutine(MyLoadLevelPortal11(0.0f));
		}

		if (col.gameObject.tag == "Portal12") {
			Application.LoadLevel("new act 2 prison");
			renderer.sortingOrder = 23;
			StartCoroutine(MyLoadLevelPortal12(0.0f));
		}

		//NPCS

		if (col.gameObject.tag == "NPC1") {
			isDisableBt = true;
			isTrigShow = true;
			NPC1 = true;

		}

		if (col.gameObject.tag == "NPC2") {
			isDisableBt = true;
			isTrigShow = true;
			NPC2 = true;
			
		}

		if (col.gameObject.tag == "NPC3") {
			isDisableBt = true;
			isTrigShow = true;
			NPC3 = true;
			
		}

		if (col.gameObject.tag == "NPC4") {
			isDisableBt = true;
			isTrigShow = true;
			NPC4 = true;
			
		}

		if (col.gameObject.tag == "NPC5") {
			isDisableBt = true;
			isTrigShow = true;
			NPC5 = true;
			
		}

		if (col.gameObject.tag == "NPC6") {
			isDisableBt = true;
			isTrigShow = true;
			NPC6 = true;
			
		}
		if(onQuest1b){
			if (col.gameObject.tag == "Object1") {
				isDisableBt = true;
				isTrigShow = true;
				Object1 = true;
			}
		}

		if(onTransition1){
			if (col.gameObject.tag == "InstantLine1") {
				isDisableBt = true;
				touch.stopMovements();
				isTrigShow = true;
				isHide = true;
				HideTextures();
				insta1 = true;
			}
		}

		if(onQuest4){
			if (col.gameObject.tag == "InstantLine2") {

				touch.stopMovements();
				hideTransition1 = false;
				StartCoroutine(myTransition2(5.0f));
				onQuest4 = false;
			}
		}

		if(onQuest5){
			if (col.gameObject.tag == "InstantLine3") {
				isDisableBt = true;
				touch.stopMovements();
				isTrigShow = true;
				isHide = true;
				//HideTextures();
				insta3 = true;
			}
		}

		if(onQuest4 == false){
			if (col.gameObject.tag == "ActivateQuest5") {
				onQuest5 = true;
			}
		}

		if(onQuest6){
			if (col.gameObject.tag == "Object2") {
				
				touch.stopMovements();
				Object2 = true;
				isDisableBt = true;
				isTrigShow = true;
				isHide = true;
				isWax = true;
				//O: Hit the action button until your attempt is success no: of success 4
				//PART WHERE THE CLAY APPEARS!
				//HideTextures();
				tickerMsg.displayStart("Hit action button\nrepeatedly\nuntil hit is\nsuccess 4 times");
				newQuest.displayEnd(qUnlock);
				audio.PlayOneShot(clip[0]);
			}
		}


	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "NPC1") {
			
			isTrigShow = false;
			NPC1 = false;
			isDisableBt = false;
		}

		if (col.gameObject.tag == "NPC2") {
			
			isTrigShow = false;
			NPC2 = false;
			isDisableBt = false;
		}

		if (col.gameObject.tag == "NPC3") {
			isDisableBt = false;
			isTrigShow = false;
			NPC3 = false;
		}

		if (col.gameObject.tag == "NPC4") {
			isDisableBt = false;
			isTrigShow = false;
			NPC4 = false;
		}

		if (col.gameObject.tag == "NPC5") {
			isDisableBt = false;
			isTrigShow = false;
			NPC5 = false;
		}

		if (col.gameObject.tag == "NPC6") {
			isDisableBt = false;
			isTrigShow = false;
			NPC6 = false;
		}

		if(onQuest1b){
			if (col.gameObject.tag == "Object1") {
				isDisableBt = false;
				isTrigShow = false;
				Object1 = false;
			}
		}

		if (col.gameObject.tag == "Object2") {
			isDisableBt = false;
			isTrigShow = false;
			Object2 = false;
		}
	}

	IEnumerator MyLoadLevelPortal1(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (0.6596824f, -2.664423f, 0);
	}

	IEnumerator MyLoadLevelPortal2(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (2.177527f, 2.923866f, 0);
	}

	IEnumerator MyLoadLevelPortal3(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (25.5f, -17.35202f, 0);
	}

	IEnumerator MyLoadLevelPortal4(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-3.30838f, -2.135876f, 0);
	}

	IEnumerator MyLoadLevelPortal5(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-1.625588f, 0.7403867f, 0);
	}

	IEnumerator MyLoadLevelPortal6(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-4.607601f, -4.406934f, 0);
	}

	IEnumerator MyLoadLevelPortal7(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (5.566423f, -6.179237f, 0);
	}

	IEnumerator MyLoadLevelPortal8(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-12.10145f, -8.220387f, 0);
	}

	IEnumerator MyLoadLevelPortal9(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (1.800794f, -1.128926f, 0);
	}

	IEnumerator MyLoadLevelPortal10(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (2.945044f, -6.173144f, 0);
	}

	IEnumerator MyLoadLevelPortal11(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (2.844603f, 0.1942572f, 0);
	}

	IEnumerator MyLoadLevelPortal12(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-4.800722f, -1.894067f, 0);
	}

	IEnumerator myTransition1(float delay)
	{
		GameObject.Find("MonoText1").guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		hideTransition1 = true;
		transform.position = new Vector3 (14.73451f, -9.757868f, 0);
	}

	IEnumerator myTransition2(float delay)
	{
		GameObject.Find("MonoText2").guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		hideTransition1 = true;
		touch.release ();
		//o 2nd black!@ Go to Workshop
		tickerMsg.displayStart("Go to workshop\nlocated inside\nthe hallway\njust before the\nclassroom");
		newQuest.displayEnd(qUnlock);
		audio.PlayOneShot(clip[0]);
	}

	IEnumerator myTransition3(float delay)
	{
		GameObject.Find("MonoText3").guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		hideTransition1 = true;
		onQuest8 = true;
		touch.release ();
		transform.position = new Vector3 (2.19317f, 1.42181f, 0);
		//O: TALK TO YOUR BROTHER TO GET YOUR PASSPORT.
		tickerMsg.displayStart("Meet your\nbrother outside.\nFind him at\nthe central town");
		newQuest.displayEnd(qUnlock);
		audio.PlayOneShot(clip[0]);
	}
	//r
	void showTicker(string itemToget){
		tickerMsg.displayStart(itemToget);//r at 1st scene ticker
	}

	void changeGUITexture(bool toBeDisplayed,string label)//r function responsible for showing questsitems on gui
	{
		GameObject.Find("GUITexture_"+label).guiTexture.enabled = toBeDisplayed;
	}
}
