using UnityEngine;
using System.Collections;

public class NewAct4P3Scene2Hints : MonoBehaviour {

	
	private float timer; //time elapsed since msg created
	private float displayTime;//how long the msg is displayed
	private bool timerIsActive;//whether the time that controls the msg is active
	private string message; //msg will be displayed on screen
	public int numOfPicks = 0;
	public int picksLeft = 5;
	public int numberOfCorrect = 0;

	private NewAct4FinalPart2 act4finalpart2;

	/// <summary>
	///EVERYTIME YOU WILL DESTROY THIS OBJECT YOU WILL NEED A BLANK SCENE OR ELSE ERROR
	/// </summary>
	void Awake(){

		act4finalpart2 = GameObject.Find("Main Camera").GetComponent<NewAct4FinalPart2>();
	}
	void Start () {

		guiText.text = "What do you think are\nthe topics that empowered\nRizal's Mi Ultimo Adios?\nPick "+picksLeft+" from the list";
		
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
//	IEnumerator void BeginGame(){
//		guiText.text = "What do you think are\nthe topics that empowered\nRizal's Mi Ultimo Adios?\nPick "+picksLeft+" from the list";
//		numberOfCorrect++;
//		picksLeft--;
//
//	}
	

}
