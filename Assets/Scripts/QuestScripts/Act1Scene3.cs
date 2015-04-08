using UnityEngine;
using System.Collections;

public class Act1Scene3 : MonoBehaviour {

	public float xLabel,yLabel;
	public string levelToLoad;

	public GUITexture Object2;
	public GUITexture Object1;
	public string[] talkLines10;
	public int currentLine10;

	private bool ButtonPresssed = false;

	// Use this for initialization
	void Start () {


		Object1.GetComponent<GUITexture>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) 
		{
			Touch t = Input.GetTouch(0);

			if (t.phase == TouchPhase.Began)
				{
				if(Object2.HitTest(t.position, Camera.main)){

					ButtonPresssed = true;
					currentLine10++;
					//print("hit");
				}
				}

		}
	}
	void OnGUI(){
		if(ButtonPresssed){
			if(currentLine10 < talkLines10.Length){
				GUI.Label(new Rect(Screen.width*xLabel, Screen.height*yLabel, (Screen.width*0.75f), (Screen.height*0.2f)),
				          ""+talkLines10[currentLine10]+"\n");
				//r
				if(currentLine10 == 3 && currentLine10< talkLines10.Length){
					Object2.GetComponent<GUITexture>().enabled = false;//r



					Object1.GetComponent<GUITexture>().enabled = true;
				}
			}else if (currentLine10 == 8){
				Application.LoadLevel(levelToLoad);
				Destroy(GameObject.FindWithTag("MainCamera"));

			}

		}


	}


}
