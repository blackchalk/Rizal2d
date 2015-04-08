using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {
	public string levelToLoad;
	public GameObject animation;
	public GameObject background;
	public GameObject text;
	// Use this for initialization
	void Start () {
		animation.SetActive(false);
		background.SetActive(false);
		text.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
			StartCoroutine(DisplaySplash(levelToLoad));
			print("space key was pressed");
		
	}

	IEnumerator DisplaySplash(string level){
		text.guiText.text = "Loading..";
		Application.LoadLevel(level);
		yield return new WaitForSeconds(3);

		Destroy(GameObject.Find("LoadingScreen"),2f);
	}
}

