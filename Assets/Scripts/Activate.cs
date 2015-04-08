using UnityEngine;
using System.Collections;

public class Activate : MonoBehaviour {
	public int Activates = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Activates = PlayerPrefs.GetInt ("Activate");
		if (Activates == 0) {
			gameObject.SetActive (false);
		} else if (Activates < 0) {
			gameObject.SetActive (true);
		}
	}
}
