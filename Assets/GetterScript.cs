using UnityEngine;
using System.Collections;

public class GetterScript : MonoBehaviour {

	public GUITexture a;
	public GUITexture b;
	public GUITexture c;
	public GUITexture d;

	public int gui1;
	public int gui2;
	public int gui3;
	public int gui4;

	public int a1;
	public int a2;
	public int a3;
	public int a4;

	public GameObject aa;//1st
	public GameObject bb;//2nd
	public GameObject cc;//3rd
	public GameObject dd;//4th

	public bool stop1;
	public bool stop2;
	public bool stop3;
	public bool stop4;


	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		//aa.SetActive (false);
		//bb.SetActive (false);
		//.SetActive (false);
		//dd.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		releaseHideGUIs ();

		gui1 = PlayerPrefs.GetInt ("Set1");
		gui2 = PlayerPrefs.GetInt ("Set2");
		gui3 = PlayerPrefs.GetInt ("Set3");
		gui4 = PlayerPrefs.GetInt ("Set4");

		if (Input.GetMouseButtonDown (0)) {
			if(stop1){
				if (a.HitTest (Input.mousePosition, Camera.main)) {
					a1 = 1;
					Debug.Log ("Yeah1");
				}
			}

			if(stop2){
				if (b.HitTest (Input.mousePosition, Camera.main)) {
					a2 = 1;
					Debug.Log ("Yeah2");
				}
			}

			if(stop3){
				if (c.HitTest (Input.mousePosition, Camera.main)) {
					a3 = 1;
					Debug.Log ("Yeah3");
				}
			}

			if(stop4){
				if (d.HitTest (Input.mousePosition, Camera.main)) {
					a4 = 1;
					Debug.Log ("Yeah4");
				}
			}
		}
	}

	void releaseHideGUIs(){
		if(gui1 == 1){
			aa.SetActive (true);
			stop1 = true;
		} 

		if(gui1 != 1){
			aa.SetActive (false);
			stop1 = false;
		}

		if(gui2 == 1){
			bb.SetActive (true);
			stop2 = true;
		}

		if(gui2 != 1){
			bb.SetActive (false);
			stop2 = false;
		}

		if(gui3 == 1){
			cc.SetActive (true);
			stop3 = true;
		}

		if(gui3 != 1){
			cc.SetActive (false);
			stop3 = false;
		}

		if(gui4 == 1){
			dd.SetActive (true);
			stop4 = true;
		}

		if(gui4 != 1){
			dd.SetActive (false);
			stop4 = false;
		}
	}

	void OnGUI(){
		
		GUI.Label (new Rect (0, 0, 700, 20), "Set1: "+gui1+" Set2: "+gui2);
		GUI.Label (new Rect (0, 15, 700, 20), "Set3: "+gui3+" Set4: "+gui4);

		GUI.Label (new Rect (0, 30, 700, 20), "a1: "+a1+" a2: "+a2);
		GUI.Label (new Rect (0, 45, 700, 20), "a3: "+a3+" a4: "+a4);
		
	}
}
