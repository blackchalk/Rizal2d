using UnityEngine;
using System.Collections;

public class QIact4Scene2condition : MonoBehaviour {

	private NewAct4Part1 act4part1;
	
	void Awake(){
		act4part1 = GameObject.Find ("Player").GetComponent<NewAct4Part1>();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private	void LateUpdate(){ //r changed this access modifier to private
		
		if((act4part1.currentLine2==0)&&(act4part1.onQuest2)){
			//Debug.Log("");
			gameObject.SendMessage("ShowIt",6);
			gameObject.SendMessage("QuestStatus");}
		if((act4part1.currentLine2==1)&&(act4part1.onQuest2)){
			//Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",8);
			gameObject.SendMessage("QuestStatus");
		}
		if((act4part1.currentLine2==3)&&(act4part1.onQuest2)){
			//Debug.Log("last");
			gameObject.SendMessage("ShowIt",7);
			gameObject.SendMessage("QuestStatus");
		}//

}
}
