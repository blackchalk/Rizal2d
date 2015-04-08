using UnityEngine;
using System.Collections;

public class IndicateCondition : MonoBehaviour {
	private Act1Scene2 act1Check;
	private QuestIndicatorLogic act1s2;

private	void LateUpdate(){
		act1Check = GameObject.Find ("Player").GetComponent<Act1Scene2>();
		act1s2 = GetComponent<QuestIndicatorLogic>();

		if(act1Check.currentLineObject1==0){
			act1s2.ShowIt(0);
			act1s2.ShowQuest();
		}
		if(act1Check.currentLineObject1==1){
			act1s2.ShowIt(2);
			act1s2.ShowQuest();
		}
		if(act1Check.currentLineObject1==5){
			act1s2.ShowIt(1);
			act1s2.ShowQuest();
		}

	}
}