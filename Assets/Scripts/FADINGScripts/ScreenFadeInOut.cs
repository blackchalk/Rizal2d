using UnityEngine;
using System.Collections;

public class ScreenFadeInOut : MonoBehaviour
{
	public float fadeSpeed = 1.5f;          // Speed that the screen fades to and from black.
	
	
	public bool sceneChanging = false;      // Whether or not the scene is still fading in.

	private Storage storage;
	
	void Awake ()
	{
		// Set the texture so that it is the the size of the screen and covers it.
		guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
		storage = GameObject.Find ("Storage").GetComponent<Storage> ();
	}
	

	void checkScene(){
		if (storage.screenFadeNow == 1) {
			sceneChanging = true;	
		}
	}

	void Update ()
	{
		checkScene ();
		if(sceneChanging){
			FadeToWhite();
			StartCoroutine(MyNextLevel(3.5f));//r
			PlayerPrefs.SetInt("Set4", 1);

		}

		if(sceneChanging == false){
			FadeToClear();
		}

	}
	
	
	void FadeToClear ()
	{
		// Lerp the colour of the texture between itself and transparent.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
	}
	
	
	void FadeToWhite ()
	{
		// Lerp the colour of the texture between itself and black.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.white, fadeSpeed * Time.deltaTime);

		if(guiTexture.color.a <= 0.01f)
		{
			// ... set the colour to clear and disable the GUITexture.
			guiTexture.color = Color.white;

				//guiTexture.enabled = false;
			
			// The scene is no longer starting.
			//sceneChanging = false;
		}
	}
	
	
	void StartScene ()
	{
		// Fade the texture to clear.
		FadeToClear();
		
		// If the texture is almost clear...
		if(guiTexture.color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			guiTexture.color = Color.clear;
			guiTexture.enabled = false;
			
			// The scene is no longer starting.
			//sceneChanging = false;
		}
	}
	
	
	public void EndScene ()
	{
		// Make sure the texture is enabled.
		guiTexture.enabled = true;
		
		// Start fading towards black.
		FadeToWhite();
		
		 //If the screen is almost black...
//		if(guiTexture.color.a >= 0.95f){
//			// ... reload the level.
//			Application.LoadLevel("Act4 FINAL PART");
	}
	//r
	IEnumerator MyNextLevel(float delay)
	{
		yield return new WaitForSeconds(delay);
		Application.LoadLevel("PrologueAct4FinalPart");
		
	}
}
