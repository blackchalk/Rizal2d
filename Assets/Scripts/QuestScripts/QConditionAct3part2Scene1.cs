using UnityEngine;
using System.Collections;

public class QConditionAct3part2Scene1 : MonoBehaviour {//involved npc: npc1

	private NewAct3Part2 act3part2;


	// Use this for initialization
	void Awake () {
		//gameObject.SendMessage("renderStart",false);

	}
	
	// Update is called once per frame
	void Update () {
		act3part2 = GameObject.Find ("Player").GetComponent<NewAct3Part2>();

		
	}
	private	void LateUpdate(){ //r changed this access modifier to private

		if((act3part2.currentLine1==0)&&(act3part2.onQuest1)){
			//Debug.Log("first");
			gameObject.SendMessage("ShowIt",0,SendMessageOptions.RequireReceiver);	//SendmessageOptions-needed for explicit reasons
			gameObject.SendMessage("QuestStatus");
		}
		if((act3part2.currentLine1==1)&&(act3part2.onQuest1)){
			//Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",2);
			gameObject.SendMessage("QuestStatus");
		}
		if((act3part2.currentLine1==9)&&(act3part2.onQuest1)){
			//Debug.Log("last");
			gameObject.SendMessage("ShowIt",1);
			gameObject.SendMessage("QuestStatus");
		}//pen and book npc1
		if((act3part2.currentLineObject2==0)&&(act3part2.onQuest5)){
			//Debug.Log("firstpen");
			gameObject.SendMessage("ShowIt",2);
			gameObject.SendMessage("QuestStatus");
		}
		if((act3part2.currentLineObject2==1)&&(act3part2.onQuest5)){
			//Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",0,SendMessageOptions.RequireReceiver);
			gameObject.SendMessage("QuestStatus");
		}
		if((act3part2.currentLineObject2==8)&&(act3part2.onQuest5)){
			//Debug.Log("endpen");
			gameObject.SendMessage("ShowIt",1);
			gameObject.SendMessage("QuestStatus");
		}
		

		
		
		
	}
}
