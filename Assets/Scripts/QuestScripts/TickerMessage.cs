using UnityEngine;
using System.Collections;

public class TickerMessage : MonoBehaviour {
	public GUIStyle TickerStyle; //handles guistyles

	private float timer; //time elapsed since msg created
	private float displayTime;//how long the msg is displayed
	private bool timerIsActive;//whether the time that controls the msg is active
	private string message; //msg will be displayed on screen
												/// <summary>
												///EVERYTIME YOU WILL DESTROY THIS OBJECT YOU WILL NEED A BLANK SCENE OR ELSE ERROR
												/// </summary>


	void Start () {

		guiText.text = "";
	
	}

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
		displayTime = 6.0f; //active in 6sec
	}
	void questStarted()
	{

		guiText.text = message;

	}

	public void displayStart(string mes)
	{//startQuest ; a text that do not have a timer
		message = mes;
		questStarted();

	}
	public void displayEnd(string mes){//text with timer
		message = mes;
		startTimer();
	}
		
		
}
