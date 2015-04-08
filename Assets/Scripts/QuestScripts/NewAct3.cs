using UnityEngine;
using System.Collections;

public class NewAct3 : MonoBehaviour {

	private PlayerMovements touch;
	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene

	public float xLabel; //r
	public float yLabel;

//	//Pixel Resizing
//	public GUITexture buttonsA;
//	public GUITexture Acts;
	public GUITexture Objectivez;
//	public GUITexture textWindowz;
//	//	public GUITexture controllerz;
//	public GUITexture objectivesz;
//	public GUITexture itemHolderz;
//	public GUIText displayTickerz;

	public AudioClip[] clip;//r array of sound effects
	public GUIStyle forFont;

	public GUITexture bt;
	public GUITexture Transition1;
	//public GUITexture rizalTexture;


	public int otherLine1 = 0;
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
	public string[] talkLinesNPC7;
	public int currentLine7 = 0;

	//checkers
	private bool isTrigShow = false;
	public bool isHide = false;
	private bool isButtonPressedNPC = false;
	private bool isDisableBt = false;
	private bool isTextWindow = false;

	public bool onQuest1 = true;
	public bool onQuest2 = false;
	public bool onQuest3 = false;
	public bool onQuest4 = false;
	public bool onQuest5 = false;
	public bool onQuest6 = false;
	public bool onQuest7 = false;
	public bool onQuestFinish = false;

	private bool hideTransition1 = false;
	//NPC / OBJECTS
	private bool NPC1 = false;
	private bool NPC2 = false;
	private bool NPC3 = false;
	private bool NPC4 = false;
	private bool NPC5 = false;
	private bool NPC6 =false;

	//tickermessage
	private TickerMessage tickerMsg;
	private QuestUnlocked newQuest;
	private string qunlock = "Quest Unlocked!";

	void Awake(){
		touch = GameObject.Find("Player").GetComponent<PlayerMovements>();
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>();
		newQuest = GameObject.Find ("GUIQUnlock").GetComponent<QuestUnlocked>();
		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r //comment this if you are about to edit the scene
		//rizalTexture = GameObject.Find("MonoText1").GetComponent<GUITexture>();
	}

	void disableBt(){
		
		isDisableBt = false;
		
	}


	void enableBt(){
		
		isDisableBt = true;
		
	}

	void Start () {
		MusicAudioListener.enabled=false;
		PlayerPrefs.SetInt("stopButton", 0);
		//Transition ();
		//GameObject.Find("Main Camera").GetComponent<CameraFollow>().enabled=true;
		newQuest.displayEnd(qunlock);
		audio.PlayOneShot(clip[0]);

	}

	void Update () {

//		if(PlayerPrefs.GetInt("stopButton") == 1){
//			isDisableBt = false;
//		}
//		
//		if(PlayerPrefs.GetInt("stopButton") == 0){
//			isDisableBt = true;
//		}


		//r shortcut quests in bool
		
//		buttonsA.pixelInset = new Rect (Screen.width*0.85f, Screen.height*0.1f, (Screen.width)*0.1f, (Screen.height)*0.18f);
//		Acts.pixelInset = new Rect (Screen.width*0.51f, Screen.height*1.3f, (Screen.width)*-0.81f, (Screen.height)*-0.82f);//0.71
		Objectivez.pixelInset = new Rect (Screen.width*0.78f, Screen.height*0.81f, (Screen.width)*0.2f, (Screen.height)*0.17f); //GUI OBJECTIVES
//		textWindowz.pixelInset = new Rect (Screen.width*0f, Screen.height*0f, (Screen.width)*0.7f, (Screen.height)*0.37f);
//		objectivesz.pixelInset = new Rect(Screen.width*0.75f,Screen.height*0.75f,(Screen.width)*-0.5f,(Screen.height)*-0.5f);//BACKGROUND OBJECTIVES
//		itemHolderz.pixelInset = new Rect(Screen.width*0.0f, Screen.height*0.35f, (Screen.width)*0.2f, (Screen.height)*0.45f);
//		
//		displayTickerz.pixelOffset= new Vector2(Screen.width*0.27f,Screen.height*0.7f);
//		
//


		if (onQuest1){
			showTicker("Go to UNIVERSITY OF\nMADRID and talk to\nthe RECEPTIONIST");
		}
		if(onQuestFinish){
				newQuest.displayEnd("Quest Finished!");
			showTicker ("");
			}


		if(isDisableBt == true){
		if (Input.touchCount > 0) {
			Touch t = Input.GetTouch (0);

			if (t.phase == TouchPhase.Began) {
				if (bt.HitTest (t.position, Camera.main)) {
						touch.stopMovements();
					if(NPC1){
						isButtonPressedNPC = true;
						isTextWindow=true;
						if(onQuest1 == true){
							currentLine1++;
						}else if(onQuest6 == true){
							currentLine6++;
						}else{
							otherLine1++;
						}
					}
					
					if(NPC2){
						isButtonPressedNPC = true;
							isTextWindow=true;
						if(onQuest2 == true){
							currentLine2++;
						}else{
							otherLine1++;
						}
					}
					
					if(NPC3){
						isButtonPressedNPC = true;
							isTextWindow=true;
						if(onQuest3 == true){
							currentLine3++;
						}else{
							otherLine1++;
						}
					}
					
					if(NPC4){
						isButtonPressedNPC = true;
							isTextWindow=true;
						if(onQuest4 == true){
							currentLine4++;
						}else{
							otherLine1++;
						}
					}
					
					if(NPC5){
						isButtonPressedNPC = true;
							isTextWindow=true;
						if(onQuest5 == true){
							currentLine5++;
						}else{
							otherLine1++;
						}
					}
					
					if(NPC6){
						isButtonPressedNPC = true;
							isTextWindow=true;
						if(onQuest7 == true){
							currentLine7++;
						}else{
							otherLine1++;
						}
					}
					isHide = true;
				}

			}

		}
	}
		/*
		if (Input.GetMouseButtonDown (0)) {
			
			if (bt.HitTest (Input.mousePosition, Camera.main)) {
				if(NPC1){
					isButtonPressedNPC = true;
					if(onQuest1 == true){
						currentLine1++;
					}else if(onQuest6 == true){
						currentLine6++;
					}else{
						otherLine1++;
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
					if(onQuest4 == true){
						currentLine4++;
					}else{
						otherLine1++;
					}
				}

				if(NPC5){
					isButtonPressedNPC = true;
					if(onQuest5 == true){
						currentLine5++;
					}else{
						otherLine1++;
					}
				}

				if(NPC6){
					isButtonPressedNPC = true;
					if(onQuest7 == true){
						currentLine7++;
					}else{
						otherLine1++;
					}
				}

				isHide = true;
			}
		}
		*/

		Transition ();
		HideTextures ();
		HideBt ();
		HideTextWindow();
	}

	void OnGUI(){

		GUI.skin.label=forFont; //style r

		if (isButtonPressedNPC == true) {
			if (NPC1) {
				if (onQuest1 == true) {
					if (currentLine1 < talkLinesNPC1.Length) {
//						GUI.contentColor=Color.red;//color
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC1 [currentLine1] + "\n");

					} else if (currentLine1 == 5) { //set to right amount of text in array //reflects all script or talklines in the inspector!
						isButtonPressedNPC = false;
						isTextWindow = false;
						NPC1 = false;
						isHide = false;
						isTrigShow = false;
						onQuest1 = false;
						onQuest2 = true;
						hideTransition1 = true;
						isDisableBt = false;
						StartCoroutine(myTransition1(5.0f));
						//
						showTicker("FIND the Head of\nMasonry by\ngathering CLUES\nStart at the SHIP PORT");
						newQuest.displayEnd("New Quest Unlocked");

					}
				
				} else if (onQuest6 == true){ //collab* Quest before finding professor
					if (currentLine6 < talkLinesNPC6.Length) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC6 [currentLine6] + "\n");
					} else if (currentLine6 == 8) { //set to right amount of text in array
						isDisableBt = false;
						isButtonPressedNPC = false;
						isHide = false;
						isTrigShow = false;
						isTextWindow = false;
						onQuest6 = false;
						onQuest7 = true;
						touch.release();
						//
						showTicker ("The receptionist told\nyou the whereabouts of\nthe PROFESSOR. Go to a\nWater Fountain");
						newQuest.displayEnd("New Quest Unlocked");

					}
				} else {
					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Hello. This is University of Central Madrid.");
					} else {
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						touch.release();
					}
				}
			}

			if (NPC2) {
				if (onQuest2 == true) {
					if (currentLine2 < talkLinesNPC2.Length) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC2 [currentLine2] + "\n");
					} else if (currentLine2 == 5) { //set to right amount of text in array
						isDisableBt = false;
						isTextWindow = false;
						isButtonPressedNPC = false;
						isHide = false;
						isTrigShow = false;
						onQuest2 = false;
						onQuest3 = true;
						touch.release();
						showTicker("FIND the Head\nof Masonry by\nGathering CLUES");
					}
					
				} else {
					if (otherLine1 == 1) {
//						GUI.contentColor=Color.red;
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Oh Are you new here? I know alot of people in this town but not a university, try looking further.");
					} else {
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						touch.release();
					}
				}
			}

			if (NPC3) {
				if (onQuest3 == true) {
					if (currentLine3 < talkLinesNPC3.Length) {
//						GUI.contentColor=Color.red;
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC3 [currentLine3] + "\n");
					} else if (currentLine3 == 8) { //set to right amount of text in array
						isDisableBt = false;
						isTextWindow = false;
						isButtonPressedNPC = false;
						isHide = false;
						isTrigShow = false;
						onQuest3 = false;
						onQuest4 = true;
						touch.release();
						showTicker("Head to UNIVERSITY OF\nMADRID");
					}
					
				} else {
					if (otherLine1 == 1) {
//						GUI.contentColor=Color.red;
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Madrid is really a beautiful ciy. \ni hope you enjoyed your stay here.");
					} else {
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						touch.release();
					}
				}
			}

			if (NPC4) {
				if (onQuest4 == true) {
					if (currentLine4 < talkLinesNPC4.Length) {
//						GUI.contentColor=Color.red;
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC4 [currentLine4] + "\n");
					} else if (currentLine4 == 9) { //set to right amount of text in array
						isDisableBt = false;
						isButtonPressedNPC = false;
						isTextWindow = false;
						isHide = false;
						isTrigShow = false;
						onQuest4 = false;
						onQuest5= true;
						touch.release();
						newQuest.displayEnd(qunlock);
						audio.PlayOneShot(clip[0]);
						showTicker("Go to the\nFreemasonry LOUNGE\nlocated at UPTOWN.");//r guard
					}
					
				} else {
					if (otherLine1 == 1) {
//						GUI.contentColor=Color.red;
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Head of what? Try going back to the Port Dock she knows alot of information.");
					} else {
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						touch.release();
					}
				}
			}

			if (NPC5) {
				if (onQuest5 == true) {
					if (currentLine5 < talkLinesNPC5.Length) {
//						GUI.contentColor = Color.white;
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC5 [currentLine5] + "\n");
					} else if (currentLine5 == 9) { //set to right amount of text in array
						isDisableBt = false;
						NPC5 = false;
						isButtonPressedNPC = false;
						isTextWindow = false;
						isHide = false;
						isTrigShow = false;
						onQuest5 = false;
						onQuest6 = true;
						hideTransition1 = true;
						StartCoroutine(myTransition2(5.0f));
					}
					
				} else {
					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "...");
					} else {
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						touch.release();
					}
				}
			}

			//Professor
			if (NPC6) {
				if (onQuest7 == true) {
					if (currentLine7 < talkLinesNPC7.Length) {
//						GUI.contentColor=Color.red;
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC7 [currentLine7] + "\n");
					} else if (currentLine7 == 10) { //set to right amount of text in array
						isDisableBt = false;
						NPC6 = false;
						isTextWindow = false;
						isButtonPressedNPC = false;
						isHide = false;
						isTrigShow = false;
						onQuest7 = false;
						onQuestFinish = true;
						touch.release();
						Application.LoadLevel("FOOFOOFOO6");//to be edited.
						//Destroy(this);
						//GameObject.FindWithTag("Player").GetComponent<DontDestroy>().enabled=false;//testrun //r destroying player
						GameObject.FindWithTag("MainCamera").GetComponent<DontDestroy>().enabled=false;
						//GameObject.Find("GUIControls").GetComponent<DontDestroy>().enabled=false;
						Destroy(GameObject.Find("Player"));
						Destroy(GameObject.FindWithTag("MainCamera"));
						Destroy(GameObject.Find("GUI-groupAct3"));
						Destroy(GameObject.Find("GUIControls"));
						GameObject.FindWithTag("transition1").GetComponent<DontDestroy>().enabled=false;
						Destroy(GameObject.Find("transition1"));
						MusicAudioListener.enabled=true;
					}
					
				} else {
					if (otherLine1 == 1) {
//						GUI.contentColor=Color.red;
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "This fountain is my favorite place.\n What about you?");
					} else {
						isDisableBt = false;
						isTrigShow = false;
						isTextWindow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						touch.release();
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

	void Transition(){
		
		if (hideTransition1 == false) {
			GameObject.Find ("transition1").guiTexture.enabled = false;
			GameObject.Find("MonoText1").guiText.enabled = false;
			GameObject.Find("MonoText2").guiText.enabled = false;
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

		if (col.gameObject.tag == "Portal1") {
			DontDestroyOnLoad (this);
			Application.LoadLevel("New Act 3 Scene 2");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal1(0.0f));
		}

		if (col.gameObject.tag == "Portal2") {
			Application.LoadLevel("New Act 3 Scene 1 - Copy");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal2(0.0f));
		}

		if (col.gameObject.tag == "Portal3") {
			Application.LoadLevel("New Act 3 Scene 4");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal3(0.0f));
		}

		if (col.gameObject.tag == "Portal4") {
			Application.LoadLevel("New Act 3 Scene 2");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal4(0.0f));
		}

		if (col.gameObject.tag == "Portal5") {
			Application.LoadLevel("New Act 3 Scene 3");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal5(0.0f));
		}

		if (col.gameObject.tag == "Portal6") {
			Application.LoadLevel("New Act 3 Scene 2");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal6(0.0f));
		}

		if (col.gameObject.tag == "Portal7") {
			Application.LoadLevel("New Act 3 Scene 5");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal7(0.0f));
		}

		if (col.gameObject.tag == "Portal8") {
			Application.LoadLevel("New Act 3 Scene 3");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal8(0.0f));
		}

		if (col.gameObject.tag == "Portal9") {
			Application.LoadLevel("New Act 3 Scene 6");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal9(0.0f));
		}

		if (col.gameObject.tag == "Portal10") {
			Application.LoadLevel("New Act 3 Scene 5");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal10(0.0f));
		}

		//NPC

		if(col.gameObject.tag == "NPC1"){
			isDisableBt = true;
			isTrigShow = true;
			NPC1 = true;
		}

		if(col.gameObject.tag == "NPC2"){
			isDisableBt = true;
			isTrigShow = true;
			NPC2 = true;
		}

		if(col.gameObject.tag == "NPC3"){
			isDisableBt = true;
			isTrigShow = true;
			NPC3 = true;
		}

		if(col.gameObject.tag == "NPC4"){
			isDisableBt = true;
			isTrigShow = true;
			NPC4 = true;
		}

		if(col.gameObject.tag == "NPC5"){
			isDisableBt = true;
			isTrigShow = true;
			NPC5 = true;
		}

		if(col.gameObject.tag == "NPC6"){
			isDisableBt = true;
			isTrigShow = true;
			NPC6 = true;
		}
	}

	void OnTriggerExit2D(Collider2D col) {

		if(col.gameObject.tag == "NPC1"){
			isDisableBt = false;
			isTrigShow = false;
			NPC1 = false;
		}

		if(col.gameObject.tag == "NPC2"){
			isDisableBt = false;
			isTrigShow = false;
			NPC2 = false;
		}

		if(col.gameObject.tag == "NPC3"){
			isDisableBt = false;
			isTrigShow = false;
			NPC3 = false;
		}

		if(col.gameObject.tag == "NPC4"){
			isDisableBt = false;
			isTrigShow = false;
			NPC4 = false;
		}

		if(col.gameObject.tag == "NPC5"){
			isDisableBt = false;
			isTrigShow = false;
			NPC5 = false;
		}

		if(col.gameObject.tag == "NPC6"){
			isDisableBt = false;
			isTrigShow = false;
			NPC6 = false;
		}
	}

	IEnumerator MyLoadLevelPortal1(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (15.73955f, -6.95841f, 0);
	}

	IEnumerator MyLoadLevelPortal2(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-5.447779f, 1.329168f, 0);
	}

	IEnumerator MyLoadLevelPortal3(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (7.223224f, -5.444242f, 0);
	}

	IEnumerator MyLoadLevelPortal4(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (0.09640121f, -8.400352f, 0);
	}

	IEnumerator MyLoadLevelPortal5(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-2.514202f, -12.93902f, 0);
	}

	IEnumerator MyLoadLevelPortal6(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (11.80366f, -3.156478f, 0);
	}

	IEnumerator MyLoadLevelPortal7(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-2.916206f, -1.093445f, 0);
	}

	IEnumerator MyLoadLevelPortal8(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (11.80366f, -3.156478f, 0);
	}

	IEnumerator MyLoadLevelPortal9(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (0.07812309f, -0.7475061f, 0);
	}

	IEnumerator MyLoadLevelPortal10(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-0.2898424f, -2.605816f, 0);
	}
	//1st Black Screen
	IEnumerator myTransition1(float delay)
	{
		GameObject.Find("MonoText1").guiText.enabled = true;
		//GameObject.Find("MonoText1").GetComponent<GUITexture>().enabled = true;
		yield return new WaitForSeconds(delay);
		hideTransition1 = false;
		newQuest.displayEnd(qunlock);//r first blackscreen
		audio.PlayOneShot(clip[0]);
		Application.LoadLevel("New Act 3 Scene 2");
		transform.position = new Vector3 (0.09640121f, -8.400352f, 0);
		touch.release();
	}
	//2nd Black Screen
	IEnumerator myTransition2(float delay)
	{
		GameObject.Find("MonoText2").guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		hideTransition1 = false;
		newQuest.displayEnd(qunlock);//r 2nd blackscreen
		audio.PlayOneShot(clip[0]);
		showTicker ("Go to the\n RECEPTIONIST");
		Application.LoadLevel("New Act 3 Scene 2");
		transform.position = new Vector3 (0.09640121f, -8.400352f, 0);
		touch.release();
	}
	//r
	void showTicker(string itemToget){
		tickerMsg.displayStart(itemToget);//r at 1st scene ticker
	}
	IEnumerator shortDelay(float delay)
	{
		yield return new WaitForSeconds(delay);
	}
}
