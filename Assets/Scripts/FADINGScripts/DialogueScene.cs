using UnityEngine;
using System.Collections;

public class DialogueScene : MonoBehaviour {

	public float xlabel;
	public float ylabel;

	public GUIStyle forFont; //r
	public GUITexture Object3;
	public GUITexture Object2;
	public GUITexture Object1;

	public string[] talkLines1;
	public int currentLine1;
	
	private bool ButtonPresssed = false;
	
	// Use this for initialization
	void Start () {
		
		
		Object1.GetComponent<GUITexture>().enabled = true;
		Object2.GetComponent<GUITexture>().enabled = false;
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
					currentLine1++;
					}
			}
			
		}
		if(currentLine1==7){
			Object1.GetComponent<GUITexture>().enabled = false;
			Object2.GetComponent<GUITexture>().enabled = true;
			Object3.GetComponent<GUITexture>().enabled = false;
		}
		if(currentLine1==9){
			Object1.GetComponent<GUITexture>().enabled = false;
			Object2.GetComponent<GUITexture>().enabled = false;
			Object3.GetComponent<GUITexture>().enabled = true;
		}
	}

	void OnGUI(){
		GUI.skin.label=forFont; //style r
		
		if(ButtonPresssed){
			if(currentLine1 < talkLines1.Length)
			{
				GUI.Label(new Rect(Screen.width*xlabel, Screen.height*ylabel,(Screen.width)*0.65f,(Screen.height*0.3f)), ""+talkLines1[currentLine1]+"\n");
			} 
				else if(currentLine1 == 14)
			{
//				Object2.GetComponent<GUITexture>().enabled = true;
				Application.LoadLevel("THE END");
				Destroy(GameObject.FindWithTag("MainCamera"));

		}
		
		
	}

}
}
