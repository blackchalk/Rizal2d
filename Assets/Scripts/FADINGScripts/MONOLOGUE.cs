using UnityEngine;
using System.Collections;

public class MONOLOGUE : MonoBehaviour {

	void OnGUI(){
//		GUI.Label(new Rect(Screen.width*0.15f, Screen.height*0.15f, (Screen.width)*0.75f, (Screen.height)*0.2f),
//		          "My class is starting soon,\n i should get ready for school. \nOh where did i put my slippers..?");
	}
	// Update is called once per frame
	void Update () {

			if (Input.touchCount > 0) {
			Application.LoadLevel("FOOFOOFOO5");
			}
		}
//	void OnMouseDown() {
//		Application.LoadLevel("Act 1 Scene 2");
//	}
}
