using UnityEngine;
using System.Collections;

public class SpriteChange1 : MonoBehaviour {
	public SpriteRenderer target;
	public SpriteRenderer newSprite;
//	public AudioClip[] clip;
//	private bool playMe;

	
	private Act1Scene1Quest act1Check;

	void Awake(){
		target = GameObject.Find ("Chest 1").GetComponent<SpriteRenderer>();
		newSprite =  GameObject.Find ("Chest 2").GetComponent<SpriteRenderer>();
		act1Check = GameObject.Find ("Player").GetComponent<Act1Scene1Quest>();

	}

	// Use this for initialization
	void Start () {

		newSprite.enabled=false;


	}
	
	// Update is called once per frame
	void Update () {



				if(act1Check.currentLineObject==3&&act1Check.MatchSet==0){//chest opens Act1scene1Remake
				target.enabled=false;
				newSprite.enabled=true;
//				audio.PlayOneShot(clip[0]);
		}
		
	}
//	IEnumerator PlaySound(){
//		if(playMe){
//			yield return new WaitForSeconds(0.2f);
//			audio.PlayOneShot(clip[0]);
//		}
//		if(playMe==false){
//			audio.Stop();
//		}
//	}
}
