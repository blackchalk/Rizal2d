using UnityEngine;
using System.Collections;

public class NewAct4Part3 : MonoBehaviour {

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

	public GameObject Cam;
	public GameObject guiGroup;
	public GameObject Play;
	public GameObject Control;

	private PlayerMovements touch;
	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene
	private TuboChecker tuboChecker;
	public GUITexture bt;

	public GameObject Tube1;
	public GameObject Tube2;
	public GameObject Tube3;

	public GUITexture Tu1;
	public GUITexture Tu2;
	public GUITexture Tu3;

	public string[] talkLinesDia1;
	public int currentDia1 = 0;
	public string[] talkLines1;
	public int currentLine1 = 0;

	public int otherLine1 = 0;

	//Quests
	public bool onQuest1 = true;
	public bool onQuest2 = false;
	public bool onQuest3 = false;

	//checkers
	private bool hideTransition1 = false;
	private bool isTrigShow = false;
	private bool isHide = false;
	private bool isButtonPressedNPC = false;
	private bool isTextWindow=false;

	//NPCS/Objects
	private bool Tubo = false;
	private bool Tubo1 = false;//Object1
	private bool Tubo2 = false;//Object2
	private bool Tubo3 = false;//Object3
	private bool NPC1 = false;

	//private bool TuboOutline = false;//Outlines
	public bool t1 = false;//colliders/identifiers
	public bool t2 = false;
	public bool t3 = false;
	public bool t4 = false;
	public bool t5 = false;
	public bool t6 = false;
	public bool t7 = false;

	public bool iT1 = false;//checkers
	public bool iT2 = false;
	public bool iT3 = false;
	public bool iT4 = false;
	public bool iT5 = false;
	public bool iT6 = false;
	public bool iT7 = false;

	public int Tub1 = 0;//variables that indicate if the quest is finished
	public int Tub2 = 0;
	public int Tub3 = 0;
	public int Tub4 = 0;
	public int Tub5 = 0;
	public int Tub6 = 0;
	public int Tub7 = 0;

	private bool Dialogue = true;

	public bool disableBts;

	//tickermessage
	private TickerMessage tickerMsg; //r
	private QuestUnlocked newQuest;
	private string qunlock = "New Quest Unlocked!";


	void Awake(){
		touch = GameObject.Find ("Player").GetComponent<PlayerMovements>();
		tuboChecker = GameObject.Find ("Player").GetComponent<TuboChecker>();
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>(); //r
		newQuest = GameObject.Find ("GUIQUnlock").GetComponent<QuestUnlocked>();
		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r //comment this if you are about to edit the scene

		disableBts = true;
	}

	void showPipe(){
		Tube1.SetActive (true);
		Tube2.SetActive (true);
		Tube3.SetActive (true);
	}

	void hidePipe(){
		Tube1.SetActive (false);
		Tube2.SetActive (false);
		Tube3.SetActive (false);
	}

	void getTubes(){
		Tub1 = PlayerPrefs.GetInt ("Tube1");
		Tub2 = PlayerPrefs.GetInt ("Tube2");
		Tub3 = PlayerPrefs.GetInt ("Tube3");
		Tub4 = PlayerPrefs.GetInt ("Tube4");
		Tub5 = PlayerPrefs.GetInt ("Tube5");
		Tub6 = PlayerPrefs.GetInt ("Tube6");
		Tub7 = PlayerPrefs.GetInt ("Tube7");
	}

	void checkTubes(){
		if(Tub1 == 1 && Tub2 == 1 && Tub3 == 1 && Tub4 == 1 && Tub5 == 1 && Tub6 == 1 && Tub7 == 1) {
			onQuest2 = false;
			onQuest3 = true;
//			newQuest.displayEnd("Pipe Matching Quest Finished!");
			showTicker("Go back\nto your\nhouse and\ntalk to\nJosephine Bracken");
		}
	}

	void Start () {
		MusicAudioListener.enabled=false;
		changeGUITexture(false,"tubo1");
		changeGUITexture(false,"tubo2");
		changeGUITexture(false,"tubo3");
		isHide = true;
		isTrigShow = true;
		PlayerPrefs.SetInt("Tubo1", 0);
		PlayerPrefs.SetInt("Tubo2", 0);
		PlayerPrefs.SetInt("Tubo3", 0);
	}
	

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
//			disableBts = false;
//		}
//		
//		if(PlayerPrefs.GetInt("stopButton") == 0){
//			disableBts = true;
//		}

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
				if(Dialogue){
					touch.stopMovements();
					isHide = true;
					isTextWindow=true;
					currentDia1++;
				}

			}
		}

		if(disableBts){
		if (Input.GetMouseButtonDown (0)) {
			if (bt.HitTest (Input.mousePosition, Camera.main)) {
				if(Tubo){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					isHide = true;
					if(onQuest2){
						otherLine1++;
					}
				}

				if(NPC1){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					isHide = true;
					if(onQuest3){
						currentLine1++;
					} else {
						otherLine1++;
					}
				}

				if(t1){
						//touch.stopMovements();
					tuboChecker.check();
					iT1 = true;
					isTrigShow = false;
				}

				if (t2){
						//.stopMovements();
					tuboChecker.check();
					iT2 = true;
					isTrigShow = false;
				}

				if (t3){
						//touch.stopMovements();
					tuboChecker.check();
					iT3 = true;
					isTrigShow = false;
				}

				if (t4){
						//touch.stopMovements();
					tuboChecker.check();
					iT4 = true;
					isTrigShow = false;
				}

				if (t5){
						//touch.stopMovements();
					tuboChecker.check();
					iT5 = true;
					isTrigShow = false;
				}

				if (t6){
						//touch.stopMovements();
					tuboChecker.check();
					iT6 = true;
					isTrigShow = false;
				}

				if (t7){
						//touch.stopMovements();
					tuboChecker.check();
					iT7 = true;
					isTrigShow = false;
				}

			}

			if (Tu1.HitTest (Input.mousePosition, Camera.main)) {
				//Debug.Log("Tubo1");
				PlayerPrefs.SetInt("Tubo1", 1);
				PlayerPrefs.SetInt("Tubo2", 0);
				PlayerPrefs.SetInt("Tubo3", 0);
					changeGUITexture(true,"tubo1");
					changeGUITexture(false,"tubo2");
					changeGUITexture(false,"tubo3");
				isHide = false;
				hidePipe();

					disableBts = false;
					touch.release();
			}

			if (Tu2.HitTest (Input.mousePosition, Camera.main)) {
				//Debug.Log("Tubo2");
				PlayerPrefs.SetInt("Tubo1", 0);
				PlayerPrefs.SetInt("Tubo2", 1);
				PlayerPrefs.SetInt("Tubo3", 0);
					changeGUITexture(false,"tubo1");
					changeGUITexture(true,"tubo2");
					changeGUITexture(false,"tubo3");
				isHide = false;
				hidePipe();
				disableBts = false;
				touch.release();
			}

			if (Tu3.HitTest (Input.mousePosition, Camera.main)) {
				//Debug.Log("Tubo3");
				PlayerPrefs.SetInt("Tubo1", 0);
				PlayerPrefs.SetInt("Tubo2", 0);
				PlayerPrefs.SetInt("Tubo3", 1);
					changeGUITexture(false,"tubo1");
					changeGUITexture(false,"tubo2");
					changeGUITexture(true,"tubo3");
				isHide = false;
				hidePipe();
				disableBts = false;
				touch.release();
			}
		}
	}

		HideBt ();
		HideTextures ();
		Transition ();
		getTubes ();
		checkTubes ();
		HideTextWindow();
	}

	void OnGUI(){
		if (Dialogue) {
			if (onQuest1) {
				if (currentDia1 < talkLinesDia1.Length) {
					GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesDia1 [currentDia1] + "\n");
				} else if (currentDia1 == 3) { //set to right amount of text in array
					Dialogue = false;
					isHide = false;
					isTrigShow = false;
					isTextWindow=false;
					touch.release ();
					disableBts = false;
					onQuest1 = false;
					onQuest2 = true;
					//r
					newQuest.displayEnd(qunlock);
					audio.PlayOneShot(clip[0]);
					showTicker("Go to\nthe Pipes\nWarehouse\nat a house\njust infront\nof Rizal's\nHouse");
				}
			}
		}

		if (isButtonPressedNPC) {
			if(Tubo){
				if (onQuest2){
					if (otherLine1 == 1) {
						//
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Only 1 Pipe per Pick. After picking the desired pipe, you can match it with the layout tubes just beside houses, If you want to change the picked pipe you can visit the warehouse again");
					} else {
						isButtonPressedNPC = false;
						isTextWindow=false;
						Tubo = false;
						isTrigShow = false;
						otherLine1 = 0;
						showPipe ();
						showTicker("Pick ONE\npipe then\nFIND its\nMATCH just\nBeside Houses\nall over\ntown");
					}
				} else {
					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Good morning Jose. Have a nice trip.");
					} else {
						NPC1 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isHide = false;
						disableBts = false;
						touch.release();
					}
				}
			}

			if (onQuest3) {
				if (currentLine1 < talkLines1.Length) {
					//
					GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLines1 [currentLine1] + "\n");
				} else if (currentLine1 == 5) { //set to right amount of text in array
					isButtonPressedNPC = false;
					isTextWindow=false;
					isHide = false;
					isTrigShow = false;
					touch.release ();
					onQuest3 = false;
					disableBts = false;
					touch.release();
					//Quest Complete!
					Application.LoadLevel("FOOFOOFOO10");
					Destroy(Play);
					Destroy(Cam);
					Destroy(guiGroup);
					Destroy(Control);
					MusicAudioListener.enabled=true;

				}
			}
		}
	}

	void Transition(){
		
		if (hideTransition1 == false) {
			GameObject.Find ("transition1").guiTexture.enabled = false;
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
		//Tubo/Objects
		if(onQuest3){
		if (col.gameObject.tag == "NPC1") {
			NPC1 = true;
			isTrigShow = true;
			disableBts = true;
		}
		}

		if (col.gameObject.tag == "Tubo") {
			Tubo = true;
			isTrigShow = true;
			disableBts = true;
		}
		if(iT1 == false){
			if (col.gameObject.tag == "1") {
				t1 = true;
				isTrigShow = true;
				disableBts = true;
			}
		}

		if(iT2 == false){
			if (col.gameObject.tag == "2") {
				t2 = true;
				isTrigShow = true;
				disableBts = true;
			}
		}

		if(iT3 == false){
			if (col.gameObject.tag == "3") {
				t3 = true;
				isTrigShow = true;
				disableBts = true;
			}
		}

		if(iT4 == false){
			if (col.gameObject.tag == "4") {
				t4 = true;
				isTrigShow = true;
				disableBts = true;
			}
		}

		if(iT5 == false){
			if (col.gameObject.tag == "5") {
				t5 = true;
				isTrigShow = true;
				disableBts = true;
			}
		}

		if(iT6 == false){
			if (col.gameObject.tag == "6") {
				t6 = true;
				isTrigShow = true;
				disableBts = true;
			}
		}

		if(iT7 == false){
			if (col.gameObject.tag == "7") {
				t7 = true;
				isTrigShow = true;
				disableBts = true;
			}
		}

		//pair
		if (col.gameObject.tag == "Portal5") {
			Application.LoadLevel("New Act4 Part2 Scene1");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal1(0.0f));
		}
		
		if (col.gameObject.tag == "Portal1") {
			Application.LoadLevel("New Act4 Part2 Scene4 room1 - Copy");
			renderer.sortingOrder = 16;
			StartCoroutine(MyLoadLevelPortal2(0.0f));
		}
		//pair
		
		if (col.gameObject.tag == "Portal2") {
			Application.LoadLevel("New Act4 Part2 Scene2");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal3(0.0f));
		}
		
		if (col.gameObject.tag == "Portal3") {
			Application.LoadLevel("New Act4 Part2 Scene1");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal4(0.0f));
		}
		//pair
		
		if (col.gameObject.tag == "Portal6") {
			Application.LoadLevel("New Act4 Part2 Scene9 room5");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal5(0.0f));
		}
		
		if (col.gameObject.tag == "Portal7") {
			Application.LoadLevel("New Act4 Part2 Scene2");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal6(0.0f));
		}
		//pair
		
		if (col.gameObject.tag == "Portal8") {
			Application.LoadLevel("New Act4 Part2 Scene5 room2");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal7(0.0f));
		}
		
		if (col.gameObject.tag == "Portal9") {
			Application.LoadLevel("New Act4 Part2 Scene2");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal8(0.0f));
		}
		//pair
		
		if (col.gameObject.tag == "Portal4") {
			Application.LoadLevel("New Act4 Part2 Scene3");
			renderer.sortingOrder = 34;
			StartCoroutine(MyLoadLevelPortal9(0.0f));
		}
		
		if (col.gameObject.tag == "Portal16") {
			Application.LoadLevel("New Act4 Part2 Scene2");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal10(0.0f));
		}
		//pair
		
		if (col.gameObject.tag == "Portal10") {
			Application.LoadLevel("New Act4 Part2 Scene6 room3");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal11(0.0f));
		}
		
		if (col.gameObject.tag == "Portal11") {
			Application.LoadLevel("New Act4 Part2 Scene3");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal12(0.0f));
		}
		//pair
		
		if (col.gameObject.tag == "Portal12") {
			Application.LoadLevel("New Act4 Part2 Scene7 room4");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal13(0.0f));
		}
		
		if (col.gameObject.tag == "Portal13") {
			Application.LoadLevel("New Act4 Part2 Scene3");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal14(0.0f));
		}
		//pair
		
		if (col.gameObject.tag == "Portal14") {
			Application.LoadLevel("New Act4 Part2 Scene8 classroom");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal15(0.0f));
		}
		
		if (col.gameObject.tag == "Portal15") {
			Application.LoadLevel("New Act4 Part2 Scene3");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal16(0.0f));
		}
		//pair

		if (col.gameObject.tag == "Portal17") {
			Application.LoadLevel("New Act4 Part2 Scene10 room6");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal17(0.0f));
		}
		
		if (col.gameObject.tag == "Portal18") {
			Application.LoadLevel("New Act4 Part2 Scene1");
			renderer.sortingOrder = 33;
			StartCoroutine(MyLoadLevelPortal18(0.0f));
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if(onQuest3){
		if (col.gameObject.tag == "NPC1") {
			NPC1 = false;
			isTrigShow = false;
			disableBts = false;
		}
		}

		if (col.gameObject.tag == "Tubo") {
			Tubo = false;
			isTrigShow = false;
			disableBts = false;
		}

		if(iT1 == false){
			if (col.gameObject.tag == "1") {
				t1 = false;
				isTrigShow = false;
				disableBts = false;
			}
		}

		if(iT2 == false){
			if (col.gameObject.tag == "2") {
				t2 = false;
				isTrigShow = false;
				disableBts = false;
			}
		}

		if(iT3 == false){
			if (col.gameObject.tag == "3") {
				t3 = false;
				isTrigShow = false;
				disableBts = false;
			}
		}

		if(iT4 == false){
			if (col.gameObject.tag == "4") {
				t4 = false;
				isTrigShow = false;
				disableBts = false;
			}
		}

		if(iT5 == false){
			if (col.gameObject.tag == "5") {
				t5 = false;
				isTrigShow = false;
				disableBts = false;
			}
		}

		if(iT6 == false){
			if (col.gameObject.tag == "6") {
				t6 = false;
				isTrigShow = false;
				disableBts = false;
			}
		}

		if(iT7 == false){
			if (col.gameObject.tag == "7") {
				t7 = false;
				isTrigShow = false;
				disableBts = false;
			}
		}
	}

	IEnumerator MyLoadLevelPortal1(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (0.09640121f, -8.400352f, 0);
	}
	
	IEnumerator MyLoadLevelPortal2(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (2.007463f, 0.05058229f, 0);
	}
	
	IEnumerator MyLoadLevelPortal3(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-9.076008f, -6.120605f, 0);
	}
	
	IEnumerator MyLoadLevelPortal4(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (5.31522f, -14.48087f, 0);
	}
	
	IEnumerator MyLoadLevelPortal5(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-0.6420145f, 0.05102152f, 0);
	}
	
	IEnumerator MyLoadLevelPortal6(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (6.569369f, -1.624075f, 0);
	}
	
	IEnumerator MyLoadLevelPortal7(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-2.835311f, -0.3758202f, 0);
	}
	
	IEnumerator MyLoadLevelPortal8(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (1.385067f, -12.18612f, 0);
	}
	
	IEnumerator MyLoadLevelPortal9(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (5.251204f, 0.6451089f, 0);
	}
	
	IEnumerator MyLoadLevelPortal10(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-3.834137f, -10.65597f, 0);
	}
	
	IEnumerator MyLoadLevelPortal11(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-0.1960862f, -1.89428f, 0);
	}
	
	IEnumerator MyLoadLevelPortal12(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-2.534104f, -6.878069f, 0);
	}
	
	IEnumerator MyLoadLevelPortal13(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (1.102929f, -1.151982f, 0);
	}
	
	IEnumerator MyLoadLevelPortal14(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (6.636053f, -12.2124f, 0);
	}
	
	IEnumerator MyLoadLevelPortal15(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (5.221143f, -8.355068f, 0);
	}
	
	IEnumerator MyLoadLevelPortal16(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (14.43932f, -10.73785f, 0);
	}

	IEnumerator MyLoadLevelPortal17(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-1.514129f, -1.135048f, 0);
	}

	IEnumerator MyLoadLevelPortal18(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (9.193883f, -7.679232f, 0);
	}
	void changeGUITexture(bool toBeDisplayed,string label)//r changes the quest holder
	{
		GameObject.Find("GUITexture_"+label).guiTexture.enabled = toBeDisplayed;
	}
	//r

	void showTicker(string itemToget){
		tickerMsg.displayStart(itemToget);//r at 1st scene ticker
	}
}
