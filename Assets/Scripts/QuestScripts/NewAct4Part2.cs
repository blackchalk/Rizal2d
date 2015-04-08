	using UnityEngine;
using System.Collections;

public class NewAct4Part2 : MonoBehaviour {

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
	public GUIStyle forFont; //r

	public GUITexture bt;
	private Store st;

	private PlayerMovements touch;
	private AudioListener MusicAudioListener;  //comment this if you are about to edit the scene
	
	public GameObject Antibiotics;
	public GameObject Aspirins;
	public GameObject Vitamins;

	public GameObject Tube1;
	public GameObject Tube2;
	public GameObject Tube3;

	public GUITexture Antibioticss;
	public GUITexture Aspirinss;
	public GUITexture Vitaminss;

	private bool P1 = true;
	private bool P2 = true;
	private bool P3 = true;

	private bool Aspirin = false;
	private bool Vitamin = false;
	private bool Antibiotic = false;

	public bool onCompleteMedicine = false;

	public int asp = 0;
	public int anti = 0;
	public int vit = 0;
	
	public string[] talkLinesNPC1;
	public int currentLine1 = 0;
	public string[] talkLinesNPC1b;
	public int currentLine1b = 0;
	public string[] talkLinesNPC1c;
	public int currentLine1c = 0;
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

	public int otherLine1 = 0;

	//Quests
	public bool onQuest1 = true;
	public bool onQuest2 = false;//Medicine Quest
	public bool onQuest3 = false;//Teaching Quest
	public bool onQuest4 = false;//Meeting the Villager
	public bool onQuest5 = false;//Meeting Bracken and Taufer
	public bool QuestComplete = false;//END -> NEXT SCENE (TUBO SCENE/QUEST) DELETE THIS SCRIPT

	//checkers
	private bool isTrigShow = false;
	private bool isHide = false;
	public bool isButtonPressedNPC = false;
	private bool isTextWindow=false;
	
	private bool hideTransition1 = false;
	//NPCS
	private bool NPC1 = false;
	private bool NPC2 = false;//Patient1
	private bool NPC3 = false;//Patient2
	private bool NPC4 = false;//Patient3
	private bool NPC5 = false;//Floor
	private bool NPC6 = false;//Bracken / Taufer

	private bool Patient1 = false;//Aspirin
	private bool Patient2 = false;//Antibiotic
	private bool Patient3 = false;//Vitamin

	//tickermessage
	private TickerMessage tickerMsg; //r
	private QuestUnlocked newQuest;
	private string qunlock = "New Quest Unlocked!";

	public int visitedpatient = 3;

	private bool disableBt = false;

	void MakeAllFalse(){
		Antibiotics.SetActive (false);
		Aspirins.SetActive (false);
		Vitamins.SetActive (false);
	}

	void AllFalse(){
		Tube1.SetActive (false);
		Tube2.SetActive (false);
		Tube3.SetActive (false);
	}

	void MedicineCheck(){
		
		if(Aspirin == false && Vitamin == false && Antibiotic == false){
			Antibiotics.SetActive (true);
			Aspirins.SetActive (true);
			Vitamins.SetActive (true);
		}
		
		if(Aspirin == false && Vitamin == false){
			Aspirins.SetActive (true);
			Vitamins.SetActive (true);
		}
		
		if(Aspirin == false && Antibiotic == false){
			Aspirins.SetActive (true);
			Antibiotics.SetActive (true);
		}
		
		if(Vitamin == false && Antibiotic == false){
			Vitamins.SetActive (true);
			Antibiotics.SetActive (true);
		}
		
		if(Aspirin == false){
			Aspirins.SetActive (true);
		}
		
		if(Antibiotic == false){
			Antibiotics.SetActive (true);
		}
		
		if(Vitamin == false){
			Vitamins.SetActive (true);
		}
	}

	void MedicineStatementVit(){
		
		if (P3 == false) {
			
			if (Vitamin) {
				vit = 1;
			}
		} else {
			if(P1 == false){
				P1 = true;

			}
			
			if(P2 == false){
				P2 = true;
			}
			vit = 0;
		}
	}
	
	void MedicineStatementAspi(){
		
		if (P1 == false) {
			
			if (Aspirin) {
				asp = 1;
			}
		} else {
			asp = 0;
			if(P2 == false){
				P2 = true;
			}
			
			if(P3 == false){
				P3 = true;
			}
		}
		
	}
	
	void MedicineStatementAnti(){
		
		if (P2 == false) {
			
			if (Antibiotic) {
				anti = 1;
			}
		} else {
			anti = 0;
			if(P1 == false){
				P1 = true;
			}
			
			if(P3 == false){
				P3 = true;
			}
		}
	}

	void CompleteQuest(){
		if(Aspirin == true && Vitamin == true && Antibiotic == true){
			onCompleteMedicine = true;

		}
	}


	void Awake(){
		GameObject.Find("Player").GetComponent<NewAct4Part3>().enabled = false;
		MakeAllFalse ();
		AllFalse ();
		touch = GameObject.Find("Player").GetComponent<PlayerMovements>();
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>(); //r
		newQuest = GameObject.Find ("GUIQUnlock").GetComponent<QuestUnlocked>();
		st = GameObject.Find ("Store").GetComponent<Store>();
		MusicAudioListener = GameObject.Find("MusicManager").GetComponent<AudioListener>();//r //comment this if you are about to edit the scene
	}

	void Start () {
		MusicAudioListener.enabled=false;

		changeGUITexture(false,"asp");
		changeGUITexture(false,"anti");
		changeGUITexture(false,"vit");

		changeGUITexture(false,"tubo1");
		changeGUITexture(false,"tubo2");
		changeGUITexture(false,"tubo3");


		PlayerPrefs.SetInt("NPC", 0);
		PlayerPrefs.SetInt("Activate", 0);

		PlayerPrefs.SetInt("Tube1", 0);
		PlayerPrefs.SetInt("Tube2", 0);
		PlayerPrefs.SetInt("Tube3", 0);
		PlayerPrefs.SetInt("Tube4", 0);
		PlayerPrefs.SetInt("Tube5", 0);
		PlayerPrefs.SetInt("Tube6", 0);
		PlayerPrefs.SetInt("Tube7", 0);

		PlayerPrefs.SetInt("A", 0);
		PlayerPrefs.SetInt("B", 0);
		PlayerPrefs.SetInt("C", 0);
		PlayerPrefs.SetInt("D", 0);
		PlayerPrefs.SetInt("E", 0);
		PlayerPrefs.SetInt("F", 0);
		PlayerPrefs.SetInt("G", 0);

		PlayerPrefs.SetInt("stopButton", 0);

		//newQuest.displayEnd(qunlock);
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

		if (onQuest1){

			showTicker("Go to the\nbig house and\nget the Medicine\nQuest from the\nbrgy captain");
		}

//		if(PlayerPrefs.GetInt("stopButton") == 1){
//			disableBt = false;
//		}
//		
//		if(PlayerPrefs.GetInt("stopButton") == 0){
//			disableBt = true;
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

		if(disableBt){
		if (Input.GetMouseButtonDown (0)) {
			if (bt.HitTest (Input.mousePosition, Camera.main)) {
				if(NPC1 == true){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					if(onQuest1 == true){
						currentLine1++;
					} else if (onQuest2 == true){
						if(onCompleteMedicine){
							if(asp == 1 && vit == 1 && anti == 1){
								currentLine1b++;
							} else { 
								otherLine1++;
							}
						} else {
							otherLine1++;
						}
					} else if (onQuest4 == true){
						currentLine1c++;
					} else {
						otherLine1++;
					}
				}

				if(NPC2 == true){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					if(onQuest2 == true){
						currentLine2++;
					}else{
						otherLine1++;
					}
				}

				if(NPC3 == true){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					if(onQuest2 == true){
						currentLine3++;
					}else{
						otherLine1++;
					}
				}

				if(NPC4 == true){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					if(onQuest2 == true){
						currentLine4++;
					}else{
						otherLine1++;
					}
				}

				if(NPC5 == true){
						//touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					if(onQuest3 == true){
						currentLine5++;
					}else{
						otherLine1++;
					}
				}

				if(NPC6 == true){
						touch.stopMovements();
					isButtonPressedNPC = true;
						isTextWindow=true;
					if(onQuest5 == true){
						currentLine6++;
					}else{
						otherLine1++;
					}
				}

				isHide = true;
			}
			
			if (Aspirinss.HitTest (Input.mousePosition, Camera.main)) {
				//Debug.Log("Aspirin");
				Aspirin = true;
					audio.PlayOneShot(clip[1]);//gulp sfx
				MedicineStatementAspi();
				MakeAllFalse();

					disableBt = false;
					touch.release();
					isHide = false;
				
			}
			
			if (Vitaminss.HitTest (Input.mousePosition, Camera.main)) {
				//Debug.Log("Vitamins");
				Vitamin = true;
					audio.PlayOneShot(clip[1]);//gulp sfx
				MedicineStatementVit();
				MakeAllFalse();

					disableBt = false;
					touch.release();
					isHide = false;
			}
			
			if (Antibioticss.HitTest (Input.mousePosition, Camera.main)) {
				//Debug.Log("Antibiotic");
				Antibiotic = true;
					audio.PlayOneShot(clip[1]);//gulp sfx
				MedicineStatementAnti();
				MakeAllFalse();

					disableBt = false;
					touch.release();
					isHide = false;
			}
		}
	}
	

		CompleteQuest ();
		HideBt ();
		HideTextures ();
		Transition ();
		HideTextWindow();
	}

	void OnGUI(){

		CheckVisit();
		GUI.skin.label=forFont; //style r
		GUI.contentColor = Color.yellow;
		if (isButtonPressedNPC) {
			if (NPC1) {
				if (onQuest1) {

					if (currentLine1 < talkLinesNPC1.Length) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC1 [currentLine1] + "\n");
					} else if (currentLine1 == 7){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC1 = false;
						isHide = false;
						isTrigShow = false;
						onQuest1 = false;
						onQuest2 = true;
						Patient1 = true;
						Patient2 = true;
						Patient3 = true;
						disableBt = false;
						touch.release();
						//
						changeGUITexture(true,"asp");
						changeGUITexture(true,"anti");
						changeGUITexture(true,"vit");
						newQuest.displayEnd(qunlock);
						audio.PlayOneShot(clip[0]);
						showTicker("Visit each 3\npatient's house\nand give\nthem right\nMedicine");
					}
				} else if (onQuest2){
					if(onCompleteMedicine == false){
						 
						if (otherLine1 == 1) {
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Rizal there are still someone in need of a doctor\nout there.");
						} else {
							NPC1 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							disableBt = false;
							touch.release();
							//
							showTicker("Medicine quest\nis not yet\ncomplete.\nMake sure\nyou have\nvisited\n3 patients");
						}
					}

					if(onCompleteMedicine == true){
						//r

						if(asp == 1 && vit == 1 && anti == 1){
							if(currentLine1b < talkLinesNPC1b.Length){
								GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC1b[currentLine1b]);
							}else if (currentLine1b==5){//r added currentline here
								isButtonPressedNPC = false;
								isTextWindow=false;
								isTrigShow = false;
								isHide = false;
								onQuest2 = false;
								onQuest3 = true;
								NPC1 = false;
								disableBt = false;
								touch.release();
								//
								newQuest.displayEnd(qunlock);
								audio.PlayOneShot(clip[0]);
								showTicker("Rizal managed\nto build a\nSCHOOL\nin town,\nFind It!");
							}
						} else {
							if (otherLine1 == 1) {
								 
								GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "I'm sorry Dr. Rizal the patients are not satisfied\n can you please try again? ");
							} else {
								NPC1 = false;
								isTrigShow = false;
								otherLine1 = 0;
								isButtonPressedNPC = false;
								isTextWindow=false;
								isHide = false;
								//
								Patient1 = true;
								Patient2 = true;
								Patient3 = true;
								Aspirin = false;
								Vitamin = false;
								Antibiotic = false;
								P1 = true;
								P2 = true;
								P3 = true;
								currentLine2 = 0;
								currentLine3 = 0;
								currentLine4 = 0;
								asp = 0;
								vit = 0;
								anti = 0;
								disableBt = false;
								touch.release();
								showTicker("Medicine quest\nis Not yet\nComplete.\nTry again.");
							}
						}
					}
				} else if (onQuest4){
					if (currentLine1c < talkLinesNPC1c.Length) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC1c [currentLine1c] + "\n");
					} else if (currentLine1c == 9){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC1 = false;
						isHide = false;
						isTrigShow = false;
						onQuest4 = false;
						PlayerPrefs.SetInt("NPC", 1);
						onQuest5 = true;
						disableBt = false;
						touch.release();
						//
						newQuest.displayEnd(qunlock);
						audio.PlayOneShot(clip[0]);
						showTicker("Someone is\nlooking for\nyou go back\nto your house");
					}
				} else {
					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Oh. Rizal how are you doing?");
					} else {
						NPC1 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						disableBt = false;
						touch.release();
					}
				}
			}

			if(NPC2){
				if(onQuest2){
					if(Patient1){
						if (currentLine2 < talkLinesNPC2.Length) {
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC2 [currentLine2] + "\n");
						} else if (currentLine2 == 11){ //set to right amount of text in array
							isButtonPressedNPC = false;
							isTextWindow=false;
							NPC2 = false;
							//isHide = false;
							isTrigShow = false;
							Patient1 = false;
							//disableBt = false;
							//touch.release();
							P1 = false;//Checking of Medicine (sign of the patient if it is the correct patient)
							MedicineCheck ();

						}
					} else {
						if (otherLine1 == 1) {
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "Thanks Dr. Rizal.");
						} else {
							NPC2 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							disableBt = false;
							touch.release();
						}
					}
				} else{

					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "...");
					} else {
						NPC2 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						disableBt = false;
						touch.release();
					}
				}
			}

			if(NPC3){
				if(onQuest2){
					if(Patient2){
						if (currentLine3 < talkLinesNPC3.Length) {
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC3 [currentLine3] + "\n");
						} else if (currentLine3 == 11){ //set to right amount of text in array
							isButtonPressedNPC = false;
							isTextWindow=false;
							NPC3 = false;
							//isHide = false;
							isTrigShow = false;
							Patient2 = false;
							P2 = false;//Checking of Medicine (sign of the patient if it is the correct patient)
							//disableBt = false;
							//touch.release();
							MedicineCheck ();
						}
					} else {
						if (otherLine1 == 1) {
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "I'm feeling better now... i think.");
						} else {
							NPC3 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							disableBt = false;
							touch.release();
						}
					}
				} else{
					
					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "...");
					} else {
						NPC3 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						disableBt = false;
						touch.release();
					}
				}
			}

			if(NPC4){
				if(onQuest2){
					if(Patient3){
						if (currentLine4 < talkLinesNPC4.Length) {
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC4 [currentLine4] + "\n");
						} else if (currentLine4 == 12){ //set to right amount of text in array
							isButtonPressedNPC = false;
							isTextWindow=false;
							NPC4 = false;
							//isHide = false;
							isTrigShow = false;
							Patient3 = false;
							P3 = false;//Checking of Medicine (sign of the patient if it is the correct patient)
							MedicineCheck ();
							//disableBt = false;
							//touch.release();
						}
					} else {
						if (otherLine1 == 1) {
							GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "I'm gonna be okay right?");
						} else {
							NPC4 = false;
							isTrigShow = false;
							otherLine1 = 0;
							isButtonPressedNPC = false;
							isTextWindow=false;
							isHide = false;
							disableBt = false;
							touch.release();
						}
					}
				} else{
					
					if (otherLine1 == 1) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "...");
					} else {
						NPC4 = false;
						isTrigShow = false;
						otherLine1 = 0;
						isButtonPressedNPC = false;
						isTextWindow=false;
						isHide = false;
						disableBt = false;
						touch.release();
					}
				}
			}

			if(NPC5){
				if (onQuest3) {
					if (currentLine5 < talkLinesNPC5.Length) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC5 [currentLine5] + "\n");
					} else if (currentLine5 == 2){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC5 = false;
						isHide = false;
						isTrigShow = false;
						onQuest3 = false;
						onQuest4 = true;
						hideTransition1 = true;
						disableBt = false;
						StartCoroutine(myTransition1(5.0f));
						//
						newQuest.displayEnd(qunlock);
						audio.PlayOneShot(clip[0]);
						showTicker("Go back to\nthe Brgy\nHall and\ntalk to\nthe captain");
					}
				}
			}

			if(NPC6){
				if (onQuest5) {
					if (currentLine6 < talkLinesNPC6.Length) {
						GUI.Label (new Rect (Screen.width * xLabel, Screen.height * yLabel, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesNPC6 [currentLine6] + "\n");
					} else if (currentLine6 == 14){ //set to right amount of text in array
						isButtonPressedNPC = false;
						isTextWindow=false;
						NPC6 = false;
						//isHide = false;
						//isTrigShow = false;
						onQuest5 = false;
						QuestComplete = true;
						touch.stopMovements();
						hideTransition1 = true;
						st.indicator1 = 1;
						//disableBt = false;
						StartCoroutine(myTransition2(5.0f));
						//Destroy this script
						//Next scene / Tubo Scene
						//GameObject.Find("Player").GetComponent<NewAct4Part2>().enabled = false;

					}
				}
			}
		}
	}

	void Transition(){
		
		if (hideTransition1 == false) {
			GameObject.Find ("transition1").guiTexture.enabled = false;
			GameObject.Find("MonoText1").guiText.enabled = false;//r
			GameObject.Find("MonoText2").guiText.enabled = false;//r
			//GameObject.Find("MonoText3").guiText.enabled = false;//r
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
		//NPCS
		if (col.gameObject.tag == "NPC1") {
			isTrigShow = true;
			NPC1 = true;
			disableBt = true;
		}

		if (col.gameObject.tag == "NPC2") {
			isTrigShow = true;
			NPC2 = true;
			disableBt = true;
		}

		if (col.gameObject.tag == "NPC3") {
			isTrigShow = true;
			NPC3 = true;
			disableBt = true;
		}

		if (col.gameObject.tag == "NPC4") {
			isTrigShow = true;
			NPC4 = true;
			disableBt = true;
		}

		if(onQuest3){
			if (col.gameObject.tag == "NPC5") {
				isTrigShow = true;
				NPC5 = true;
				disableBt = true;
				touch.stopMovements();
			}
		}

		if (col.gameObject.tag == "NPC6") {
			isTrigShow = true;
			NPC6 = true;
			disableBt = true;
		}
		//pair
		if (col.gameObject.tag == "Portal5") {
			Application.LoadLevel("New Act4 Part2 Scene1");
			renderer.sortingOrder = 32;
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
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal3(0.0f));
		}

		if (col.gameObject.tag == "Portal3") {
			Application.LoadLevel("New Act4 Part2 Scene1");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal4(0.0f));
		}
		//pair

		if (col.gameObject.tag == "Portal6") {
			Application.LoadLevel("New Act4 Part2 Scene9 room5");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal5(0.0f));
		}

		if (col.gameObject.tag == "Portal7") {
			Application.LoadLevel("New Act4 Part2 Scene2");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal6(0.0f));
		}
		//pair

		if (col.gameObject.tag == "Portal8") {
			Application.LoadLevel("New Act4 Part2 Scene5 room2");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal7(0.0f));
		}

		if (col.gameObject.tag == "Portal9") {
			Application.LoadLevel("New Act4 Part2 Scene2");
			renderer.sortingOrder = 32;
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
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal10(0.0f));
		}
		//pair

		if (col.gameObject.tag == "Portal10") {
			Application.LoadLevel("New Act4 Part2 Scene6 room3");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal11(0.0f));
		}

		if (col.gameObject.tag == "Portal11") {
			Application.LoadLevel("New Act4 Part2 Scene3");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal12(0.0f));
		}
		//pair

		if (col.gameObject.tag == "Portal12") {
			Application.LoadLevel("New Act4 Part2 Scene7 room4");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal13(0.0f));
		}

		if (col.gameObject.tag == "Portal13") {
			Application.LoadLevel("New Act4 Part2 Scene3");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal14(0.0f));
		}
		//pair

		if (col.gameObject.tag == "Portal14") {
			Application.LoadLevel("New Act4 Part2 Scene8 classroom");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal15(0.0f));
		}

		if (col.gameObject.tag == "Portal15") {
			Application.LoadLevel("New Act4 Part2 Scene3");
			renderer.sortingOrder = 32;
			StartCoroutine(MyLoadLevelPortal16(0.0f));
		}

	}

	void OnTriggerExit2D(Collider2D col) {
		
		if (col.gameObject.tag == "NPC1") {
			isTrigShow = false;
			NPC1 = false;
			disableBt = false;
		}

		if (col.gameObject.tag == "NPC2") {
			isTrigShow = false;
			NPC2 = false;
			disableBt = false;
		}

		if (col.gameObject.tag == "NPC3") {
			isTrigShow = false;
			NPC3 = false;
			disableBt = false;
		}

		if (col.gameObject.tag == "NPC4") {
			isTrigShow = false;
			NPC4 = false;
			disableBt = false;
		}

		if (col.gameObject.tag == "NPC6") {
			isTrigShow = false;
			NPC6 = false;
			//disableBt = false;
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

	IEnumerator myTransition1(float delay)
	{
		GameObject.Find("MonoText1").guiText.enabled = true;//r
		yield return new WaitForSeconds(delay);
		hideTransition1 = false;
		touch.release ();
	}

	IEnumerator myTransition2(float delay)
	{
		GameObject.Find("MonoText2").guiText.enabled = true;//r
		yield return new WaitForSeconds(delay);
		PlayerPrefs.SetInt("NPC", 0);
		renderer.sortingOrder = 16;
		Application.LoadLevel ("New Act4 Part2 Scene4 room1 - Copy");
		//touch.release ();
		disableBt = true;
		hideTransition1 = false;
		transform.position = new Vector3 (-5.561093f, -0.9029417f, 0);
		GameObject.Find("Player").GetComponent<NewAct4Part3>().enabled = true;
		PlayerPrefs.SetInt("Activate", 1);
		StartCoroutine(myTransition3(1.0f));
	}

	IEnumerator myTransition3(float delay)
	{
		//GameObject.Find("MonoText3").guiText.enabled = true;//r
		yield return new WaitForSeconds(delay);
		Destroy (GetComponent<NewAct4Part2>());
		Destroy (GameObject.Find ("Choices"), 1);
		showTicker("");
		disableBt = true;
	}
	//r
	void showTicker(string itemToget){
		tickerMsg.displayStart(itemToget);//r at 1st scene ticker
	}
	void CheckVisit(){ //checks the number of visit to patients
		int num = visitedpatient;
		if((asp==1)&&(num!=0)&&(!onQuest3)&&(!onQuest4)&&(!onQuest5)){
			num--;
			changeGUITexture(false,"asp");
			showTicker("You still\nhave "+num+"\npatient(s) to\nvisit");
		}
		if((anti==1)&&(num!=0)&&(!onQuest3)&&(!onQuest4)&&(!onQuest5)){
			num--;
			changeGUITexture(false,"anti");
			showTicker("You still\nhave "+num+"\npatient(s) to\nvisit");
		}
		if((vit==1)&&(num!=0)&&(!onQuest3)&&(!onQuest4)&&(!onQuest5)){
			num--;
			changeGUITexture(false,"vit");
			showTicker("You still\nhave "+num+"\npatient(s) to\nvisit");
		}
		if((num==0)&&(!onQuest3)&&(!onQuest4)&&(!onQuest5)){

			showTicker("Go back\nto the\nBrgy Hall\nand talk\nto the\ncaptain");
		}

	}
	void changeGUITexture(bool toBeDisplayed,string label)//r changes the quest holder
	{
		GameObject.Find("GUITexture_"+label).guiTexture.enabled = toBeDisplayed;
	}
}
