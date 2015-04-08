using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void OnGUI(){
		if (GUI.Button(new Rect(10,10,40,40),"EXIT"))
		    {
			Application.Quit();
//			Debug.Log("tangina mo gumana ka!");

		}
		
		
	}
		}
