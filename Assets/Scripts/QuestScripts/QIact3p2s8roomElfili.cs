using UnityEngine;
using System.Collections;

public class QIact3p2s8roomElfili : MonoBehaviour {

	private NewAct3Part2 act3part2;
	
	// Use this for initialization
	void Awake () {

		
		// Use this for initialization
	}
	void Start () {
		gameObject.SendMessage("renderStart",false);
	}
	
	// Update is called once per frame
	void Update () {
		act3part2 = GameObject.Find ("Player").GetComponent<NewAct3Part2>();
		
	}
	void LateUpdate(){
		if((act3part2.currentLine10==0)&&(act3part2.onQuest13)){//onquest9
			Debug.Log("firstonquest13");
			gameObject.SendMessage("ShowIt",29);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine10==1)&&(act3part2.onQuest13)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",27);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine10==3)&&(act3part2.onQuest13)){
			Debug.Log("onquest13");
			gameObject.SendMessage("ShowIt",28);
			gameObject.SendMessage("QuestStatus");}

}
}