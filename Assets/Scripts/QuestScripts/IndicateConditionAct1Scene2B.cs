using UnityEngine;
using System.Collections;

public class IndicateConditionAct1Scene2B : MonoBehaviour {

	private Act1Scene2 act1Checkb;
	private QuestIndicatorLogicAct1Scene2B act1s2b;
	
	void Awake(){
//		act1Checkb = GameObject.Find ("Player").GetComponent<Act1Scene2>();
//		act1s2b = GetComponent<QuestIndicatorAct1S2>();
	}
private	void Update(){
				act1Checkb = GameObject.Find ("Player").GetComponent<Act1Scene2>();
		act1s2b = GetComponent<QuestIndicatorLogicAct1Scene2B>();

				if((act1Checkb.onQuest2a==true)&&(act1Checkb.currentLineObject2==0)){
					act1s2b.ShowIt (2);
					act1s2b.ShowQuest();//c
					}

				if((act1Checkb.currentLineObject2==1)&&(act1Checkb.onQuest2a==true)){
							act1s2b.ShowIt(0);
							act1s2b.ShowQuest();}//mother
				if((act1Checkb.currentLineObject2==6)&&(act1Checkb.onQuest2a==true)){
							act1s2b.ShowIt(1);
							act1s2b.ShowQuest();}//mother
}
}
