using UnityEngine;
using System.Collections;

public class KALANG2 : MonoBehaviour {
	public float fadeDuration = 2.0f;

	public string nextSceneToLoad = "";

	private Camera cam;
	
	private float timeLeft = 0.0f;
	// Use this for initialization
	void Awake()
		{

		timeLeft = fadeDuration;

		if((Application.levelCount<=1)||(nextSceneToLoad == "")){
//			////debug.LogWarning("Invalid scene to load value.");
		}
		}

	void Start () {
		cam = Camera.main;
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (timeLeft > 0)
			{
			//Fade in
			//////debug.Log("Fading in " + timeLeft);
			Fade(true);
			}
		if (timeLeft > (-fadeDuration))
			{
			//Fade out
			//////debug.Log("Fading out ");
			Fade(false);
			}
		if	((Application.levelCount >= 1) && (nextSceneToLoad!= ""))
		{
			Application.LoadLevel(nextSceneToLoad);
			Destroy(GameObject.FindWithTag("MainCamera"));
			Destroy(cam);
			Destroy(this);


		}
		else{
			Destroy(GameObject.FindWithTag("MainCamera"));
			Destroy(cam);
			Destroy(this);
		
		}
		timeLeft -= Time.deltaTime;
	}


	private void Fade(bool fadeIn)
	{
		if (fadeIn){
			//////debug.Log("fadein happens");
		}
		else{
			//////debug.Log("fadeout happens");
		}
}
}