using UnityEngine;
using System.Collections;

public class GameHistory : MonoBehaviour {

	public int freshLoad = 0;
	public int visitCount;
	public bool iWasHere;
	private touchButton CheckClass;

	void Awake(){


	}

	// Use this for initialization
	void Start () {


		visitCount=0;

	}
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevelName=="MainInterfaceVersionAug22"&&visitCount==0){
			CheckClass = GameObject.Find("buttons").GetComponent<touchButton>();
			CheckClass.Responder(true);
			return;
		}
		if(Application.loadedLevelName=="MainInterfaceVersionAug22"&&visitCount>=1){
			CheckClass = GameObject.Find("buttons").GetComponent<touchButton>();
			CheckClass.Responder(false);
			return;
			
		}
		if(Application.loadedLevelName=="Instruction Scene"&&visitCount==0){
			iWasHere=true;
			Count();
			return;
		}
		
	}
	void Count(){
		visitCount=visitCount+1;
		return;
	}
}
		
