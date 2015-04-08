using UnityEngine;
using System.Collections;

public class NewAct3Part2 : MonoBehaviour {

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


	public AudioClip[] clip;
	public GUIStyle forFont;

	public GameObject Cam;
	public GameObject guiGroup;
	public GameObject Play;
	public GameObject Control;

	public PlayerMovements touch;
	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene

	public GUITexture bt;

	public int books = 0;
	public int pen = 0;

	public int otherLine1 = 0;
	public string[] talkLinesNPC1;
	public int currentLine1 = 0;
	public string[] talkLinesNPC2;
	public int currentLine2 = 0;
	public string[] talkLinesNPC3;
	public int currentLine3 = 0;
	public string[] talkLinesNPC4;
	public int currentLine4 = 0;
	public string[] talkLinesNPC4extended;
	public int currentLine4extended = 0;
	public string[] talkLinesNPC5;
	public int currentLine5 = 0;
	public string[] talkLinesNPC6;
	public int currentLine6 = 0;
	public string[] talkLinesNPC7;
	public int currentLine7 = 0;
	public string[] talkLinesNPC6extended;
	public int currentLine6extended = 0;
	public string[] talkLinesNPC7extended;
	public int currentLine7extended = 0;
	public string[] talkLinesNPC8;
	public int currentLine8 = 0;
	public string[] talkLinesNPC9;
	public int currentLine9 = 0;
	public string[] talkLinesNPC10;
	public int currentLine10 = 0;
	public string[] talkLinesNPC9extended;
	public int currentLine9extended = 0;

	//for the objects talklines!
	public string[] talkLinesObject1;
	public int currentLineObject1 = 0;
	public string[] talkLinesObject2;
	public int currentLineObject2 = 0;

	//Quests
	public bool onQuest1 = true;
	public bool onQuest2 = false;
	public bool onQuest3 = false;
	public bool onQuest4 = false;
	public bool onQuest5 = false;
	public bool onQuest6 = false;
	public bool onQuest7 = false;
	public bool onQuest8 = false;
	public bool onQuest9 = false;
	public bool onQuest10 = false;
	public bool onQuest11 = false;
	public bool onQuest12 = false;
	public bool onQuest13 = false;
	public bool onQuest14 = false;
	public bool onQuest15 = false;
	//Objects
	public bool Object1 = false;
	public bool Object2 = false;

	//NPCS
	private bool NPC1 =  false;
	private bool NPC2 = false;
	private bool NPC3 = false;
	private bool NPC4 = false;
	private bool NPC5 = false;
	private bool NPC6 = false;
	private bool NPC7 = false;
	private bool NPC8 = false;
	private bool NPC9 = false;
	private bool NPC10 = false;
	//Checkers
	private bool isTrigShow = false;
	public bool isHide = false;
	private bool isButtonPressedNPC = false;
	//private bool isPortalShow = false;
	private bool isDisableBt = false;
	private bool isTextWindow = false;

	//tickermessage
	private TickerMessage tickerMsg;
	private QuestUnlocked newQuest;
	private string qunlock = "New Quest Unlocked!";

	private bool hideTransition1 = false;
	// Use this for initialization

	void onPortal(){
		PlayerPrefs.SetInt ("Portal5", 1);

	}

	void Transition(){
		
		if (hideTransition1 == false) {
			GameObject.Find ("transition1").guiTexture.enabled = false;
			GameObject.Find("MonoText1").guiText.enabled = false;
			GameObject.Find("MonoText2").guiText.enabled = false;
			GameObject.Find("MonoText3").guiText.enabled = false;
		} else {
			GameObject.Find ("transition1").guiTexture.enabled = true;
		}
	}

	void Awake(){
		touch = GameObject.Find("Player").GetComponent<PlayerMovements>();
		PlayerPrefs.SetInt ("Books", 0);
		PlayerPrefs.SetInt ("Pen", 0);
		PlayerPrefs.SetInt ("Portal5", 0);
		//tickers
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>();
		newQuest = GameObject.Find ("GUIQUnlock").GetComponent<QuestUnlocked>();
		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r //comment this if you are about to edit the scene
	}

	void Start () {
		MusicAudioListener.enabled=false;
		PlayerPrefs.SetInt("stopButton", 0);
		newQuest.displayEnd(qunlock);
		audio.PlayOneShot(clip[0]);
		//GameObject.Find ("portalname_clinic").SetActive(false);
		changeGUITexture(false,"books");
		changeGUITexture(false,"pen");
	}

	void disableBt(){
		
		isDisableBt = false;
		
	}
	
	
	void enableBt(){
		
		isDisableBt = true;
		
	}
	
	// Update is called once per frame
	void Update () {

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

//		if(PlayerPrefs.GetInt("stopButton") == 1){
//			isDisableBt = false;
//		}
//		
//		if(PlayerPrefs.GetInt("stopButton") == 0){
//			isDisableBt = true;
//		}

		//r shortcut quests in bool
		if (onQuest1){
			showTicker("Find OTTO BECKER\nby TALKING to different\nPEOPLE");
		}
		if(isDisableBt){
		if (Input.touchCount > 0) {
			Touch t = Input.GetTouch (0);

			if(t.phase == TouchPhase.Began){
				if (bt.HitTest (t.position, Camera.main)) {
					touch.stopMovements();
				if(NPC1){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest1 == true){
						currentLine1++;
					} else if (onQuest5 == true){
						getItems();
						if(pen == 0){

							currentLineObject2++;
						} else{

							otherLine1++;
						}
					} else {

						otherLine1++;
					}
				}
				
				if(NPC2){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest2 == true){
						currentLine2++;
					} else if (onQuest5 == true){
						getItems();
						if(books == 0){

							currentLineObject1++;
						} else{

							otherLine1++;
						}
					} else {

						otherLine1++;
					}
				}
				
				if(NPC3){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest3 == true){
						currentLine3++;
					} else {
						otherLine1++;
					}
				}
				
				if(NPC4){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest4 == true){
						currentLine4++;
					} else if (onQuest5 == true){
						getItems();
						if(books == 1 && pen == 1){

							currentLine4extended++;
						} else {
							otherLine1++;
						}
					} else {
						otherLine1++;
					}
				}
				
				if(NPC5){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest6 == true){
						currentLine5++;
					} else {
						otherLine1++;
					}
				}
				
				if(NPC6){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest7 == true){
						currentLine6++;
					} else if(onQuest9 == true){
						currentLine6extended++;
					} else {
						otherLine1++;
					}
				}
				
				if(NPC7){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest8 == true){
						currentLine7++;
					} else if(onQuest10){
						currentLine7extended++;
					} else {
						otherLine1++;
					}
				}
				
				if(NPC8){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest11 == true){
						currentLine8++;
					} else {
						otherLine1++;
					}
				}
				
				if(NPC9){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest12 == true){
						currentLine9++;
					} else if (onQuest15){
						currentLine9extended++;
					} else {
						otherLine1++;
					}
				}
				
				if(NPC10){
					isButtonPressedNPC = true;
							isTextWindow=true;
					if(onQuest13 == true){
						currentLine10++;
					} else {
						otherLine1++;
					}
				}
				
				isHide = true;
			}
			}
		}
	}
		//if (Input.GetMouseButtonDown (0)) {
			
			//if (bt.HitTest (Input.mousePosition, Camera.main)) {
			
//				if(NPC1){
//					isButtonPressedNPC = true;
//					if(onQuest1 == true){
//						currentLine1++;
//					} else if (onQuest5 == true){
//						getItems();
//						if(pen == 0){
//							currentLineObject2++;
//						} else{
//							otherLine1++;
//						}
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC2){
//					isButtonPressedNPC = true;
//					if(onQuest2 == true){
//						currentLine2++;
//					} else if (onQuest5 == true){
//						getItems();
//						if(books == 0){
//							currentLineObject1++;
//						} else{
//							otherLine1++;
//						}
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC3){
//					isButtonPressedNPC = true;
//					if(onQuest3 == true){
//						currentLine3++;
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC4){
//					isButtonPressedNPC = true;
//					if(onQuest4 == true){
//						currentLine4++;
//					} else if (onQuest5 == true){
//						getItems();
//						if(books == 1 && pen == 1){
//							currentLine4extended++;
//						} else {
//							otherLine1++;
//						}
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC5){
//					isButtonPressedNPC = true;
//					if(onQuest6 == true){
//						currentLine5++;
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC6){
//					isButtonPressedNPC = true;
//					if(onQuest7 == true){
//						currentLine6++;
//					} else if(onQuest9 == true){
//						currentLine6extended++;
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC7){
//					isButtonPressedNPC = true;
//					if(onQuest8 == true){
//						currentLine7++;
//					} else if(onQuest10){
//						currentLine7extended++;
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC8){
//					isButtonPressedNPC = true;
//					if(onQuest11 == true){
//						currentLine8++;
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC9){
//					isButtonPressedNPC = true;
//					if(onQuest12 == true){
//						currentLine9++;
//					} else if (onQuest15){
//						currentLine9extended++;
//					} else {
//						otherLine1++;
//					}
//				}
//
//				if(NPC10){
//					isButtonPressedNPC = true;
//					if(onQuest13 == true){
//						currentLine10++;
//					} else {
//						otherLine1++;
//					}
//				}
//
//				isHide = true;
			//}
				
		//}
		HideBt ();
		HideTextures ();
		Transition ();
		HideTextWindow();
	}

	void OnGUI(){
		GUI.skin.label=forFont; //style r

		if(isButtonPressedNPC){
			if(NPC1){
				if(onQuest1){
					if (currentLine1 < talkLinesNPC1.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC1 [currentLine1] + "\n");
					} else if (currentLine1 == 10) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC1 = false;
						isHide = false;
						isTrigShow = false;
						onQuest1 = false;
						onQuest2 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("Head EAST PORTAL find\nMORE INFO about BECKER");

					}
				} else if(onQuest5){
					if(pen == 0){
						Object2 = true;
						if (currentLineObject2 < talkLinesObject2.Length) {
							   
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesObject2 [currentLineObject2] + "\n");
						} else if (currentLineObject2 == 8) { //set to right amount of text in array
							isButtonPressedNPC = false;
							isTextWindow=false;
							NPC1 = false;
							isHide = false;
							isTrigShow = false;
							saveItems();
							touch.release();
							isDisableBt = false;
							//PEN
							changeGUITexture(true,"pen");
							showTicker("You now\nhave the\npen!");
						}
					} else {
						if (otherLine1 == 1) {
							   
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Say thanks for me. That pen was good.");
						} else {
							NPC1 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							touch.release();
							isDisableBt = false;
							showTicker("Find the girl\nunder a tree\nshe has the book");
						}
					}
				} else{
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Welcome to Berlin tourist.\nI hope you enoy your stay here");
					} else {
						NPC1 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
						isDisableBt = false;
					}
				}
			}

			if(NPC2){
				if(onQuest2){
					if (currentLine2 < talkLinesNPC2.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC2 [currentLine2] + "\n");
					} else if (currentLine2 == 5) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC2 = false;
						isHide = false;
						isTrigShow = false;
						onQuest2 = false;
						onQuest3 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("go UPTOWN just north\nof TOWN ENTRANCE FIND the\nLADY beside the house");
					}
				} else if(onQuest5){
					if(books == 0){
						Object1 = true;
						if (currentLineObject1 < talkLinesObject1.Length) {
							   
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesObject1 [currentLineObject1] + "\n");
						} else if (currentLineObject1 == 8) { //set to right amount of text in array
							isButtonPressedNPC = false;
							isTextWindow=false;
							NPC2 = false;
							isHide = false;
							isTrigShow = false;
							saveItems();
							touch.release();
							isDisableBt = false;
							//BOOKS 8LINES
							changeGUITexture(true,"books");
							showTicker("Great!\nYou got\nthe book!");
						}
					} else {
						if (otherLine1 == 1) {
							   
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "You got the Books say hi for me.");
						} else {
							NPC2 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							touch.release();
							isDisableBt = false;
							showTicker("The pen\nwas borrowed\nby a man");
						}
					}
				} else{
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Isn't nice to stand near a tree?");
					} else {
						NPC2 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
						isDisableBt = false;
					}
				}
			}

			if(NPC3){
				if(onQuest3){
					if (currentLine3 < talkLinesNPC3.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC3 [currentLine3] + "\n");
					} else if (currentLine3 == 6) { //set to right amount of text in array
						isButtonPressedNPC = false;
						NPC3 = false;
						isHide = false;
						isTrigShow = false;
						isTextWindow=false;
						onQuest3 = false;
						onQuest4 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("Talk to\nthe man\nbeside the\nfountain");
					}
				} else{
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Oh a foreigner? Are you a doctor?");
					} else {
						NPC3 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
						isDisableBt = false;
					}
				}
			}

			if(NPC4){
				if(onQuest4){
					   
					if (currentLine4 < talkLinesNPC4.Length) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC4 [currentLine4] + "\n");
					} else if (currentLine4 == 18) { //set to right amount of text in array
						isButtonPressedNPC = false;
						NPC4 = false;
						isHide = false;
						isTrigShow = false;
						isTextWindow=false;
						onQuest4 = false;
						onQuest5 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("Bring the book and pen\nof the man borrowed by\nhis friends");
					}

				} else if(onQuest5){

					if(books == 1 && pen == 1){
						showTicker("Great!\nBring the\nitems to the\nman near the\nfountain");//feb28raygon
						if (currentLine4extended < talkLinesNPC4extended.Length) {
							   
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC4extended [currentLine4extended] + "\n");
						} 

						if (currentLine4extended == 7) { //set to right amount of text in array
							//Debug.Log("OIIII");
							isButtonPressedNPC = false;
							isTextWindow=false;
							NPC4 = false;
							isHide = false;
							isTrigShow = false;
							onQuest5 = false;
							onQuest6 = true;
							onPortal();
							touch.release();
							isDisableBt = false;
							//
							showTicker("OTTO BECKER's CLINIC\nis located at\nTOWN ENTRANCE");
						}
					} else if (books == 0 && pen == 1){
						if (otherLine1 == 1) {
							   
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Where's the books?");
						} else {
							NPC4 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							touch.release();
							isDisableBt = false;
							//

							showTicker("Find the girl\nbeside the shady tree\nshe has the book");
						}
					} else if (books == 1 && pen == 0){
						 //
						if (otherLine1 == 1) {
							   
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Where's the pen?");
						} else {
							NPC4 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							touch.release();
							isDisableBt = false;
							//
							showTicker("Find the man\nat the Town Entrance,\nHe has the pen");
						}
					} else {
						if (otherLine1 == 1) {
							   
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Where's the pen and books?");
						} else {
							NPC4 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							touch.release();
							isDisableBt = false;
							//
							showTicker("Bring the book and pen\nto him TALK to his\nfriends from SOUTH");
						}
					}

				} else {
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Did you come from spain?\ni heard there was a visitor that was recommended here.");
					} else {
						NPC4 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
						isDisableBt = false;
					}
				}
			}

			if(NPC5){
				if(onQuest6){
					if (currentLine5 < talkLinesNPC5.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC5 [currentLine5] + "\n");
					} else if (currentLine5 == 8) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC5 = false;
						isHide = false;
						isTrigShow = false;
						onQuest6 = false;
						onQuest7 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("TALK to\nOTTO BECKER\nat his desk");
					}
				} else {
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Do you need a doctor?");
					} else {
						NPC5 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						touch.release();
						isDisableBt = false;
					}
				}
			}

			if(NPC6){
				if(onQuest7){
					if (currentLine6 < talkLinesNPC6.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC6 [currentLine6] + "\n");
					} else if (currentLine6 == 14) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC6 = false;
						isHide = false;
						isTrigShow = false;
						onQuest7 = false;
						onQuest8 = true;
						hideTransition1 = true;
						StartCoroutine(myTransition1(5.0f));
						isDisableBt = false;
						//
						showTicker("Go outside and talk to\nthe man SOUTH\nof rizal's rent");
					}
				} else if (onQuest9){
					if (currentLine6extended < talkLinesNPC6extended.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC6extended [currentLine6extended] + "\n");
					} else if (currentLine6extended == 19) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC6 = false;
						isHide = false;
						isTrigShow = false;
						onQuest9 = false;
						onQuest10 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("Go back to the MAN\nwith POOR EYESIGHT");
					}
				} else {
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Hi i'm Dr. Becker");
					} else {
						NPC6 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
						isDisableBt = false;
					}
				}
			}

			if(NPC7){
				if(onQuest8){
					if (currentLine7 < talkLinesNPC7.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC7 [currentLine7] + "\n");
					} else if (currentLine7 == 18) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC7 = false;
						isHide = false;
						isTrigShow = false;
						onQuest8 = false;
						onQuest9 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("Go to OTTO BECKER\n and tell him about the\nman with poor eyesight");
					}
				} else if (onQuest10){
					if (currentLine7extended < talkLinesNPC7extended.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC7extended [currentLine7extended] + "\n");
					} else if (currentLine7extended == 17) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC7 = false;
						isHide = false;
						isTrigShow = false;
						onQuest10 = false;
						onQuest11 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("Find Maximo Viola, head\nNortheast of Central park");
					}
				} else {
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Is this berlin? By the way it's beautiful.");
					} else {
						NPC7 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
						isDisableBt = false;
					}
				}
			}

			if(NPC8){
				if(onQuest11){
					if (currentLine8 < talkLinesNPC8.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC8 [currentLine8] + "\n");
					} else if (currentLine8 == 28) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC8 = false;
						isHide = false;
						isTrigShow = false;
						onQuest11 = false;
						onQuest12 = true;
						hideTransition1 = true;
						StartCoroutine(myTransition2(5.0f));
						isDisableBt = false;
						//
						showTicker("Find the PUBLISHER\nthat can help Rizal\npublish his 2nd book");

					}
				} else {
					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Hey there my friend.");
					} else {
						NPC8 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
						isDisableBt = false;
					}
				}
			}

			if(NPC9){
				if(onQuest12){
					if (currentLine9 < talkLinesNPC9.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC9 [currentLine9] + "\n");
					} else if (currentLine9 == 11) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC9 = false;
						isHide = false;
						isTrigShow = false;
						onQuest12 = false;
						onQuest13 = true;
						touch.release();
						isDisableBt = false;
						//
						showTicker("BUY materials for writing\nat the PUBSLISHING STORE");
					}
				} else if (onQuest15){
					if (currentLine9extended < talkLinesNPC9extended.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC9extended [currentLine9extended] + "\n");
					} else if (currentLine9extended == 6) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC9 = false;
						isHide = false;
						isTrigShow = false;
						onQuest15 = false;
						touch.release();
						isDisableBt = false;
						PlayerPrefs.SetInt("Set3", 1);
						//Quest Finished!
						//
						showTicker("You have completed\nthe El Filibusterismo\nquest");
						Application.LoadLevel("FOOFOOFOO13");
						Destroy(Play);
						Destroy(Cam);
						Destroy(guiGroup);
						Destroy(Control);
						MusicAudioListener.enabled=true;
					}
				} else {
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Wanna publish your book?");
					} else {
						NPC9 = false;
						isDisableBt = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
					}
				}
			}

			if(NPC10){
				if(onQuest13){
					if (currentLine10 < talkLinesNPC10.Length) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC10 [currentLine10] + "\n");
					} else if (currentLine10 == 5) { //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						isDisableBt = false;
						NPC10 = false;
						isHide = false;
						isTrigShow = false;
						onQuest13 = false;
						onQuest14 = true;
						touch.release();
						//
						showTicker("Go Back to\nRIZAL's ROOM");
					}
				} else {
					if (otherLine1 == 1) {
						   
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Welcome are you looking for something?");
					} else {
						isDisableBt = false;
						NPC10 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						touch.release();
					}
				}
			}
		}
	}

	void saveItems(){
		if(onQuest5){
			if(Object1){
				PlayerPrefs.SetInt("Books", 1);
			}
			if(Object2){
				PlayerPrefs.SetInt("Pen", 1);
			}
		}
	}

	void getItems(){
		if (onQuest5){
			books = PlayerPrefs.GetInt ("Books");
			pen = PlayerPrefs.GetInt ("Pen");	
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
	void HideTextWindow(){//text window/chatbox
		if (isTextWindow) {
			
			GameObject.Find ("Text Window").guiTexture.enabled = true;
			
		} else {
			
			GameObject.Find ("Text Window").guiTexture.enabled = false;
			
		}
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "Portal1") {
			Application.LoadLevel("New Act3 Part2 Scene 2");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal1(0.0f));
		}

		if (col.gameObject.tag == "Portal2") {
			Application.LoadLevel("New Act3 Part2 Scene 1 - Copy");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal2(0.0f));
		}

		if (col.gameObject.tag == "Portal3") {
			Application.LoadLevel("New Act3 Part2 Scene 3");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal3(0.0f));
		}

		if (col.gameObject.tag == "Portal4") {
			Application.LoadLevel("New Act3 Part2 Scene 1 - Copy");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal4(0.0f));
		}

		if (col.gameObject.tag == "Portal5") {
			Application.LoadLevel("New Act3 Part2 Scene 4room");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal5(0.0f));
		}

		if (col.gameObject.tag == "Portal6") {
			Application.LoadLevel("New Act3 Part2 Scene 1 - Copy");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal6(0.0f));
		}

		if (col.gameObject.tag == "Portal7") {
			Application.LoadLevel("New Act3 Part2 Scene 5room");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal7(0.0f));
		}

		if (col.gameObject.tag == "Portal8") {
			Application.LoadLevel("New Act3 Part2 Scene 3");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal8(0.0f));
		}

		if (col.gameObject.tag == "Portal9") {
			if(onQuest14){
				touch.stopMovements();
				hideTransition1 = true;
				StartCoroutine(myTransition3(3.0f));
			} else {
				Application.LoadLevel("New Act3 Part2 Scene 6roomElFili");
				renderer.sortingOrder = 37;
				StartCoroutine(MyLoadLevelPortal9(0.0f));
			}
		}

		if (col.gameObject.tag == "Portal10") {
			Application.LoadLevel("New Act3 Part2 Scene 7ElFili");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal10(0.0f));
		}

		if (col.gameObject.tag == "Portal11") {
			Application.LoadLevel("New Act3 Part2 Scene 8roomElFili");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal11(0.0f));
		}
		if (col.gameObject.tag == "Portal12") {
			Application.LoadLevel("New Act3 Part2 Scene 7ElFili");
			renderer.sortingOrder = 37;
			StartCoroutine(MyLoadLevelPortal12(0.0f));
		}

		//NPCS
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

		if(col.gameObject.tag == "NPC7"){
			isDisableBt = true;
			isTrigShow = true;
			NPC7 = true;
		}

		if(col.gameObject.tag == "NPC8"){
			isDisableBt = true;
			isTrigShow = true;
			NPC8 = true;
		}

		if(col.gameObject.tag == "NPC9"){
			isDisableBt = true;
			isTrigShow = true;
			NPC9 = true;
		}

		if(col.gameObject.tag == "NPC10"){
			isDisableBt = true;
			isTrigShow = true;
			NPC10 = true;
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

		if(col.gameObject.tag == "NPC7"){
			isDisableBt = false;
			isTrigShow = false;
			NPC7 = false;
		}

		if(col.gameObject.tag == "NPC8"){
			isDisableBt = false;
			isTrigShow = false;
			NPC8 = false;
		}

		if(col.gameObject.tag == "NPC9"){
			isDisableBt = false;
			isTrigShow = false;
			NPC9 = false;
		}

		if(col.gameObject.tag == "NPC10"){
			isDisableBt = false;
			isTrigShow = false;
			NPC10 = false;
		}
	}

	IEnumerator MyLoadLevelPortal1(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-5.170187f, -3.871054f, 0);
	}

	IEnumerator MyLoadLevelPortal2(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (11.824f, -10.72419f, 0);
	}

	IEnumerator MyLoadLevelPortal3(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-3.833272f, -12.17321f, 0);
	}

	IEnumerator MyLoadLevelPortal4(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (15.73035f, -3.921301f, 0);
	}

	IEnumerator MyLoadLevelPortal5(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (2.293566f, -3.644917f, 0);
	}

	IEnumerator MyLoadLevelPortal6(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (5.290883f, -9.93656f, 0);
	}

	IEnumerator MyLoadLevelPortal7(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-1.77235f, 2.981946f, 0);
	}

	IEnumerator MyLoadLevelPortal8(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-2.576971f, -5.37039f, 0);
	}

	IEnumerator MyLoadLevelPortal9(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-0.8364186f, 4.916562f, 0);
	}

	IEnumerator MyLoadLevelPortal10(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (0.04123974f, -5.383722f, 0);
	}

	IEnumerator MyLoadLevelPortal11(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-3.800305f, 0.1127543f, 0);
	}

	IEnumerator MyLoadLevelPortal12(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (6.578429f, -6.159198f, 0);
	}

	IEnumerator myTransition1(float delay)
	{
		//1stblackscreen
		GameObject.Find("MonoText1").guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		hideTransition1 = false;
		newQuest.displayEnd(qunlock);//r 1st blackscreen
		audio.PlayOneShot(clip[0]);
		showTicker ("Go to the MAN just\noutside beside the BENCH\nand TALK to him");
		Application.LoadLevel("New Act3 Part2 Scene 5room");
		touch.release();
		transform.position = new Vector3 (-3.087066f, 2.226366f, 0);
	}

	IEnumerator myTransition2(float delay)
	{
		//2nd black
		GameObject.Find("MonoText2").guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		hideTransition1 = false;
		newQuest.displayEnd(qunlock);//r 2nd blackscreen
		audio.PlayOneShot(clip[0]);
		showTicker ("Go to the PUBLISHER\njust outside and\nTALK to him");
		touch.release();
		Application.LoadLevel("New Act3 Part2 Scene 6roomElFili");
		transform.position = new Vector3 (-0.8364186f, 4.916562f, 0);
	}

	IEnumerator myTransition3(float delay)
	{
		//3rd blackscreen
		GameObject.Find("MonoText3").guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		hideTransition1 = false;
		onQuest14 = false;
		onQuest15 = true;
		newQuest.displayEnd(qunlock);//r 2nd blackscreen
		audio.PlayOneShot(clip[0]);
		showTicker ("Go to the PUBLISHER\nto TALK about publishing\nthe book");
		touch.release();
		Application.LoadLevel("New Act3 Part2 Scene 6roomElFili");
		transform.position = new Vector3 (-0.8364186f, 4.916562f, 0);
		showTicker("Talk to\nthe Publisher\nabout the\npublishing of\nthe New\nBook");
	}
	//r
	void showTicker(string itemToget){
		tickerMsg.displayStart(itemToget);//r at 1st scene ticker
	}
	//	//function to show acquired items
	void changeGUITexture(bool toBeDisplayed,string label)
	{
		GameObject.Find("GUITexture_"+label).guiTexture.enabled = toBeDisplayed;
	}
}
