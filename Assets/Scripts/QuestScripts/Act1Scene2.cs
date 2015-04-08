
using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]

public class Act1Scene2 : MonoBehaviour {

//	public float checker;
//	public float checkery;
//	public float che;
//	public float cher;

	public float xlabel; //r
	public float ylabel;
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

	public AudioClip[] clip;//r array of sound effects

	public GUIStyle forFont;

	private PlayerMovements touchs;
	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene

	public string[] talkLinesObjects1;
	public string[] talkLinesObjects2;
	public string[] talkLinesObjects3;
	public string[] talkLinesNPC2;
	public int currentLineObject1 = 0;
	public int currentLineObject2 = 0;
	public int currentLineObject3 = 0;
	public int currentLineNPC2 = 0;
	//Storage Position
	public float yinsideHouse;
	public float xinsideHouse;
	public float yinsideVillage;
	public float xinsideVillage;

	public GUITexture bt;

	private bool isButtonShow = false;
	public bool isButtonPressedObjects = false;
	private bool isHide = false;
	private bool isTextWindow = false;
	public bool onQuest1 = true;
	public bool onQuest2a = false;
	public bool onQuest3 = false;
	private bool onQuestFinish = false;
	public bool restrict = true;

	public bool button = false;
	
	private int check = 0;

	public bool Object1 = false;//chest
	public bool Object2 = false;//nanay
	public bool Object3 = false;//bangkero
	public bool NPC2 = false;//neighbor
	
	//declare the ticker class
	private TickerMessage tickerMsg;
	private QuestUnlocked newQuest;
	private string qunlock = "Quest Unlocked!";
	//
	public GameObject pera;

	void Awake(){
		//r initialize ticker class from gameobject //r
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>();
		newQuest = GameObject.Find("GUIQUnlock").GetComponent<QuestUnlocked>();
		touchs = GameObject.Find("Player").GetComponent<PlayerMovements>();
		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r //comment this if you are about to edit the scene

	}
	void Start () {
		MusicAudioListener.enabled=false;//r
		PlayerPrefs.SetInt("stopButton", 0);
		changeGUITexture(false,"tsinelas");
		pera.SetActive(false);
		PlayerPrefs.SetInt("PortalNew", 0);
	}

	void Update () {

		
		buttonsA.pixelInset = new Rect (Screen.width*0.85f, Screen.height*0.1f, (Screen.width)*0.1f, (Screen.height)*0.18f);
		Acts.pixelInset = new Rect (Screen.width*0.51f, Screen.height*1.3f, (Screen.width)*-0.81f, (Screen.height)*-0.82f);//0.71
		Objectivez.pixelInset = new Rect (Screen.width*0.78f, Screen.height*0.81f, (Screen.width)*0.2f, (Screen.height)*0.17f);
		textWindowz.pixelInset = new Rect (Screen.width*0f, Screen.height*0f, (Screen.width)*0.7f, (Screen.height)*0.37f);
		objectivesz.pixelInset = new Rect(Screen.width*0.75f,Screen.height*0.75f,(Screen.width)*-0.5f,(Screen.height)*-0.5f);
		itemHolderz.pixelInset = new Rect(Screen.width*0.0f, Screen.height*0.35f, (Screen.width)*0.2f, (Screen.height)*0.45f);
		
		displayTickerz.pixelOffset= new Vector2(Screen.width*0.27f,Screen.height*0.7f);


//		if(PlayerPrefs.GetInt("stopButton") == 1){
//			button = false;
//		}
//		
//		if(PlayerPrefs.GetInt("stopButton") == 0){
//			button = true;
//		}

		if(onQuest1){//r
			showTicker("slippers");
		}
		ButtonShow ();
		HideTextures ();
		if(button){
		if (Input.touchCount > 0) 
		{
			Touch t = Input.GetTouch(0);
			
			if (t.phase == TouchPhase.Began)
			{
				if(bt.HitTest(t.position, Camera.main)){
				if(restrict){
					if(Object1){
						isTextWindow=true;//r
						isButtonPressedObjects = true;
						isHide = true;
						currentLineObject1++;
						touchs.stopMovements();
					}
				}

				if(Object2){
					isTextWindow=true;//r
					isButtonPressedObjects = true;
					isHide = true;
					touchs.stopMovements();
					if(onQuest2a){
						currentLineObject2++;
					}else{
						check++;
					}
					
				}

				if(Object3){
					isTextWindow=true;//r
					isButtonPressedObjects = true;
					isHide = true;
							touchs.stopMovements();
					if(onQuest3 == false){
						check++;
					}else{
						currentLineObject3++;
					}
				}

				if(NPC2){
					isTextWindow=true;//r
					touchs.stopMovements();
					isButtonPressedObjects = true;
					isHide = true;
					currentLineNPC2++;

				}
				}
			}
		}
	}
		HideTextWindow();
	
	}

	void HideTextures(){
		
		if (isHide) {
			GameObject.Find ("Single Joystick").guiTexture.enabled = false;
		} else {
			GameObject.Find ("Single Joystick").guiTexture.enabled = true;
		}
	}

	void ButtonShow(){
		if (isButtonShow) {
			GameObject.Find ("bt").guiTexture.enabled = true;
		} else {
			GameObject.Find ("bt").guiTexture.enabled = false;	
		}
	
	}
	void HideTextWindow(){//r text window/chatbox
		if (isTextWindow) {
			
			GameObject.Find ("Text Window").guiTexture.enabled = true;
			
		} else {
			
			GameObject.Find ("Text Window").guiTexture.enabled = false;
			
		}
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Portal1") {

			SavePositionHouse();
			Application.LoadLevel("Act 1 Scene 2B");
			renderer.sortingOrder = 90;
			StartCoroutine(MyLoadLevelPortal1(0.1f));


		}

		if (col.gameObject.tag == "Portal2") {

			//Debug.Log ("Hit!");
			GetPositionHouse();
			xinsideHouse--;
			Application.LoadLevel("Act 1 Scene 2A");
			StartCoroutine(MyLoadLevelPortal2(0.0f));
			//transform.position = new Vector3 (xinsideHouse, yinsideHouse, 0);

		}

		if (col.gameObject.tag == "Portal3") {

			//Debug.Log ("Hit!");
			SavePositionVillage();
			renderer.sortingOrder = 50;
			Application.LoadLevel("Act 1 Scene 3");
			StartCoroutine(MyLoadLevelPortal3(0.1f));
			//transform.position = new Vector3 (1, -3, 0);
		}

		if (col.gameObject.tag == "Portal4") {
			
			//Debug.Log ("Hit!");
			GetPositionVillage();
			renderer.sortingOrder = 90;
			xinsideVillage++;
			Application.LoadLevel("Act 1 Scene 2B");
			StartCoroutine(MyLoadLevelPortal4(0.1f));
			//transform.position = new Vector3 (xinsideVillage, yinsideVillage, 0);
		}
	
		if(onQuest1){

			if (col.gameObject.tag == "Object1") {
			
				//Debug.Log ("Hit!");
				isButtonShow = true;
				button = true;
				Object1 = true;

			}
		}

		if (col.gameObject.tag == "Object2") {

			//Debug.Log ("Hit!");
			isButtonShow = true;
			button = true;
			Object2 = true;

		}

		if(col.gameObject.tag == "Object3"){
			//Debug.Log("Hit!");
			isButtonShow = true;
			button = true;
			Object3 = true;

		}

		if (col.gameObject.tag == "NPC2") {
			//Debug.Log ("Hit!");
			isButtonShow = true;
			button = true;
			NPC2 = true;
		}
		
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if(onQuest1){
			if(restrict == true){
			if (col.gameObject.tag == "Object1") 
			{
				//Debug.Log ("Exit!");
				isButtonShow = false;
					button = false;
					Object1 = false;
			}
			}
		}

		if(col.gameObject.tag == "Object2"){
			//Debug.Log ("Exit");
			isButtonShow = false;
			button = false;
			Object2 = false;
		}

		if(col.gameObject.tag == "Object3"){
			//Debug.Log("Exit");
			isButtonShow = false;
			button = false;
			Object3 = false;

		}

		if (col.gameObject.tag == "NPC2") {
			//Debug.Log ("Exit");
			isButtonShow = false;
			button = false;
			NPC2 = false;
		}
		
	}

	void SavePositionHouse(){
		PlayerPrefs.SetFloat ("xPositionInsideHouse", transform.position.x);
		PlayerPrefs.SetFloat ("yPositionInsideHouse", transform.position.y);
	}

	void GetPositionHouse(){
		xinsideHouse = PlayerPrefs.GetFloat ("xPositionInsideHouse");
		yinsideHouse = PlayerPrefs.GetFloat ("yPositionInsideHouse");
	}

	void SavePositionVillage(){
		PlayerPrefs.SetFloat ("xPositionInsideVillage", transform.position.x);
		PlayerPrefs.SetFloat ("yPositionInsideVillage", transform.position.y);
	}

	void GetPositionVillage(){
		xinsideVillage = PlayerPrefs.GetFloat ("xPositionInsideVillage");
		yinsideVillage = PlayerPrefs.GetFloat ("yPositionInsideVillage");
	}

	IEnumerator MyLoadLevelPortal1(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (4, -1, 0);
	}

	IEnumerator MyLoadLevelPortal2(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (xinsideHouse, yinsideHouse, 0);
	}

	IEnumerator MyLoadLevelPortal4(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (xinsideVillage, yinsideVillage, 0);
	}

	IEnumerator MyLoadLevelPortal3(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (1, -3, 0);
	}

	void OnGUI(){

		GUI.skin.label = forFont;//r

		if (isButtonPressedObjects) {
			if(restrict == true){
			if(Object1){

				if(currentLineObject1 < talkLinesObjects1.Length){//r
					GUI.Label (new Rect(Screen.width*xlabel, Screen.height*ylabel, (Screen.width*ylabel), (Screen.height*0.3f)), ""+talkLinesObjects1[currentLineObject1]);


				}else if (currentLineObject1 == 5){
					Object1 = false;
					isTextWindow=false;//r
					isButtonPressedObjects = false;
					onQuest1 = false;
					onQuest2a = true;
					isHide = false;
					isButtonShow = false;
					button = false;
					changeGUITexture(true, "tsinelas");//r
					tickerMsg.displayStart("Look for\nDoña Teodora\noutside the\nhouse.");
					newQuest.displayEnd(qunlock);
						audio.PlayOneShot(clip[0]);
					touchs.release();
					restrict = false;
				}
			}
		}

			if(Object2){
				if(onQuest2a == false){
					if(check == 1){
						GUI.Label (new Rect(Screen.width*xlabel, Screen.height*ylabel, (Screen.width*ylabel), (Screen.height*0.3f)), "Jose what are you doing here? you should be preparing to school.\nFirst,Find your slippers at the house.");
					} else {
						isTextWindow=false;//r
						check = 0;
						isButtonPressedObjects = false;
						isButtonShow = false;
						button = false;
						isHide = false;
						touchs.release();
						Object2 = false;
					}
				}

				if(onQuest2a == true){
					if(currentLineObject2 < talkLinesObjects2.Length){
						GUI.Label (new Rect(Screen.width*xlabel, Screen.height*ylabel, (Screen.width*ylabel), (Screen.height*0.3f)), ""+talkLinesObjects2[currentLineObject2]);
					}

					if (currentLineObject2 == 6){
						isTextWindow=false;//r
						isButtonPressedObjects = false;
						isButtonShow = false;
						button = false;
						isHide = false;
						onQuest3 = true;
						onQuest2a = false;
						pera.SetActive(true);//r
						Object2 = false;
						tickerMsg.displayStart("Find the\nBangkero at\nthe Riverbanks");//r
						newQuest.displayEnd(qunlock);// r dec 6 newquestunlocked
						audio.PlayOneShot(clip[0]);
						touchs.release();

					}
				}

			}

			if(Object3){
				if(onQuest3 == false){
					if(check == 1){
						GUI.Label (new Rect(Screen.width*xlabel, Screen.height*ylabel, (Screen.width*ylabel), (Screen.height*0.3f)), "Hasty for school? You need a fare to cross this river.");
					} else {
						isTextWindow=false;//r
						check = 0;
						isButtonPressedObjects = false;
						isButtonShow = false;
						button = false;
						isHide = false;
						touchs.release();
					}
				}

				if(onQuest3){

					if(currentLineObject3 < talkLinesObjects3.Length){
						GUI.Label (new Rect(Screen.width*xlabel, Screen.height*ylabel, (Screen.width*ylabel), (Screen.height*0.3f)), ""+talkLinesObjects3[currentLineObject3]);

					}else if(currentLineObject3 == 5){
						isTextWindow=false;//r
						isButtonPressedObjects = false;
						isButtonShow = false;
						button = false;
						isHide = false;
						onQuest3 = false;
						touchs.release();
						onQuestFinish = true;
						//r destroying player,guicontrols,maincamera
						Application.LoadLevel(levelToLoad);
						GameObject.FindWithTag("Player").GetComponent<DontDestroy>().enabled=false;
						GameObject.FindWithTag("MainCamera").GetComponent<DontDestroy>().enabled=false;
						GameObject.Find("GUIControls").GetComponent<DontDestroy>().enabled=false;
						Destroy(GameObject.FindWithTag("Player"));
						Destroy(GameObject.FindWithTag("MainCamera"));
						Destroy(GameObject.Find("GUI-groupAct1"));
						Destroy(GameObject.Find("GUIControls"));
						MusicAudioListener.enabled=true;//r

					}

				}

			}

			if(NPC2){
				if(currentLineNPC2 < talkLinesNPC2.Length){//r
					GUI.Label (new Rect(Screen.width*xlabel, Screen.height*ylabel, (Screen.width*ylabel), (Screen.height*0.3f)), ""+talkLinesNPC2[currentLineNPC2]);
				}else if(currentLineNPC2 == 3){
					currentLineNPC2 = 0;
					isTextWindow=false;//r
					isButtonPressedObjects = false;
					isButtonShow = false;
					button = false;
					isHide = false;
					NPC2 = false;
					touchs.release();
				}
			}
		}

	}//shown at the start of the scene
	void showTicker(string itemToget){
		tickerMsg.displayStart("Get his\n"+itemToget+"\ninside the chest");//r a displayticker
		}
	//function to show acquired items
	void changeGUITexture(bool toBeDisplayed,string label){
			GameObject.Find("GUITexture_"+label).guiTexture.enabled = toBeDisplayed;
		}

}
