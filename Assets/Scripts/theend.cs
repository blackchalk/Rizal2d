using UnityEngine;
using System.Collections;

public class theend: MonoBehaviour {

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
					print("THIS SCENE IS SUPPOSSEDLY\nAFTERMATH SCENE NOT END SCENE,\nEND SCENE COMES AFTER.");}
			}
			
		}
	}
	
	
	
	void OnGUI(){
		GUI.skin.label=forFont; //style r
		
		if(ButtonPresssed){
			if(currentLine40 < talkLines40.Length){
				GUI.contentColor=Color.green;
				GUI.Label(new Rect(Screen.width*0.115f, Screen.height*0.615f, (Screen.width*0.75f), (Screen.height*0.2f)),
				          ""+talkLines40[currentLine40]+"\n");
				//r
				if(currentLine40 == 2 && currentLine40< talkLines40.Length){

					//Object1.GetComponent<GUITexture>().enabled = true;
				}
			}else if (currentLine40 == 2){
				//Debug.Log ("FINALE. NEXT IS CREDITS?");
				Destroy(GameObject.FindWithTag("MainCamera"));
				
			}
			
		}
		
		
	}

}
