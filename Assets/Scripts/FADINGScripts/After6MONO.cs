using UnityEngine;
using System.Collections;

public class After6MONO : MonoBehaviour {
	//public float speed = 0.1F;
	// Use this for initialization
	void Start () {
	
	}

	void OnGUI(){
		GUI.Label(new Rect(Screen.width*0.15f, Screen.height*0.15f, (Screen.width)*0.75f, (Screen.height)*0.2f),
		          "Act 2 Pre-Med at UST: \nAfter 6 years, he shifted studies \nfrom Philosophy and Letters \nto Medical course in UST");
	}
	// Update is called once per frame
	void Update () {

			if (Input.touchCount > 0) {
			Application.LoadLevel("Act2Scene4");
			}
		}
	
	

//	void OnMouseDown() {
//		Application.LoadLevel("Act 1 Scene 2");
//	}
}
