using UnityEngine;
using System.Collections;

public class Act2Quests : MonoBehaviour {

	public GUIStyle forFont;

	public GameObject Antibiotics;
	public GameObject Aspirins;
	public GameObject Vitamins;

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

	public int check = 0;

	private bool isHide = false;
	private bool isButtonShow = false;
	private bool isButtonPressedNPC = false;

	private bool onQuest1 = false;
	private bool onCompleteMedicine = false;
	private bool onQuestFinished = false;

	private float xinsideHouse;
	private float yinsideHouse;

	private bool NPC1 = false;
	private bool NPC2 = false;
	private bool NPC3 = false;
	private bool NPC4 = false;

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

	void Awake(){
		MakeAllFalse();

	}

	void Start () {
		//MakeAllFalse();
	}

	void Update () {

		CompleteQuest ();
		HideTextures ();
		ButtonShow ();

		if (Input.GetMouseButtonDown (0)) {
			if (bt.HitTest (Input.mousePosition, Camera.main)) {

				if(NPC1){
					isButtonPressedNPC = true;
					isHide = true;
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
					if(onQuest1 == false){
						check++;
					}else{
						currentLine2++;
					}
				}

				if(NPC3){
					isButtonPressedNPC = true;
					isHide = true;
					if(onQuest1 == false){
						check++;
					}else{
						currentLine3++;
					}
				}

				if(NPC4){
					isButtonPressedNPC = true;
					isHide = true;
					if(onQuest1 == false){
						check++;
					}else{
						currentLine4++;
					}
				}
			}

			if (Aspirinss.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Aspirin");
				Aspirin = true;
				MedicineStatementAspi();
				MakeAllFalse();

			}

			if (Vitaminss.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Vitamins");
				Vitamin = true;
				MedicineStatementVit();
				MakeAllFalse();
			}

			if (Antibioticss.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Antibiotic");
				Antibiotic = true;
				MedicineStatementAnti();
				MakeAllFalse();
			}
		}
	
	}

	void OnGUI(){

		GUI.skin.label = forFont;//homer

		if (isButtonPressedNPC) {
			if(NPC1){
				if(onQuest1 == false){
					if(currentLine1 < talkLinesNPC1.Length){
						GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC1[currentLine1]);
					}else if(currentLine1 == 9){
						isButtonPressedNPC = false;
						onQuest1 = true;
						Patient1 = true;
						Patient2 = true;
						Patient3 = true;
						isHide = false;
						isButtonShow = false;

					}
				}

				if(onQuest1 == true){
					if(onCompleteMedicine == false){
						if(check == 1){
							GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), "You're still here? You better get going.");
						}else{
							check = 0;
							isButtonPressedNPC = false;
							isButtonShow = false;
							isHide = false;
						}
					}

					if(onCompleteMedicine == true){
						if(asp == 1 && vit == 1 && anti == 1){
							if(currentLine1b < talkLinesNPC1b.Length){
								GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC1b[currentLine1b]);
							}else{
								isButtonPressedNPC = false;
								isButtonShow = false;
								isHide = false;
								onQuest1 = false;
								onQuestFinished = true;
								Debug.Log("Finish!");
							}
						}else{
							if(check==1){
								GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), "Mr. Rizal you failed. Can you try again?");
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
							}
						}
					}
				}
			}

			if(NPC2){
				if(onQuest1 == true){
					if(Patient1){
						if(currentLine2 < talkLinesNPC2.Length){
							GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC2[currentLine2]);
						}else if(currentLine2 == 2){
							isButtonPressedNPC = false;
							isHide = false;
							isButtonShow = false;
							MedicineCheck();
							Patient1 = false;
							P1 = false;
						}
					}
				}else{
					if(check == 1){
						GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), "...");
					}else{
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
							GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC3[currentLine3]);
						}else if(currentLine3 == 2){
							isButtonPressedNPC = false;
							isHide = false;
							isButtonShow = false;
							MedicineCheck();
							Patient2 = false;
							P2 = false;
						}
					}
				}else{
					if(check == 1){
						GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), "...");
					}else{
						check = 0;
						isButtonPressedNPC = false;
						isButtonShow = false;
						isHide = false;
					}
				}
			}

			if(NPC4){
				if(onQuest1 == true){
					if(Patient3){
						if(currentLine4 < talkLinesNPC4.Length){
							GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), ""+talkLinesNPC4[currentLine4]);
						}else if(currentLine4 == 2){
							isButtonPressedNPC = false;
							isHide = false;
							isButtonShow = false;
							MedicineCheck();
							Patient3 = false;
							P3 = false;
						}
					}
				}else{
					if(check == 1){
						GUI.Label(new Rect(Screen.width*0.01f, Screen.height*0.6f,(Screen.width)*0.6f,(Screen.height*0.3f)), "...");
					}else{
						check = 0;
						isButtonPressedNPC = false;
						isButtonShow = false;
						isHide = false;
					}
				}
			}
			
		}
		
	}

	void HideTextures(){
		
		if (isHide) {
			GameObject.Find ("left").guiTexture.enabled = false;
			GameObject.Find ("right").guiTexture.enabled = false;
			GameObject.Find ("down").guiTexture.enabled = false;
			GameObject.Find ("up").guiTexture.enabled = false;
		} else {
			GameObject.Find ("left").guiTexture.enabled = true;
			GameObject.Find ("right").guiTexture.enabled = true;
			GameObject.Find ("down").guiTexture.enabled = true;
			GameObject.Find ("up").guiTexture.enabled = true;
		}
	}
	
	void ButtonShow(){
		if (isButtonShow) {
			GameObject.Find ("bt").guiTexture.enabled = true;
		} else {
			GameObject.Find ("bt").guiTexture.enabled = false;	
		}
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Portal1") {
			
			SavePositionHouse();
			Application.LoadLevel("Act2Scene1");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal1(0.0f));
			DontDestroyOnLoad (this);
		}

		if (col.gameObject.tag == "Portal2") {
			
			GetPositionHouse();
			xinsideHouse--;
			Application.LoadLevel("Act2Scene4 - Copy");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal2(0.0f));
			
		}

		if (col.gameObject.tag == "Portal3") {
			

			Application.LoadLevel("Act2Scene3");
			renderer.sortingOrder = 19;
			StartCoroutine(MyLoadLevelPortal3(0.0f));
			
		}

		if (col.gameObject.tag == "Portal4") {
			
			
			Application.LoadLevel("Act2Scene1");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal4(0.0f));
			
		}

		if (col.gameObject.tag == "Portal5") {
			
			
			Application.LoadLevel("Act2Scene2");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal5(0.0f));
			
		}

		if (col.gameObject.tag == "Portal6") {

			Application.LoadLevel("Act2Scene1");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (6.263939f, -7.828032f, 0);
			
		}

		if (col.gameObject.tag == "Portal7") {
			
			Application.LoadLevel("Act2Scene5 - Copy");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal7(0.0f));
			
		}

		if (col.gameObject.tag == "Portal8") {
			
			Application.LoadLevel("Act2Scene2");
			renderer.sortingOrder = 29;
			StartCoroutine(MyLoadLevelPortal8(0.0f));
			
		}

		if (col.gameObject.tag == "Portal9") {
			
			Application.LoadLevel("Act2Scene5");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (-2.835311f, -0.3758202f, 0);
			
		}

		if (col.gameObject.tag == "Portal10") {
			
			Application.LoadLevel("Act2Scene2");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (0f, 2f, 0);
			
		}

		if (col.gameObject.tag == "Portal11") {
			
			Application.LoadLevel("Act2Scene5 - Copy - Copy");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (1f, -2f, 0);
			
		}

		if (col.gameObject.tag == "Portal12") {
			
			Application.LoadLevel("Act2Scene2");
			renderer.sortingOrder = 29;
			transform.position = new Vector3 (-6f, 1f, 0);
			
		}

		if (col.gameObject.tag == "NPC1") {
			isButtonShow = true;
			NPC1 = true;
		}

		if (col.gameObject.tag == "NPC2") {
			isButtonShow = true;
			NPC2 = true;
		}

		if (col.gameObject.tag == "NPC3") {
			isButtonShow = true;
			NPC3 = true;
		}

		if (col.gameObject.tag == "NPC4") {
			isButtonShow = true;
			NPC4 = true;
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "NPC1") {
			isButtonShow = false;
			NPC1 = false;
		}

		if (col.gameObject.tag == "NPC2") {
			isButtonShow = false;
			NPC2 = false;
		}

		if (col.gameObject.tag == "NPC3") {
			isButtonShow = false;
			NPC3 = false;
		}

		if (col.gameObject.tag == "NPC4") {
			isButtonShow = false;
			NPC4 = false;
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
		transform.position = new Vector3 (-4, -2, 0);
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
