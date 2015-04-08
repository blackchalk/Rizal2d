using UnityEngine;
using System.Collections;

public class KALANG : MonoBehaviour {
	//public GameObject leveltoload;


	public float fadeDuration = 2.0f;
	
	private float timeLeft = 0.0f;
	// Use this for initialization
	void Awake(){
		timeLeft = fadeDuration;

	}
	void Start(){

	}
	// Update is called once per frame
	private void Update()
	{
		if (timeLeft > 0)//timer
		{
			//Fade in
			//Debug.Log("Fading in " + timeLeft);
			Fade(true);
		}
		else if (timeLeft > (-fadeDuration))
		{
			//Fade out
			//Debug.Log("Fading out ");
			Fade(false);
		}
		else
		{
			
			
			Application.LoadLevel("Act 1 Scene 1 Remake"); //Loadlevel to the next scene is in here. in case you forgot.
			Destroy(this.gameObject);//r
		}
		timeLeft -= Time.deltaTime;

	}
	private void Fade(bool fadeIn)
	{
		if (fadeIn){
			//Debug.Log("fadein happens");
		}
		else{
			//Debug.Log("fadeout happens");
		}
}
}