using UnityEngine;
using System.Collections;

public class QIact3p2s7elfili : MonoBehaviour {//elfili

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
		if((act3part2.currentLine9==0)&&(act3part2.onQuest12)){//onquest9
			Debug.Log("first");
			gameObject.SendMessage("ShowIt",26);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine9==1)&&(act3part2.onQuest12)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",24);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine9==11)&&(act3part2.onQuest12)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",25);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine9extended==0)&&(act3part2.onQuest15)){//onquest12 last
			Debug.Log("firstonquest12");
			gameObject.SendMessage("ShowIt",26);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine9extended==1)&&(act3part2.onQuest15)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",24);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine9extended==6)&&(act3part2.onQuest15)){
			Debug.Log("lastquest");
			gameObject.SendMessage("ShowIt",25);
			gameObject.SendMessage("QuestStatus");}
	}
}

