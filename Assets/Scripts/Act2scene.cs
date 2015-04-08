using UnityEngine;
using System.Collections;

public class Act2scene : MonoBehaviour {

	public GUIStyle forFont;

	private TouchControlsNEW touch;

	public GameObject Antibiotics;
	public GameObject Aspirins;
	public GameObject Vitamins;
	public GameObject Uncle;

	public GameObject Controls;
	public GameObject btt;

	public GUITexture bt;
	public GUITexture Antibioticss;
	public GUITexture Aspirinss;
	public GUITexture Vitaminss;

	public string[] talkLinesNPC1;
	public int currentLine1 = 0;
	public string[] talkLinesNPC1b;
	public int currentLine1b = 0;

	public string[] talkLinesNPC2;
	public int currentLine2 = 0;

	public string[] talkLinesNPC3;
	public int currentLine3 = 0;

	public string[] talkLinesNPC4;
	public int currentLine4 = 0;

	public string[] talkLinesNPCUncle;
	public int currentLineU = 0;

	public int check = 0;

	private bool isHide = false;
	private bool isButtonShow = false;
	private bool isButtonPressedNPC = false;
	private bool finalQuest = false;

	private bool onQuest1 = false;
	private bool onCompleteMedicine = false;
	private bool onQuestFinished = false;

	private float xinsideHouse;
	private float yinsideHouse;

	private bool startDialogue = false;

	private bool NPC1 = false;
	private bool NPC2 = false;
	private bool NPC3 = false;
	private bool NPC4 = false;
	private bool Side1 = false;
	private bool Side2 = false;
	private bool Side3 = false;
	private bool NPCUncle = false;

	private bool Patient1 = false;//Aspirin
	private bool Patient2 = false;//Vitamin
	private bool Patient3 = false;//Antibiotic

	private bool P1 = true;
	private bool P2 = true;
	private bool P3 = true;

	private bool Aspirin = false;
	private bool Vitamin = false;
	private bool Antibiotic = false;

	public int asp = 0;
	public int anti = 0;
	public int vit = 0;

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
				P1 =true;
			}

			if(P3 == false){
				P3 = true;
			}
		}
	}

	void MakeAllFalse(){
		Antibiotics.SetActive (false);
		Aspirins.SetActive (false);
		Vitamins.SetActive (false);
	}

	void CompleteQuest(){
		if(Aspirin == true && Vitamin == true && Antibiotic == true){
			onCompleteMedicine = true;
		}
	}
	void nextScene(){
		if (onQuestFinished) {
			transform.position = new Vector3 (-6.438818f, -2.257117f, 0);;
			Application.LoadLevel("Act2Scene4 - Copy");
			isButtonShow = true;
			isHide = true;
		}
	}
	

	void Awake(){
		MakeAllFalse();
		ButtonShow ();
		touch = GameObject.Find ("Player").GetComponent<TouchControlsNEW> ();
	}

	void Start () {
		//HideTextures ();
		//ButtonShow ();
		//MakeAllFalse();
	}
	

	void Update () {
		CompleteQuest ();
		HideTextures ();
		//HideTextures ();
		//ButtonShow ();

		if (Input.GetMouseButtonDown (0)) {
			if (bt.HitTest (Input.mousePosition, Camera.main)) {

				if(NPC1){
					isButtonPressedNPC = true;
					isHide = true;
					touch.StopMove();
					touch.StopAnim();
					if(onQuest1 == false){
						currentLine1++;
					}else{
						if(onCompleteMedicine == false){
							check++;
						}else{
							if(asp == 1 && vit == 1 && anti == 1){
								currentLine1b++;
							}else{
								check++;
							}
						}
					}

				}

				if(NPC2){
					isButtonPressedNPC = true;
					isHide = true;
					touch.StopMove();
					touch.StopAnim();
					if(onQuest1 == false){
						check++;
					}else{
						currentLine2++;
					}
				}

				if(NPC3){
					isButtonPressedNPC = true;
					isHide = true;
					touch.StopMove();
					touch.StopAnim();
					if(onQuest1 == false){
						check++;
					}else{
						currentLine3++;
					}
				}

				if(NPC4){
					isButtonPressedNPC = true;
					isHide = true;
					touch.StopMove();
					touch.StopAnim();
					if(onQuest1 == false){
						check++;
					}else{
						currentLine4++;
					}
				}

				if(Side1){
					touch.StopMove();
					touch.StopAnim();
					isButtonPressedNPC = true;
					isHide = true;
					check++;
				}

				if(Side2){
					touch.StopMove();
					touch.StopAnim();
					isButtonPressedNPC = true;
					isHide = true;
					check++;
				}

				if(Side3){
					touch.StopMove();
					touch.StopAnim();
					isButtonPressedNPC = true;
					isHide = true;
					check++;
				}

				if(onQuestFinished){
					touch.StopMove();
					touch.StopAnim();
					startDialogue = true;
					check++;
				}

				if(NPCUncle){
					touch.StopMove();
					touch.StopAnim();
					Debug.Log("Hit!");
					isButtonPressedNPC = true;
					isHide = true;
					currentLineU++;
				}
			}

			if (Aspirinss.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Aspirin");
				Aspirin = true;
				MedicineStatementAspi();
				MakeAllFalse();
				touch.Go();
				touch.GoAnim();
				btt.SetActive(true);
			}
			
			if (Vitaminss.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Vitamins");
				Vitamin = true;
				MedicineStatementVit();
				MakeAllFalse();
				touch.Go();
				touch.GoAnim();
				btt.SetActive(true);
			}

			if (Antibioticss.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Antibiotic");
				Antibiotic = true;
				MedicineStatementAnti();
				MakeAllFalse();
				touch.Go();
				touch.GoAnim();
				btt.SetActive(true);
			}
		}
	
	}
	
	void OnGUI(){
		if(startDialogue){
			if(check == 1){
				GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "Now that i Finished my studies here it is time for me to go to Spain.\n i need to see my uncle so that i can take my passport.");
			}else{
				check = 0;
				isButtonShow = false;
				isHide =false;
				onQuestFinished = false;
				touch.Go();
				touch.GoAnim();
			}
		}


		if (isButtonPressedNPC) {
			if(NPC1){
				if(onQuest1 == false){
					if(currentLine1 < talkLinesNPC1.Length){
						GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), ""+talkLinesNPC1[currentLine1]);
					}else if(currentLine1 == 38){
						isButtonPressedNPC = false;
						onQuest1 = true;
						Patient1 = true;
						Patient2 = true;
						Patient3 = true;
						isHide = false;
						//isButtonShow = false;
						touch.Go();
						touch.GoAnim();

					}
				}

				if(onQuest1 == true){
					if(onCompleteMedicine == false){
						if(check == 1){
							GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "You're still here? You better get going.");
						}else{
							check = 0;
							isButtonPressedNPC = false;
							isButtonShow = false;
							isHide = false;
							touch.Go();
							touch.GoAnim();
						}
					}

					if(onCompleteMedicine == true){
						if(asp == 1 && vit == 1 && anti == 1){
							if(currentLine1b < talkLinesNPC1b.Length){
								GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), ""+talkLinesNPC1b[currentLine1b]);
							}else{
								isButtonPressedNPC = false;
								isButtonShow = false;
								isHide = false;
								onQuest1 = false;
								onQuestFinished = true;
								//nextScene ();
								finalQuest = true;
								Debug.Log("Finish!");
								touch.Go();
								touch.GoAnim();
							}
						}else{
							if(check==1){
								GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "Mr. Rizal you failed. Can you try again?");
							}else{
								check = 0;
								isButtonPressedNPC = false;
								isButtonShow = false;
								isHide = false;
								onQuest1 = true;
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
								touch.Go();
								touch.GoAnim();
							}
						}
					}
				}
			}

			if(NPC2){
				if(onQuest1 == true){
					if(Patient1){
						if(currentLine2 < talkLinesNPC2.Length){
							GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), ""+talkLinesNPC2[currentLine2]);
						}else if(currentLine2 == 13){
							isButtonPressedNPC = false;
							isHide = false;
							isButtonShow = false;
							MedicineCheck();
							Patient1 = false;
							P1 = false;
							//touch.Go();
							//touch.GoAnim();
							btt.SetActive(false);
						}
					}
				}else{
					if(check == 1){
						GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "...");
					}else{
						touch.Go();
						touch.GoAnim();
						check = 0;
						isButtonPressedNPC = false;
						isButtonShow = false;
						isHide = false;
					}
				}
				
			}

			if(NPC3){
				if(onQuest1 == true){
					if(Patient2){
						if(currentLine3 < talkLinesNPC3.Length){
							GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), ""+talkLinesNPC3[currentLine3]);
						}else if(currentLine3 == 10){
							isButtonPressedNPC = false;
							isHide = false;
							isButtonShow = false;
							MedicineCheck();
							Patient2 = false;
							P2 = false;
							//touch.Go();
							//touch.GoAnim();
							btt.SetActive(false);
						}
					}
				}else{
					if(check == 1){
						GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "...");
					}else{
						check = 0;
						isButtonPressedNPC = false;
						isButtonShow = false;
						isHide = false;
						touch.Go();
						touch.GoAnim();
					}
				}
			}

			if(NPC4){
				if(onQuest1 == true){
					if(Patient3){
						if(currentLine4 < talkLinesNPC4.Length){
							GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), ""+talkLinesNPC4[currentLine4]);
						}else if(currentLine4 == 11){
							isButtonPressedNPC = false;
							isHide = false;
							isButtonShow = false;
							MedicineCheck();
							Patient3 = false;
							P3 = false;
							//touch.Go();
							//touch.GoAnim();
							btt.SetActive(false);
						}

					}
				}else{
					if(check == 1){
						GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "...");
					}else{
						check = 0;
						isButtonPressedNPC = false;
						isButtonShow = false;
						isHide = false;
						touch.Go();
						touch.GoAnim();
					}
				}
			}

			if(Side1){
				if(check == 1){
					GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "I think he is suffering from a fever? Oh wait, are you a doctor?");
				}else{
					check = 0;
					isButtonPressedNPC =false;
					isButtonShow = false;
					isHide =false;
					touch.Go();
					touch.GoAnim();
				}
			}

			if(Side2){
				if(check == 1){
					GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "Can you help me? My daughter is suffering from a wound from her legs.");
				}else{
					check = 0;
					isButtonPressedNPC =false;
					isButtonShow = false;
					isHide =false;
					touch.Go();
					touch.GoAnim();
				}
			}

			if(Side3){
				if(check == 1){
					GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), "My wife gets very tired these days i wonder what should i do?");
				}else{
					check = 0;
					isButtonPressedNPC =false;
					isButtonShow = false;
					isHide =false;
					touch.Go();
					touch.GoAnim();
				}
			}

			if(NPCUncle){
				if(currentLineU < talkLinesNPCUncle.Length){
					GUI.Label (new Rect(Screen.width*0.01f, Screen.height*0.6f, (Screen.width*0.6f), (Screen.height*0.3f)), ""+talkLinesNPCUncle[currentLineU]);
				}else if(currentLineU == 9){
					isButtonPressedNPC =false;
					isButtonShow = false;
					isHide =false;
					touch.Go();
					touch.GoAnim();
				}
			}
			
		}
		
	}

	void HideTextures(){
		
		if (isHide) {
			Controls.SetActive(false);
		} else {
			Controls.SetActive(true);
		}
	}
	
	void ButtonShow(){
		btt.SetActive(false);	
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Portal1") {
			DontDestroyOnLoad (this);
			SavePositionHouse();
			Application.LoadLevel("Act2Scene1");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal1(0.0f));
			//touch.StopMove();
		}

		if (col.gameObject.tag == "Portal2") {
			
			GetPositionHouse();
			xinsideHouse--;
			Application.LoadLevel("Act2Scene4 - Copy");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal2(0.0f));
			//touch.StopMove();
		}

		if (col.gameObject.tag == "Portal3") {
			

			Application.LoadLevel("Act2Scene3");
			renderer.sortingOrder = 19;
			StartCoroutine(MyLoadLevelPortal3(0.0f));
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal4") {
			
			
			Application.LoadLevel("Act2Scene1");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal4(0.0f));
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal5") {
			
			
			Application.LoadLevel("Act2Scene2");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal5(0.0f));
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal6") {

			Application.LoadLevel("Act2Scene1");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (6.263939f, -7.828032f, 0);
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal7") {
			
			Application.LoadLevel("Act2Scene5 - Copy");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal7(0.0f));
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal8") {
			
			Application.LoadLevel("Act2Scene2");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal8(0.0f));
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal9") {
			
			Application.LoadLevel("Act2Scene5");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (-2.835311f, -0.3758202f, 0);
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal10") {
			
			Application.LoadLevel("Act2Scene2");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (0f, 2f, 0);
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal11") {
			
			Application.LoadLevel("Act2Scene5 - Copy - Copy");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (1f, -1f, 0);
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "Portal12") {
			
			Application.LoadLevel("Act2Scene2");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (-5f, 1f, 0);
			//touch.StopMove();
			
		}

		if (col.gameObject.tag == "NPC1") {
			btt.SetActive(true);
			NPC1 = true;
		}

		if (col.gameObject.tag == "NPC2") {
			btt.SetActive(true);
			NPC2 = true;
		}

		if (col.gameObject.tag == "NPC3") {
			btt.SetActive(true);
			NPC3 = true;
		}

		if (col.gameObject.tag == "NPC4") {
			btt.SetActive(true);
			NPC4 = true;
		}

		if (col.gameObject.tag == "Side1") {
			btt.SetActive(true);
			Side1 = true;
		}

		if (col.gameObject.tag == "Side2") {
			btt.SetActive(true);
			Side2 = true;
		}

		if (col.gameObject.tag == "Side3") {
			btt.SetActive(true);
			Side3 = true;
		}

		if(finalQuest){
			if(col.gameObject.tag == "NPCUncle"){
				btt.SetActive(true);
				NPCUncle = true;
			}
		}

	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "NPC1") {
			//isButtonShow = false;
			btt.SetActive(false);
			NPC1 = false;
			if(onQuestFinished){
			nextScene ();
			}
		}

		if (col.gameObject.tag == "NPC2") {
			btt.SetActive(false);
			NPC2 = false;
		}

		if (col.gameObject.tag == "NPC3") {
			btt.SetActive(false);
			NPC3 = false;
		}

		if (col.gameObject.tag == "NPC4") {
			btt.SetActive(false);
			NPC4 = false;
		}

		if (col.gameObject.tag == "Side1") {
			btt.SetActive(false);
			Side1 = false;
		}

		if (col.gameObject.tag == "Side2") {
			btt.SetActive(false);
			Side2 = false;
		}

		if (col.gameObject.tag == "Side3") {
			btt.SetActive(false);
			Side3 = false;
		}

		if(col.gameObject.tag == "NPCUncle"){
			btt.SetActive(false);
			NPCUncle = false;
		}
	}

	IEnumerator MyLoadLevelPortal1(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-13.40685f, -6.006579f, 0);
	}

	IEnumerator MyLoadLevelPortal2(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (xinsideHouse, yinsideHouse, 0);
	}

	IEnumerator MyLoadLevelPortal3(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-5, -4, 0);
	}

	IEnumerator MyLoadLevelPortal4(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-1.640286f, 2.250638f, 0);
	}

	IEnumerator MyLoadLevelPortal5(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-2.241981f, 4.246194f, 0);
	}

	IEnumerator MyLoadLevelPortal7(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-4, -1, 0);
	}

	IEnumerator MyLoadLevelPortal8(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (2.98547f, 7.213056f, 0);
	}

	IEnumerator MyLoadLevelPortal9(float delay)
	{
		yield return new WaitForSeconds(delay);
		transform.position = new Vector3 (-2.835311f, -0.3758202f, 0);
	}

	void SavePositionHouse(){
		PlayerPrefs.SetFloat ("xPositionInsideHouse", transform.position.x);
		PlayerPrefs.SetFloat ("yPositionInsideHouse", transform.position.y);
	}
	
	void GetPositionHouse(){
		xinsideHouse = PlayerPrefs.GetFloat ("xPositionInsideHouse");
		yinsideHouse = PlayerPrefs.GetFloat ("yPositionInsideHouse");
	}
	
	void saveItems(){
		
		
	}
	
	void getItems(){
		
		
	}
}
