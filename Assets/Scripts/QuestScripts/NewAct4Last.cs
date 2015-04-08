using UnityEngine;
using System.Collections;

public class NewAct4Last : MonoBehaviour {

	public GUIStyle forFont;
	public GUITexture Invi;

	public string[] talkLinesDialogue;
	public int currentLineDia1 = 0;

	public int currentLine = 0;

	private Storage storage;

	public bool isButtonPressedNPC = false;

	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		storage = GameObject.Find ("Storage").GetComponent<Storage> ();
	}
	
	// Update is called once per frame
	void Update () {
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
			
			if (Invi.HitTest (Input.mousePosition, Camera.main)) {
				isButtonPressedNPC = true;
				currentLineDia1++;
				currentLine++;
			}
		}
	
	}

	void OnGUI(){
		if(isButtonPressedNPC){
			if (currentLineDia1 < talkLinesDialogue.Length) {
				GUI.Label (new Rect (Screen.width * 0.01f, Screen.height * 0.65f, (Screen.width) * 0.6f, (Screen.height * 0.3f)), "" + talkLinesDialogue [currentLineDia1] + "\n");
			} 

			if (currentLineDia1 == 10){ //set to right amount of text in array
				//Debug.Log("Shet!");
				storage.lastAnim = 1;
			}

			if (currentLineDia1 == 11){ 
				//Debug.Log("How");
				storage.lastAnim = 2;
				StartCoroutine(myTransition1(1f));
			}

			//ADD EXTRA STATEMENTS DEPENDING HOW LONG THE SCRIPT WILL BE.
		}
	}

	IEnumerator myTransition1(float delay)
	{
		yield return new WaitForSeconds(delay);
		storage.screenFadeNow = 1;

	}

}
