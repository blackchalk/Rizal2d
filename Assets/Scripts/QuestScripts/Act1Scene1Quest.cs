using UnityEngine;
using System.Collections;
public class Act1Scene1Quest : MonoBehaviour {

	public float xlabel; //r
	public float ylabel;
	public GameObject example1;
	public GameObject example2;
	public GameObject example3;

//	public float x;//use this for inspector checking
//	public float y;
//	public float xi;
//	public float yi;

	public AudioClip[] clip;

	public GUIStyle forFont;

	private PlayerMovements touch;
	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene


	//Pixel Resizing
	public GUITexture buttonsA;
	public GUITexture Acts;
	public GUITexture Objectivez;
	public GUITexture textWindowz;
//	public GUITexture controllerz;
	public GUITexture objectivesz;
	public GUITexture itemHolderz;
	public GUIText displayTickerz;

	public GUITexture bt;
	public string[] talkLinesNPC1;
	public string[] talkLinesNPC2;
	public string[] talkLinesNPC3;
	public string[] talkLinesObjects;
	public int currentLine1 = 0;
	public int currentLine2 = 0;
	public int currentLine3 = 0;
	public int currentLineObject = 0;

	//Item Variables
	public int Book = 0;
	public int LampSet = 0;
	public int MatchSet = 0;
	//Checkers
	private bool isTrigShow = false;
	private bool isHide = false;
	private bool isTextWindow = false; //r
	private bool isButtonPressedNPC1 = false;
	private bool isButtonPressedObjects = false;
	private bool isLamp = false;
	public bool isMatchesOil = false;

	public bool onQuest1 = false;//r
	public bool onQuest2 = false;//
	public bool QuestFinished = false;
	public bool button = false; //button restriction
	public int check = 0;//for static dialogues

	public bool onPause = true;

	private bool restrict = true;

	//Sensing
	public bool NPC1 = false;//and here raygon change encapsulation
	private bool Object1 = false;
	private bool Object2 = false;
	public bool Object3 = false;

	//Calls the class of type <NameOfClass>
	private TickerMessage tickerMsg;
	private QuestUnlocked newQuest;
	private string qunlock = "Quest Unlocked!";

	// Use this for initialization
	
	void Start () {

		MusicAudioListener.enabled=false; //r turns of the AudioListener from MusicManager
		PlayerPrefs.SetInt("stopButton", 0);
		example1.SetActive (false);
		changeGUITexture(false,"book");
		changeGUITexture(false,"lamp");
		changeGUITexture(false,"matchesoil");
		}

	//Calls Component from a gameobject
	void Awake(){
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>();
		newQuest = GameObject.Find("GUIQUnlock").GetComponent<QuestUnlocked>();
		touch = GameObject.Find("Player").GetComponent<PlayerMovements>();
		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r


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

		if(PlayerPrefs.GetInt("stopButton") == 1){
			onPause = false;
		}

		if(PlayerPrefs.GetInt("stopButton") == 0){
			onPause = true;
		}

		if((onQuest1==false)&&(currentLine1==0)){
			showTicker("Doña Teodora");
		}
		if(onPause){
		if(button){
		if (Input.touchCount > 0) 
		{
			Touch t = Input.GetTouch(0);
			
			if (t.phase == TouchPhase.Began)
			{
				if(bt.HitTest(t.position, Camera.main)){
					if(NPC1){
						isTextWindow=true;//r
						//Debug.Log("hit");
						isButtonPressedNPC1 = true;
						if(onQuest1 == false){
							currentLine1++;
						}
						if(onQuest1){

							if(Book == 1){
								currentLine2++;
							}
							check++;
						}
						if(onQuest2){
							if(LampSet == 1){
								if(MatchSet == 1){
									currentLine3++;
								}
							}
							check++;
						}
						isHide = true;
						HideTextures();
						//Destroy(GameObject.Find("GUIControls"));
						touch.stopMovements();
					}
					
					if(Object1){
						isButtonPressedObjects = true;
						isHide = true;
						HideTextures();
						currentLineObject++;
						touch.stopMovements();
					}
					
					if(Object2){
						isButtonPressedObjects = true;
						isHide = true;
						HideTextures();
						currentLineObject++;
						currentLineObject++;
						touch.stopMovements();
					}
					if(restrict == true){
					if(Object3){
						isButtonPressedObjects = true;
						isHide = true;
						HideTextures();
						currentLineObject++;
						currentLineObject++;
						currentLineObject++;
						touch.stopMovements();
					}
					}
					
				}
			}

		}
	}
	}
		// Talk to NPC //tanggalin
//		if (Input.GetMouseButtonDown (0)) 
//		{
//
//			if(bt.HitTest(Input.mousePosition, Camera.main))
//			{
//					if(NPC1){
//					Debug.Log("hit");
//						isButtonPressedNPC1 = true;
//						if(onQuest1 == false){
//						currentLine1++;
//						}
//						if(onQuest1){
//							if(Book == 1){
//							currentLine2++;
//							}
//						check++;
//						}
//						if(onQuest2){
//							if(LampSet == 1){
//								if(MatchSet == 1){
//								currentLine3++;
//								}
//							}
//						check++;
//						}
//						isHide = true;
//						HideTextures();
//	
//					}
//
//				if(Object1){
//					isButtonPressedObjects = true;
//					isHide = true;
//					HideTextures();
//					currentLineObject++;
//				}
//
//				if(Object2){
//					isButtonPressedObjects = true;
//					isHide = true;
//					HideTextures();
//					currentLineObject++;
//					currentLineObject++;
//				}
//
//				if(Object3){
//					isButtonPressedObjects = true;
//					isHide = true;
//					HideTextures();
//					currentLineObject++;
//					currentLineObject++;
//					currentLineObject++;
//				}
//			}
//
//		}
//		// end line
		HideBt ();
		//r
		HideTextWindow();
	}
	
	void HideBt(){
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
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "NPC1") 
		{
		
			isTrigShow = true;
			NPC1 = true;
			button = true;
		}

		if(onQuest1){

			if (col.gameObject.tag == "Object1") 
			{

				isTrigShow = true;
				Object1 = true;
				button = true;
			
			}
		}

		if(onQuest2){

			if (col.gameObject.tag == "Object2") 
			{
				button = true;
				isTrigShow = true;
				Object2 = true;
			
			}

		}

		if (onQuest2) {

			if (col.gameObject.tag == "Object3") {
				button = true;
				isTrigShow = true;
				Object3 = true;
			}
		}
		
		
	}
	
	void OnTriggerExit2D(Collider2D col)
	{

		if (col.gameObject.tag == "NPC1") 
		{
			button = false;
			isTrigShow = false;
			NPC1 = false;
		}

		if(onQuest1){

			if (col.gameObject.tag == "Object1") 
			{
				button = false;
				isTrigShow = false;
				Object1 = false;
			}
		}

		if(onQuest2){

			if (col.gameObject.tag == "Object2") 
			{
				button = false;
				isTrigShow = false;
				Object2 = false;
			}
		}

		if(onQuest2){

			if (col.gameObject.tag == "Object3") 
			{
				button = false;
				isTrigShow = false;
				Object3 = false;
			}
		}

	
	}

	void saveItems(){

		if(onQuest1){
			PlayerPrefs.SetInt ("Book", 1);
		}

		if (onQuest2) {
			if(isLamp){
				PlayerPrefs.SetInt ("Lamp", 1);
			}

			if(isMatchesOil){
				PlayerPrefs.SetInt ("MatchesOil", 1);
			}
		}
	}

	void getItems(){

		if(onQuest1){
			Book = PlayerPrefs.GetInt ("Book");
		}

		if (onQuest2){
			if(isLamp){
				LampSet = PlayerPrefs.GetInt ("Lamp");
			}
			if(isMatchesOil){
				MatchSet = PlayerPrefs.GetInt ("MatchesOil");
			}
		}
	}
	
	void OnGUI() 
	{
		if(onPause){


		GUI.skin.label = forFont;//r skin style

	if (isButtonPressedNPC1) 
		{

			if(onQuest1 == false)
			{
				if(currentLine1 < talkLinesNPC1.Length)
				{	// homer
//					forFont.fontSize=38;

					GUI.Label(new Rect(Screen.width*xlabel, Screen.height*ylabel,(Screen.width)*0.65f,(Screen.height*0.3f)), ""+talkLinesNPC1[currentLine1]+"\n");
				} else if(currentLine1 == 6)
				{

					isTextWindow=false;//r
					isButtonPressedNPC1 = false;
					isTrigShow = false;
					button = false;
					isHide = false;
					HideTextures();
					onQuest1 = true;
					//r part where ticker will be drawn to the scene
					tickerMsg.displayStart("Get a book\nfrom the desk");
					audio.PlayOneShot(clip[0]);
					newQuest.displayEnd(qunlock);//r
					touch.release();
				}
			}
			if(onQuest1){
				if(Book == 0){
					if(check == 1){
						//homer
						GUI.Label(new Rect(Screen.width*xlabel, Screen.height*ylabel,(Screen.width)*0.65f,(Screen.height*0.3f)), "Doña Teodora: Did you bring the book\nalready? It's at my desk");
					}else{
						check = 0;
						isTextWindow=false;//r textwindow will be off
						isButtonPressedNPC1 = false;
						isTrigShow = false;
						button = false;
						isHide = false;
						HideTextures();
						touch.release();
					}
				}

				if(Book == 1){
					if(currentLine2 < talkLinesNPC2.Length){
						//homer
						GUI.Label(new Rect(Screen.width*xlabel, Screen.height*ylabel,(Screen.width)*0.65f,(Screen.height*0.3f)), ""+talkLinesNPC2[currentLine2]+"\n");
					}else if(currentLine2 == 6){
						isTextWindow=false;
						isButtonPressedNPC1 = false;
						isTrigShow = false;
						button = false;
						isHide = false;
						HideTextures();
						onQuest1 = false;
						onQuest2 = true;
						touch.release();
					}
				}

			}

			if(onQuest2){
				if(LampSet == 1 && MatchSet == 1){
					if(currentLine3 < talkLinesNPC3.Length){
						//homer
						GUI.Label(new Rect(Screen.width*xlabel, Screen.height*ylabel,(Screen.width)*0.65f,(Screen.height*0.3f)), ""+talkLinesNPC3[currentLine3]+"\n");
							example1.SetActive(true);//r example1 aka Lamp-with-Light
					} else if(currentLine3 == 18){
						isTextWindow=false;//r
						isButtonPressedNPC1 = false;
						isTrigShow = false;
						button = false;
						isHide = false;
						HideTextures();
						check = 0;
						onQuest1 = false;
						onQuest2 = false;
						QuestFinished = true;
						//Debug.Log("QuestFinished is now with notified"+QuestFinished);
						QuestDone();
						touch.release();
					}
				}
				//this is where LampSet is 0 and matchSet 0
				if((LampSet == 0 && MatchSet == 0) || (LampSet == 1 && MatchSet == 0) || (LampSet == 0 && MatchSet ==1)){
						if(check == 1){
						//homer
						GUI.Label(new Rect(Screen.width*xlabel, Screen.height*ylabel,(Screen.width)*0.65f,(Screen.height*0.3f)), "I need the lamp from the desk,\nand matches inside the chest?");
						}else{
							check = 0;
							isTextWindow=false;
							isButtonPressedNPC1 = false;
							isTrigShow = false;
							button = false;
							isHide = false;
							HideTextures();
							touch.release();
						}
					//part where ticker will be drawn to the scene //r
					tickerMsg.displayStart("Things needed:\na MATCH inside\nthe chest and\na LAMP at the desk");
					newQuest.displayEnd(qunlock);
					audio.PlayOneShot(clip[0]);
					//Debug.Log(LampSet+"Lamp &"+MatchSet+"Matches");
				}
			}
		}

		if(isButtonPressedObjects){

			if(Object1){
				if(currentLineObject == 1){
					// homer
					GUI.Label (new Rect(Screen.width*0.4f, Screen.height*0.2f,(Screen.width)*0.4f,(Screen.height*0.2f)), ""+talkLinesObjects[1]);
				}else{
					saveItems();
					getItems();
					isTextWindow=false;
					isButtonPressedObjects = false;
					isTrigShow = false;
					button = false;
					currentLineObject = 0;
					isHide = false;
					HideTextures();
					GameObject.Find ("Book").SetActive(false);
					Object1 =false;
					changeGUITexture(true,"book"); //r show texture
					tickerMsg.displayStart("Bring it to\nDoña Teodora!");//r
					touch.release();
					isTrigShow = false;
				}
			}

			if(Object2){
				if(currentLineObject == 2){
					// homer
					GUI.Label (new Rect(Screen.width*0.4f, Screen.height*0.2f,(Screen.width)*0.4f,(Screen.height*0.2f)), ""+talkLinesObjects[2]);
				}else{
					isTextWindow=false;
					isLamp = true;
					saveItems();
					getItems();
					isButtonPressedObjects = false;
					isTrigShow = false;
					button = false;
					currentLineObject = 0;
					isHide = false;
					HideTextures();
					GameObject.Find ("Lamp-no-light").SetActive(false);
					isLamp = false;
					Object2 = false;
					changeGUITexture(true,"lamp");
					isTrigShow = false;
					touch.release();
				}
			}

			if(restrict == true){
			if(Object3){
				if(currentLineObject == 3){
					// homer
					GUI.Label (new Rect(Screen.width*0.3f, Screen.height*0.2f,(Screen.width)*0.4f,(Screen.height*0.3f)), ""+talkLinesObjects[3]);}
				else
				{
					isTextWindow=false;//r
					isMatchesOil = true;
					saveItems();
					getItems();
					isButtonPressedObjects = false;
					isTrigShow = false;
					button = false;
					currentLineObject = 0;
					isHide = false;
					HideTextures();
					isMatchesOil = false;
					Object3 = false;
					touch.release();
					restrict = false;
					isTrigShow = true;
						audio.PlayOneShot(clip[1]);
				}//tickermessage where matches will hit 1
				
					changeGUITexture(true,"matchesoil");
			}
		}
			//message when lamp and matchesoil are both true and not both;
			if((GameObject.Find("GUITexture_lamp").guiTexture.enabled) && 
			   (GameObject.Find("GUITexture_matchesoil").guiTexture.enabled)){
				tickerMsg.displayStart("Talk to\nDoña Teodora");}
			if((GameObject.Find("GUITexture_lamp").guiTexture.enabled==false)
			   && (GameObject.Find("GUITexture_matchesoil").guiTexture.enabled)){
				tickerMsg.displayStart("Get the lamp\nat the desk");}//new jan22
			if((GameObject.Find("GUITexture_lamp").guiTexture.enabled) 
			   && (GameObject.Find("GUITexture_matchesoil").guiTexture.enabled==false)){
				tickerMsg.displayStart("Get matches\n& oil inside\nthe Chest");}//new jan22
		}
	}
	}
	void QuestDone()
		{
			if(QuestFinished)
				{
				Application.LoadLevel("MothDied");
				MusicAudioListener.enabled=true;
				//Debug.Log("new scene will be loaded after here");
				}
		}
	void changeGUITexture(bool toBeDisplayed,string label)//r function responsible for showing questsitems on gui
	{
		GameObject.Find("GUITexture_"+label).guiTexture.enabled = toBeDisplayed;
	}
	void showTicker(string itemToget){//added new function
		tickerMsg.displayStart("Talk to\n"+itemToget);//r at 1st scene ticker

	}




	
}

	