using UnityEngine;
using System.Collections;

public class QuestUnlocked : MonoBehaviour {

	public float timer; //time elapsed since msg created
	public float displayTime;//how long the msg is displayed
	public bool timerIsActive;
	private string message;

	// Use this for initialization
	void Start () {
		guiText.text = "";
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timerIsActive)
		{
			timer+=Time.deltaTime;
			if (timer > displayTime)
			{ 
				timerIsActive=false;
				guiText.text="";
			}
			
		}
	}
	void startTimer()
	{
		timer = 0.0f;
		guiText.text = message;
		timerIsActive = true;
		displayTime = 1.7f; //active in sec
	}
	public void displayEnd(string mes)
	{//text with timer
		message = mes;

			startTimer();
	}

}
