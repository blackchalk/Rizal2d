using UnityEngine;
using System.Collections;

public class NewAct4FinalPart1 : MonoBehaviour {

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


	public AudioClip[] clip;//r array of audiosfx
	public GUIStyle forFont;
//	GUIContent content = new GUIContent();
//	public Texture2D textwin;

	public GameObject CamHere;
	public GameObject guiGroup;
	public GameObject Play;
	public GameObject Control;

	public Storage storage;

	public GUITexture bt;

	private PlayerMovements touch;
//	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene
	private Move move;

	public GameObject Visits;

	public Object Player;
	public Object GUIs;
	public Object Cam;
	public Object Trans;

	public int otherLine1 = 0;
	public string[] talkLinesNPC1;
	public int currentLine1 = 0;
	public string[] talkLinesObject1;
	public int currentLineObject1 = 0;
	public string[] talkLinesNPC2;
	public int currentLine2 = 0;
	public string[] talkLinesObject2;
	public int currentLineObject2 = 0;
	public string[] talkLinesNPC3;
	public int currentLine3 = 0;

	//Quests
	public bool onQuest1 = true;
	public bool onQuest2 = false;
	public bool onQuest3 = false;
	public bool onQuest4 = false;

	//checkers
	private bool isTrigShow = false;
	private bool isHide = false;
	private bool hideTransition1 = false;
	public bool isButtonPressedNPC = false;
	private bool isTextWindow=false;

	//NPCS
	public bool NPC1 = false;
	public bool Object1 = false;
	public bool Object2 = false;
	public bool GC = false;
	public bool NPC3 = false;

	public int New = 0;

	private bool disableBt = false;

	//tickermessage
	private TickerMessage tickerMsg;
	private QuestUnlocked newQuest;
	private string qunlock = "New Quest Unlocked!";


	void Awake(){
		//content.image = (Texture2D)textwin;
		touch = GameObject.Find("Player").GetComponent<PlayerMovements>();
		storage = GameObject.Find ("Storage").GetComponent<Storage> ();
		move = GameObject.Find ("Bonifacio_0").GetComponent<Move> ();
//		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r //comment this if you are about to edit the scene
		New = storage.newer;

		if(New == 1){
			isTrigShow = true;
			isHide = true;
			touch.stopMovements();
			GC = true;
			onQuest3 = true;
			onQuest1 = false;
			PlayerPrefs.SetInt("stopButton", 0);
			//GameObject.Find("Player").GetComponent<NewAct4FinalPart1>().enabled = true;
		}
		//tickers
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>();
		newQuest = GameObject.Find ("GUIQUnlock").GetComponent<QuestUnlocked>();
	}
	
	void Start () {
//		MusicAudioListener.enabled=false;
		newQuest.displayEnd(qunlock);
		audio.PlayOneShot(clip[0]);

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

		if ((onQuest1)&&(!onQuest2)){
			showTicker("Talk to\nDona Teodora\nand Josephine\nBracken");
		}

		if(New == 1){
			Visits.SetActive(false);
		}

		if(storage.cont == 1){
			isTrigShow = true;
			NPC3 = true;
		}

		if (Input.touchCount > 0) {
			Touch t = Input.GetTouch (0);
			/*
			if (t.phase == TouchPhase.Began) {
				if (bt.HitTest (t.position, Camera.main)) {

				}
			}
			*/
		}

		if (Input.GetMouseButtonDown (0)) {
			
			if (bt.HitTest (Input.mousePosition, Camera.main)) {
				if(GC){
					isHide = true;
					isButtonPressedNPC = true;
					isTextWindow=true;
					if(onQuest3){
						currentLine2++;
					}
				}
			}
		}

		if(PlayerPrefs.GetInt("stopButton") == 1){
			disableBt = false;
		}
		
		if(PlayerPrefs.GetInt("stopButton") == 0){
			disableBt = true;
		}



		if(disableBt){
		if (Input.GetMouseButtonDown (0)) {
			
			if (bt.HitTest (Input.mousePosition, Camera.main)) {
				if(New == 0){
				if(NPC1){
							touch.stopMovements();
					isHide = true;
					isButtonPressedNPC = true;
							isTextWindow=true;//r
					if(onQuest1 == true){
						currentLine1++;
					} else {
						otherLine1++;
					}
				}

				if(Object1){
							touch.stopMovements();
					isHide = true;
					isButtonPressedNPC = true;
							isTextWindow=true;//r
					if(onQuest2 == true){
						currentLineObject1++;
					}
				}
				}

//				if(GC){
//					isHide = true;
//					isButtonPressedNPC = true;
//					if(onQuest3){
//						currentLine2++;
//					}
//				}

				if(Object2){
						touch.stopMovements();
					isHide = true;
					isButtonPressedNPC = true;
						isTextWindow=true;//r
					if(onQuest4){
						touch.stopMovements();
						otherLine1++;
					}
				}

				if(NPC3){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;//r
					if(onQuest4){
						currentLine3++;
					}
				}
			}
		}
	}
		HideTextures ();
		HideBt ();
		Transition ();
		HideTextWindow();
	}

	void OnGUI(){
		GUI.skin.label = forFont;
//		forFont.fontSize=40;
		if (isButtonPressedNPC) {
			if (NPC1) {
				if (onQuest1) {

					if (currentLine1 < talkLinesNPC1.Length) {
						  //color //r
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)),"" + talkLinesNPC1 [currentLine1] + "\n");
					} else if (currentLine1 == 4){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;//r
						NPC1 = false;
						isHide = false;
						isTrigShow = false;
						onQuest1 = false;
						onQuest2 = true;
						hideTransition1 = true;
						Visits.SetActive(false);
						StartCoroutine(myTransition1(3.0f));
						newQuest.displayEnd(qunlock);
						audio.PlayOneShot(clip[0]);
						showTicker("Go to a\ntable to\nstart writing\na poem");
					}
					
				} else {
					if (otherLine1 == 1) {
						 //color //r
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "What should we do?");
					} else {
						NPC1 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;//r
						isHide = false;
					}
				}
			}

			if(Object1){
				if(onQuest2){
					if (currentLineObject1 < talkLinesObject1.Length) {
						 //color //r
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesObject1 [currentLineObject1] + "\n");
					} else if (currentLineObject1 == 4	){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;//r
						Object1 = false;
						isHide = false;
						isTrigShow = false;
						onQuest2 = false;
						touch.release();
						Destroy(Player);
						Destroy(GUIs);
						Destroy(Cam);
						Destroy(Trans);
						Destroy (Control);//r
						Destroy(guiGroup);//r
						Application.LoadLevel("FOOFOOFOO12");//r
//						MusicAudioListener.enabled=true;

					}
				}
			}

			if(GC){
				if(onQuest3){
					if (currentLine2 < talkLinesNPC2.Length) {
						 //color //r
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC2 [currentLine2] + "\n");
					} else if (currentLine2 == 5){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;//r
						GC = false;
						isHide = false;
						isTrigShow = false;
						onQuest3 = false;
						onQuest4 = true;
						touch.release();
					}
				}
			}

			if(Object2){
				if(onQuest4){
					if (otherLine1 == 1) {
						 //color //r
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Who is it?");
					} else {
						Object2 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;//r
						move.move = 1;
						touch.release();
					}
				}
			}

			if(NPC3){
				if(onQuest4){
					if (currentLine3 < talkLinesNPC3.Length) {
						 //color //r
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC3 [currentLine3] + "\n");
					} else if (currentLine3 == 31){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;//r
						NPC3 = false;
						touch.release();
						//END QUEST
						Application.LoadLevel("EPILOGUEAct4part3");
						Destroy(Play);
						Destroy(CamHere);
						Destroy(guiGroup);
						Destroy(Control);
					}
				}
			}
		}
	}

	void Transition(){
		
		if (hideTransition1 == false) {
			GameObject.Find ("transition1").guiTexture.enabled = false;
			GameObject.Find("MonoText1").guiText.enabled = false;//r
		} else {
			GameObject.Find ("transition1").guiTexture.enabled = true;
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
		if(New == 0){
		if (col.gameObject.tag == "NPC1") {
			isTrigShow = true;
			NPC1 = true;
				disableBt = true;
		}

		if(onQuest2){
			if (col.gameObject.tag == "Object1") {
				isTrigShow = true;
				Object1 = true;
					disableBt = true;
			}
		}
		}

		if(onQuest4){
			if (col.gameObject.tag == "Object2") {
				isTrigShow = true;
				Object2 = true;
				disableBt = true;
			}
		}

	}

	void OnTriggerExit2D(Collider2D col) {
		if(New == 0){
		if (col.gameObject.tag == "NPC1") {
			isTrigShow = false;
			NPC1 = false;
				disableBt = false;
		}

		if(onQuest2){
			if (col.gameObject.tag == "Object1") {
				isTrigShow = false;
				Object1 = false;
					disableBt = false;
			}
		}
		}

		if(onQuest4){
			if (col.gameObject.tag == "Object2") {
				isTrigShow = false;
				Object2 = false;
				disableBt = false;
			}
		}
	}

	IEnumerator myTransition1(float delay)
	{
		GameObject.Find("MonoText1").guiText.enabled = true;//r
		yield return new WaitForSeconds(delay);
		hideTransition1 = false;
		touch.release ();
		transform.position = new Vector3 (-11.77655f, -0.4395316f, 0);
	}
	void showTicker(string itemToget){
		tickerMsg.displayStart(itemToget);//r at 1st scene ticker
	}
	//	//function to show acquired items
	void changeGUITexture(bool toBeDisplayed,string label)
	{
		GameObject.Find("GUITexture_"+label).guiTexture.enabled = toBeDisplayed;
	}


}
