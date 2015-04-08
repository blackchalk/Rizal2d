using UnityEngine;
using System.Collections;

public class QuestIndicatorAct3s4 : MonoBehaviour {//this is for act3scene 4 sole //onquest1 and 6

	private NewAct3 act3part1;	
	void Start(){
		gameObject.SendMessage("renderStart",false);
	}
	
	void Update () {
		act3part1 = GameObject.Find ("Player").GetComponent<NewAct3>();
	}
private	void LateUpdate(){ //raygon changed this access modifier to private
		
		if((act3part1.currentLine1==0)&&(act3part1.onQuest1==true)){
			gameObject.SendMessage("ShowIt",5);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine1==1)&&(act3part1.onQuest1==true)){
			gameObject.SendMessage("ShowIt",3);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine1==5)&&(act3part1.onQuest1==true)){
			gameObject.SendMessage("ShowIt",4);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine6==0)&&(act3part1.onQuest6==true)){
			gameObject.SendMessage("ShowIt",5);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine6==1)&&(act3part1.onQuest6==true)){
			gameObject.SendMessage("ShowIt",3);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine6==8)&&(act3part1.onQuest6==true)){
			gameObject.SendMessage("ShowIt",4);
			gameObject.SendMessage("QuestStatus");}
		//guard
		if((act3part1.currentLine4==0)&&(act3part1.onQuest4==true)){
			gameObject.SendMessage("ShowIt",8);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine4==1)&&(act3part1.onQuest4==true)){
			gameObject.SendMessage("ShowIt",6);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine4==9)&&(act3part1.onQuest4==true)){
			gameObject.SendMessage("ShowIt",7);
			gameObject.SendMessage("QuestStatus");}
		

		
	}
	

}


