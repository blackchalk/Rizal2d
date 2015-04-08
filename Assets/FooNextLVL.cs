using UnityEngine;
using System.Collections;

public class FooNextLVL : MonoBehaviour {

	public string levelToLoad = "";

	// Use this for initialization
	void Start () {

		if ((Application.levelCount >= 1) && (levelToLoad != ""))
		{
			Application.LoadLevel(levelToLoad);
			Destroy(this.gameObject);
		}
		else if ((Application.levelCount <= 1) || (levelToLoad == ""))
		{
			Debug.LogWarning("Invalid levelToLoad value.");
			
		}
		
	}

}
