using UnityEngine;
using System.Collections;

public class  PressLoadLvl : MonoBehaviour {


	public string levelToLoad = "";
	public bool ButtonPresssed = false;
	private int curTouch = 0;

	// Use this for initialization
	void Start () {
		curTouch = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount >0) {

		{
			Touch t = Input.GetTouch(0);

			if (t.phase == TouchPhase.Began)
				{
					curTouch=curTouch+1;
					//Debug.Log("hit"+curTouch);
				}
			}

		}

		if(curTouch==2){
			ButtonPresssed=true;
		}

		if(ButtonPresssed){
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
}
