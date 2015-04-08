using UnityEngine;
using System.Collections;

public class QuestIndicatorAct3s3: MonoBehaviour {//this is for new act 3 scene 3 sole
private NewAct3 act3part1;	
void Awake(){}
void Start(){
	gameObject.SendMessage("renderStart",false);
}
void Update () {
	act3part1 = GameObject.Find ("Player").GetComponent<NewAct3>();
	}

private	void LateUpdate(){ //raygon changed this access modifier to private
		
		if((act3part1.currentLine3==0)&&(act3part1.onQuest3==true)){
			gameObject.SendMessage("ShowIt",11);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine3==1)&&(act3part1.onQuest3==true)){
			gameObject.SendMessage("ShowIt",9);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine3==8)&&(act3part1.onQuest3==true)){
			gameObject.SendMessage("ShowIt",10);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine6==0)&&(act3part1.onQuest6==true)){//onquest6
			gameObject.SendMessage("ShowIt",14);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine6==1)&&(act3part1.onQuest6==true)){//onquest6
			gameObject.SendMessage("ShowIt",12);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine6==6)&&(act3part1.onQuest6==true)){//onquest6
			gameObject.SendMessage("ShowIt",13);
			gameObject.SendMessage("QuestStatus");}
		//memo
		if((act3part1.currentLine7==0)&&(act3part1.onQuest7==true)){
			gameObject.SendMessage("ShowIt",14);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine7==1)&&(act3part1.onQuest7==true)){
			gameObject.SendMessage("ShowIt",12);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine7==10)&&(act3part1.onQuest7==true)){
			gameObject.SendMessage("ShowIt",13);
			gameObject.SendMessage("QuestStatus");}
		
		

		
	}
	

}
