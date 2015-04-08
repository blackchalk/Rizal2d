using UnityEngine;
using System.Collections;

public class OnNPC : MonoBehaviour {
	
	public int NPC = 0;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		NPC = PlayerPrefs.GetInt ("NPC");
		if (NPC == 0) {
			GameObject.Find ("New-NPCS_4").SetActive (false);
			GameObject.Find ("New-NPCS_0").SetActive (false);
		} else if (NPC == 1) {
			GameObject.Find ("New-NPCS_4").SetActive (true);
			GameObject.Find ("New-NPCS_0").SetActive (true);
		} else {
			Debug.Log("Bug!");
		}
	}
}
