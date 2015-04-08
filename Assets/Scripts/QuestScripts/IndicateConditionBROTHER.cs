using UnityEngine;
using System.Collections;

public class IndicateConditionBROTHER: MonoBehaviour {
	
	private NewAct2 act2Check;
	private QuestIndicatorBROTHER act2b;
	
	private	void Update(){
		act2Check = GameObject.Find ("Player").GetComponent<NewAct2>();
		act2b = GameObject.Find("QuestIndicatorBROTHER").GetComponent<QuestIndicatorBROTHER>();

		if((act2Check.NPC5==false)&&(act2Check.onQuest8==true)){
			act2b.ShowIt(0);
			act2b.ShowQuest();//
		}
		if((act2Check.NPC5==true)&&(act2Check.currentLine5==1)){
			act2b.ShowIt(2);
			act2b.ShowQuest();//
		if((act2Check.NPC5==true)&&(act2Check.currentLine5==11)){
			act2b.ShowIt(1);
			act2b.ShowQuest();//
			
		}

		}
		
	}
}
	