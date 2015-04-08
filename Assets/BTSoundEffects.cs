using UnityEngine;
using System.Collections;

public class BTSoundEffects : MonoBehaviour {
	public AudioClip clip;

	void OnMouseDown(){
		audio.PlayOneShot(clip);
	}
}
