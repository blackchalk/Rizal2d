using UnityEngine;
using System.Collections;

public class KALANG3 : MonoBehaviour {
	public float fadeDuration = 2.0f;
	
	private float timeLeft = 0.0f;
	// Use this for initialization
	void Awake(){
		timeLeft = fadeDuration;
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	private void Update()
	{
		if (timeLeft > 0)
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
			
			
			Application.LoadLevel("New Act 3 Scene 1"); //Loadlevel to the next scene is in here. in case you forgot.
			Destroy(gameObject);//r
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