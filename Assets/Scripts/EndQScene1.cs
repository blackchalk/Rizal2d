using UnityEngine;
using System.Collections;

public class EndQScene1 : MonoBehaviour {

	public AudioClip[] clip;
	
	public GUIStyle forFont; //edit font style settings
	public GUISkin forSkin; //edit skin settings

	public bool menu = true;
	public bool correctAnswer;
	public bool wrongAnswer;
	
	IEnumerator WaitABit(float delay)
	{
		yield return new WaitForSeconds(delay);

	}
	void WaitAndPrint() {
		if(correctAnswer == true){
			StartCoroutine(WaitABit(2f));
			Application.LoadLevel("Act1S2TitleRygn");}
		if(wrongAnswer == true) {
			
			StartCoroutine(WaitABit(2f));
			Application.LoadLevel("EndQScene1");}
	}
	
	void OnGUI(){
		GUI.skin = forSkin;
		if (menu) {

			GUI.Box(new Rect (Screen.width * 0.1f, Screen.height * 0.3f, (Screen.width) * 0.8f, (Screen.height) * 0.06f), 
			           "What is the moral lesson of\nthe Story of the Moth");
			GUI.backgroundColor = Color.black;
			if (GUI.Button(new Rect (Screen.width * 0.1f, Screen.height * 0.6f, (Screen.width) * 0.9f, (Screen.height) * 0.07f), "Always be obedient and listen to your parents.")) {
								//Debug.Log (" Touch on the upper button detected.");
								menu = false;
								correctAnswer = true;
				audio.PlayOneShot(clip[1]);
				//					WaitAndPrint();
			}
			GUI.backgroundColor = Color.black;
			if (GUI.Button (new Rect (Screen.width * 0.1f, Screen.height * 0.72f, (Screen.width) * 0.8f, (Screen.height) * 0.06f), "Take heed of the wisdom spoken by the wise and experienced.")) {

								//Debug.Log (" Touch on the lower button detected.");
									menu = false;
									wrongAnswer = true;
				audio.PlayOneShot(clip[0]);
//								 	WaitAndPrint();
			}
				}

				if (correctAnswer) {

			GUI.backgroundColor = Color.green;

						if (GUI.Button (new Rect (Screen.width * 0.1f, Screen.height * 0.6f, (Screen.width) * 0.8f, (Screen.height) * 0.06f),
			                "Correct Answer!")) {
				audio.PlayOneShot(clip[0]);//Debug.Log (" Touch on the upper button detected.");
								WaitAndPrint();}
				}

				if (wrongAnswer) {

			GUI.backgroundColor = Color.red;

						if (GUI.Button (new Rect (Screen.width * 0.1f, Screen.height * 0.72f, (Screen.width) * 0.8f, (Screen.height) * 0.06f), 
			                "Wrong Answer!")) {
								//Debug.Log (" Touch on the lower button detected.");
				audio.PlayOneShot(clip[0]);
								WaitAndPrint();}
								}
		
		}


}
