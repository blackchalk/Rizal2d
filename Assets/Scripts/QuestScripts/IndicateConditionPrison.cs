using UnityEngine;
using System.Collections;

public class IndicateConditionPrison: MonoBehaviour {
	
	private NewAct2 act2Check;
	private QuestIndicatorPRISON act2b;
	
	private	void Update(){
		act2Check = GameObject.Find ("Player").GetComponent<NewAct2>();
		act2b = GameObject.Find("quest_indicator_newact2prison").GetComponent<QuestIndicatorPRISON>();

		if(act2Check.onQuest3==true){
			act2b.ShowIt(0);//mother
			act2b.ShowQuest();}
		if((act2Check.currentLine3==1)&&(act2Check.onQuest3==true)){
			act2b.ShowIt(2);
			act2b.ShowQuest();}
		if(act2Check.currentLine3==10){
			act2b.ShowIt(1);
			act2b.ShowQuest();}

	}
}
	