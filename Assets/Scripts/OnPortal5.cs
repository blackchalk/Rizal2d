using UnityEngine;
using System.Collections;

public class OnPortal5 : MonoBehaviour {

	public int Portal = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Portal = PlayerPrefs.GetInt ("Portal5");
		if (Portal == 0) {
			GameObject.FindWithTag ("Portal5").SetActive (false);
		} else if (Portal == 1) {
				GameObject.FindWithTag ("Portal5").SetActive (true);
		} else {
			Debug.Log("Bug!");
		}
	}
}
