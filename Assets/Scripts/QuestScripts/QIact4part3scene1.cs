using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]
public class QIact4part3scene1 : MonoBehaviour {


	private NewAct4FinalPart1 act4final;
	
	void Awake(){
		act4final= GameObject.Find ("Player").GetComponent<NewAct4FinalPart1>();
	}
	private	void LateUpdate(){ //r changed this access modifier to private
		
		if((act4final.currentLine1==0)&&(act4final.onQuest1)&&(!act4final.onQuest2)){
			//Debug.Log("onquest1");
			gameObject.SendMessage("ShowIt",0,SendMessageOptions.RequireReceiver);
			gameObject.SendMessage("QuestStatus");}
		if((act4final.currentLine1==1)&&(act4final.onQuest1)&&(!act4final.onQuest2)){
			//Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",2);
			gameObject.SendMessage("QuestStatus");
		}
		if((act4final.currentLine1==4)&&(act4final.onQuest1)&&(!act4final.onQuest2)){
			//Debug.Log("last");
			gameObject.SendMessage("ShowIt",1);
			gameObject.SendMessage("QuestStatus");
		}///////////
		if((act4final.currentLineObject1==0)&&(act4final.onQuest2)){
			//Debug.Log("onquest1");
			gameObject.SendMessage("SpecialCases",false);
			gameObject.SendMessage("ShowIt",5);
			gameObject.SendMessage("QuestStatus");}
		if((act4final.currentLineObject1==1)&&(act4final.onQuest2)){
			//Debug.Log("2nd");
			gameObject.SendMessage("SpecialCases",false);
			gameObject.SendMessage("ShowIt",3);
			gameObject.SendMessage("QuestStatus");
		}
		if((act4final.currentLineObject1==3)&&(act4final.onQuest2)){
			//Debug.Log("last");
			gameObject.SendMessage("SpecialCases",false);
			gameObject.SendMessage("ShowIt",4);
			gameObject.SendMessage("QuestStatus");
		}//
		if((act4final.currentLine2==0)&&(act4final.onQuest3)){
			//Debug.Log("onquest1");
			gameObject.SendMessage("SpecialCases",false);
			gameObject.SendMessage("ShowIt",8);
			gameObject.SendMessage("QuestStatus");}
		if((act4final.currentLine2==1)&&(act4final.onQuest3)){
			//Debug.Log("2nd");
			gameObject.SendMessage("SpecialCases",false);
			gameObject.SendMessage("ShowIt",6);
			gameObject.SendMessage("QuestStatus");
		}
		if((act4final.currentLine2==3)&&(act4final.onQuest3)){
			//Debug.Log("last");
			gameObject.SendMessage("SpecialCases",false);
			gameObject.SendMessage("ShowIt",8);
			gameObject.SendMessage("QuestStatus");
		}//
		if((act4final.currentLine3==1)&&(act4final.onQuest4)){
			//Debug.Log("2nd");
			gameObject.SendMessage("SpecialCases",false);
			gameObject.SendMessage("ShowIt",8);
			gameObject.SendMessage("QuestStatus");
		}
		if((act4final.currentLine3==3)&&(act4final.onQuest4)){
			//Debug.Log("last");
			gameObject.SendMessage("SpecialCases",false);
			gameObject.SendMessage("ShowIt",6);
			gameObject.SendMessage("QuestStatus");
		}//
	}
}
