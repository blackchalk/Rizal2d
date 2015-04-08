using UnityEngine;
using System.Collections;

public class IndicateConditionAct1Scene3 : MonoBehaviour {

	private Act1Scene2 act1Checkb;
	private QuestIndicatorLogicAct1Scene3 act1s2b;
	
	void Awake(){
		//		act1Checkb = GameObject.Find ("Player").GetComponent<Act1Scene2>();
		//		act1s2b = GetComponent<QuestIndicatorAct1S2>();
	}
	private	void Update(){
		act1Checkb = GameObject.Find ("Player").GetComponent<Act1Scene2>();
		act1s2b = GameObject.Find ("QUEST_INDICATOR").GetComponent<QuestIndicatorLogicAct1Scene3>();

		if(act1Checkb.onQuest3==true){
			act1s2b.ShowIt(2);
			act1s2b.ShowQuest();}
		if(act1Checkb.currentLineObject3>=2){
				act1s2b.ShowIt(1);
				act1s2b.ShowQuest();}
	}
}

