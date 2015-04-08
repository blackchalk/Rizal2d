using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]
public class TriggerTest : MonoBehaviour {
	// Use this for initialization
	public GUITexture bt;
	public string[] talkLines;
	public int currentLine = 0;

	private bool isTrigEnter;
	private bool isTrigShow = false;
	private bool isButtonPressed = false;

	//public string stringToEdit = "Hello World\nI've got 2 lines...";

	//TriggerTest test = new TriggerTest();
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) 
		{
			Touch t = Input.GetTouch(0);

			if (t.phase == TouchPhase.Began)
			{
				if(bt.HitTest(t.position, Camera.main)){
					isButtonPressed = true;
					currentLine++;

				}
			}
		
		}

		if (Input.GetMouseButtonDown (0)) 
		{
			if(bt.HitTest(Input.mousePosition, Camera.main))
			{
				isButtonPressed = true;
				currentLine++;
			}
		}

		if (isTrigShow) {

						GameObject.Find ("bt").guiTexture.enabled = true;
		
				} else {
						
			GameObject.Find ("bt").guiTexture.enabled = false;
				
				}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			//test.OnGUI();
			Debug.Log("Hit!");
			isTrigEnter = true;
			isTrigShow = true;

		}
		
		
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			Debug.Log ("Exit!");
			isTrigEnter = false;
			isTrigShow = false;
		}
	}

	void OnGUI() {
		//stringToEdit = GUI.TextArea(new Rect(10, 10, 200, 100), stringToEdit, 200);
		//GUI.Box(new Rect(0, 370, 752, 100), "This is a title");

		if (isTrigEnter) 
		{
			GUI.Label (new Rect (10, 50, 100, 20), "Hello World!");
			GameObject.Find("bt").guiTexture.enabled = false;
		}

		if (isButtonPressed) 
		{
				if(currentLine < talkLines.Length){
					GUI.Box(new Rect(0, 370, 752, 100), ""+talkLines[currentLine]+"");
				} else{
				GUI.Box(new Rect(0, 370, 752, 100), ""+talkLines[0]);
					currentLine = 0;
					isButtonPressed = false;
				}
		}

	}
}

