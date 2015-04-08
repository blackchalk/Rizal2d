using UnityEngine;
using System.Collections;

public class Act4finalpart : MonoBehaviour {

	public GUIStyle forFont; //r
	//public GUITexture Object2;
	public GUITexture Object1;

	public string[] talkLines40;
	public int currentLine40;
	
	private bool ButtonPresssed = false;
	
	// Use this for initialization
	void Start () {
		
		
		Object1.GetComponent<GUITexture>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.touchCount > 0) 
		{
			Touch t = Input.GetTouch(0);
			
			if (t.phase == TouchPhase.Began)
			{
				if(Object1.HitTest(t.position, Camera.main)){
					
					ButtonPresssed = true;
					currentLine40++;
					}
			}
			
		}
	}
	
	
	
	void OnGUI(){
		GUI.skin.label=forFont; //style r
		
		if(ButtonPresssed){
			if(currentLine40 < talkLines40.Length){
				//contentColor
				GUI.Label(new Rect(Screen.width*0.35f, Screen.height*0.15f, (Screen.width*0.6f), (Screen.height*0.2f)),
				          ""+talkLines40[currentLine40]+"\n");
				//r
				if(currentLine40 == 27 && currentLine40< talkLines40.Length){

					//Object1.GetComponent<GUITexture>().enabled = true;
				}
			}else if (currentLine40 == 27){
				Application.LoadLevel("AFTERMATHbeforeEnd");
				Destroy(GameObject.FindWithTag("MainCamera"));
				
			}
			
		}
		
		
	}

}
