using UnityEngine;
using System.Collections;

public class NewAct4Part1 : MonoBehaviour {

	public float xLabel; //r
	public float yLabel;

	public AudioClip[] clip;
	public GUIStyle forFont; //r

	public GameObject Cam;
	public GameObject guiGroup;
	public GameObject Play;
	public GameObject Control;


	public GUITexture bt;
	public GameObject Portal;

	private PlayerMovements touch;
	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene
	
	public int otherLine1 = 0;
	public string[] talkLinesNPC1;
	public int currentLine1 = 0;

	public string[] talkLinesNPC2;
	public int currentLine2 = 0;

	//Quests
	public bool onQuest1 = true;
	public bool onQuest2 = false;

	//NPCs
	public bool NPC1 = false;
	public bool Dia = false;

	//checkers
	private bool isTrigShow = false;
	private bool isHide = false;
	public bool isButtonPressedNPC = false;
	private bool isButtonDialogue = false;
	private bool isPortalShow = false;
	private bool isTextWindow=false;

	private bool openPortal = false;

	private bool disableBt = false;

	//tickermessage
	private TickerMessage tickerMsg; //r
	private QuestUnlocked newQuest;
	private string qunlock = "New Quest Unlocked!";

	void Awake(){
		touch = GameObject.Find("Player").GetComponent<PlayerMovements>();
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>(); //r
		newQuest = GameObject.Find ("GUIQUnlock").GetComponent<QuestUnlocked>();
		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r //comment this if you are about to edit the scene
	}
	// Use this for initialization
	void Start () {
		MusicAudioListener.enabled=false;
		PlayerPrefs.SetInt("stopButton", 0);
		newQuest.displayEnd(qunlock);
		audio.PlayOneShot(clip[0]);
		Portal.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

//		if(PlayerPrefs.GetInt("stopButton") == 1){
//			disableBt = false;
//		}
//		
//		if(PlayerPrefs.GetInt("stopButton") == 0){
//			disableBt = true;
//		}

		if (onQuest1){
			showTicker("Talk to the\nman in black\ncoat");
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
		if(disableBt){
		if (Input.GetMouseButtonDown (0)) {
			
			if (bt.HitTest (Input.mousePosition, Camera.main)) {
				if(NPC1){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					if(onQuest1 == true){
						currentLine1++;
					} else {
						otherLine1++;
					}
				}

				if(Dia){
					isButtonDialogue = true;
						isTextWindow=true;
					if(onQuest2){
						currentLine2++;
					}
				}

				isHide = true;
			}
		}
		}
	
		HideBt ();
		HideTextures ();
		HideTextWindow();
	}

	void OnGUI(){

		GUI.skin.label=forFont; //style r

		if (isButtonPressedNPC) {
			if (NPC1) {
				if (onQuest1) {

					if (currentLine1 < talkLinesNPC1.Length) {
						   //color
						GUI.Label (new Rect (Screen.width *    xLabel, Screen.height *    yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC1 [currentLine1] + "\n");
					} 

					if (currentLine1 == 9){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC1 = false;
						isHide = false;
						isTrigShow = false;
						onQuest1 = false;
						onQuest2 = true;
						Portal.SetActive (true);

						touch.release();
						disableBt = false;
						//
						showTicker("Go to\nthe portal");
					}

				} else {
					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width *    xLabel, Screen.height *    yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "What should we do?");
					} else {
						NPC1 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;

						touch.release();
						disableBt = false;
					}
				}
			}
		}

		if(isButtonDialogue){
			if(Dia){
				if (onQuest2) {
					if (currentLine2 < talkLinesNPC2.Length) {
						   //color
						GUI.Label (new Rect (Screen.width *    xLabel, Screen.height *    yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC2 [currentLine2] + "\n");
					} else if (currentLine2 == 10) { //set to right amount of text in array
						isButtonDialogue = false;
						isTextWindow=false;
						isHide = false;
						isTrigShow = false;
						onQuest2 = false;
						disableBt = false;
						touch.release();
						//tickerMsg.displayStart("Talk to the\nguardiya sibil");//r
						Application.LoadLevel("FOOFOOFOO7");//to be edited for new scenes b4 the target scene.
						Destroy(Play);
						Destroy(Cam);
						Destroy(guiGroup);
						Destroy(Control);
						//StartCoroutine(loadNow(0.5f));
						MusicAudioListener.enabled=true;
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
	void HideTextWindow(){//text window/chatbox
		if (isTextWindow) {
			
			GameObject.Find ("Text Window").guiTexture.enabled = true;
			
		} else {
			
			GameObject.Find ("Text Window").guiTexture.enabled = false;
			
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Portal1") {
			disableBt = true;
			Application.LoadLevel("New Act4 Part1 Scene2");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal1(0.0f));
			isHide = true;
			isTrigShow = true;
			Dia = true;
		}
		
		//NPCS

		if (col.gameObject.tag == "NPC1") {
			isTrigShow = true;
			NPC1 = true;
			disableBt = true;
		}

		//

		if (col.gameObject.tag == "Portal2"){
			touch.stopMovements();
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		
		if (col.gameObject.tag == "NPC1") {
			isTrigShow = false;
			NPC1 = false;
			disableBt = false;
		}
	}
	
	IEnumerator MyLoadLevelPortal1(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (13.13929f, -11.48806f, 0);
		touch.stopMovements();
	}

	IEnumerator loadNow(float delay)
	{
		yield return new WaitForSeconds(delay);
		Application.LoadLevel ("New Act4 Part2 Scene4 room1");

		StartCoroutine(destroyNow(0.5f));

	}


	IEnumerator destroyNow(float delay)
	{
		yield return new WaitForSeconds(delay);
		Destroy(Play);
		Destroy(Cam);
		Destroy(guiGroup);
		Destroy(Control);
	}

	//r
	void showTicker(string itemToget){
		tickerMsg.displayStart(itemToget);//r at 1st scene ticker
	}

}
