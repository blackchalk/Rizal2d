using UnityEngine;
using System.Collections;

public class PortalACti : MonoBehaviour {

	public int Portal = 0;
	
	// Update is called once per frame
	void Update () {
		Portal = PlayerPrefs.GetInt ("PortalNew");
		if (Portal == 0) {
			GameObject.FindWithTag ("Portal3").SetActive (false);
		} else if (Portal == 1) {
			GameObject.FindWithTag ("Portal3").SetActive (true);
		} else {
			Debug.Log("Bug!");
		}
	}
}
