using UnityEngine;
using System.Collections;

public class QuestIndicatorAct3s4b1: MonoBehaviour {//this is for act3scene 6 sole //onquest5

private NewAct3 act3part1;	
void Awake(){}
void Start(){
		gameObject.SendMessage("renderStart",false);
	}
	
	void Update () {
		act3part1 = GameObject.Find ("Player").GetComponent<NewAct3>();
	}
private	void LateUpdate(){ //raygon changed this access modifier to private
		
		if((act3part1.currentLine5==0)&&(act3part1.onQuest5==true)){
			gameObject.SendMessage("ShowIt",17);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine5==1)&&(act3part1.onQuest5==true)){
			gameObject.SendMessage("ShowIt",15);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine5==9)&&(act3part1.onQuest5==true)){
			gameObject.SendMessage("ShowIt",16);
			gameObject.SendMessage("QuestStatus");}

		

		
	}
	

}
