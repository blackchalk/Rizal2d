using UnityEngine;
using System.Collections;

public class QuestIndicatorAct3s1 : MonoBehaviour {//this is for act3scene 1 sole
	
private NewAct3 act3part1;	
void Awake(){}
	void Start(){
		gameObject.SendMessage("renderStart",false);
	}

void Update () {
		act3part1 = GameObject.Find ("Player").GetComponent<NewAct3>();
	}
private	void LateUpdate(){ //raygon changed the access modifier to private
		
		if((act3part1.currentLine2==0)&&(act3part1.onQuest2==true)){
			gameObject.SendMessage("ShowIt",2);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine2==1)&&(act3part1.onQuest2==true)){
			gameObject.SendMessage("ShowIt",0,SendMessageOptions.RequireReceiver);
			gameObject.SendMessage("QuestStatus");}
		if((act3part1.currentLine2==5)&&(act3part1.onQuest2==true)){
			gameObject.SendMessage("ShowIt",1);
			gameObject.SendMessage("QuestStatus");}

	}
	

}


