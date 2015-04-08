using UnityEngine;
using System.Collections;

public class LampSFX : MonoBehaviour {

	//public AudioClip clip;
	private Act1Scene1Quest target;

	void Awake(){
		target = GameObject.Find ("Player").GetComponent<Act1Scene1Quest>();
		if(this.gameObject.activeSelf==false){
//			Debug.Log("Pakyu");
		} else if(this.gameObject.activeSelf==true){
//			Debug.Log("YEAH!");
			target.audio.PlayOneShot(target.clip[1]);
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
}
