using UnityEngine;
using System.Collections;

public class SetterScript : MonoBehaviour {

	private GetterScript get;

	public GUIText set1;
	public GUIText set2;
	public GUIText set3;
	public GUIText set4;

	public GUIText Quit;

	public GUITexture deleter;

	void Awake(){
		get = GameObject.Find ("Getter").GetComponent<GetterScript> ();
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (set1.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Set 1!");
				PlayerPrefs.SetInt("Set1", 1);
			}
			
			if (set2.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Set 2!");
				PlayerPrefs.SetInt("Set2", 1);
			}

			if (set3.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Set 3!");
				PlayerPrefs.SetInt("Set3", 1);
			}

			if (set4.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Set 4!");
				PlayerPrefs.SetInt("Set4", 1);
			}

			if (deleter.HitTest (Input.mousePosition, Camera.main)) {
				Debug.Log("Delete!");
				PlayerPrefs.DeleteAll();

				get.a1 = 0;
				get.a2 = 0;
				get.a3 = 0;
				get.a4 = 0;

			}

			if (Quit.HitTest (Input.mousePosition, Camera.main)) {
				Application.Quit();
				Debug.Log("Quitszzz");
			}
		}

	}
}
