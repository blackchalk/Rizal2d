using UnityEngine;
using System.Collections;

public class QIact3p2s4room : MonoBehaviour {
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
		if((act3part2.currentLine5==0)&&(act3part2.onQuest6)){//becker nurse
			Debug.Log("first");
			gameObject.SendMessage("ShowIt",20);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine5==1)&&(act3part2.onQuest6)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",18);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine5==3)&&(act3part2.onQuest6)){
			Debug.Log("last");
			gameObject.SendMessage("ShowIt",19);
			gameObject.SendMessage("QuestStatus");}//
		if((act3part2.currentLine6==0)&&(act3part2.onQuest7)){//becker
			Debug.Log("first");
			gameObject.SendMessage("ShowIt",23);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine6==1)&&(act3part2.onQuest7)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",21);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine6==14)&&(act3part2.onQuest7)){
			Debug.Log("last");
			gameObject.SendMessage("ShowIt",22);
			gameObject.SendMessage("QuestStatus");}//
		if((act3part2.currentLine6extended==0)&&(act3part2.onQuest9)){//becker extended quest
			Debug.Log("first");
			gameObject.SendMessage("ShowIt",23);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine6extended==1)&&(act3part2.onQuest9)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",21);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine6extended==3)&&(act3part2.onQuest9)){
			Debug.Log("last");
			gameObject.SendMessage("ShowIt",22);
			gameObject.SendMessage("QuestStatus");}//
	}
}
