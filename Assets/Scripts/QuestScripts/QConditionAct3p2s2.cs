using UnityEngine;
using System.Collections;

public class QConditionAct3p2s2 : MonoBehaviour {//involved npc: npc2 npc8
	private NewAct3Part2 act3part2;

	// Use this for initialization
	void Start () {
		gameObject.SendMessage("renderStart",false);
	}
	
	// Update is called once per frame
	void Update () {
		act3part2 = GameObject.Find ("Player").GetComponent<NewAct3Part2>();
	}
	void LateUpdate(){//r
	if((act3part2.currentLine2==0)&&(act3part2.onQuest2)){ //lady shady tree
		Debug.Log("first");
		gameObject.SendMessage("ShowIt",5);
		gameObject.SendMessage("QuestStatus");}
	if((act3part2.currentLine2==1)&&(act3part2.onQuest2)){
		Debug.Log("2nd");
		gameObject.SendMessage("ShowIt",3);
		gameObject.SendMessage("QuestStatus");}
	if((act3part2.currentLine2==5)&&(act3part2.onQuest2)){
		Debug.Log("last");
		gameObject.SendMessage("ShowIt",4);
		gameObject.SendMessage("QuestStatus");}//
		if((act3part2.currentLineObject1==0)&&(act3part2.onQuest5)){
			Debug.Log("first");
			gameObject.SendMessage("ShowIt",5);// book and pen quest
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLineObject1==1)&&(act3part2.onQuest5)){// book and pen quest
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",3);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLineObject1==3)&&(act3part2.onQuest5)){
			Debug.Log("last");
			gameObject.SendMessage("ShowIt",4);
			gameObject.SendMessage("QuestStatus");}//
		if((act3part2.currentLine8==0)&&(act3part2.onQuest11)){
			Debug.Log("firstnpc8");
			gameObject.SendMessage("ShowIt",8);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine8==1)&&(act3part2.onQuest11)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",6);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine8==28)&&(act3part2.onQuest11)){
			Debug.Log("endnpc8");
			gameObject.SendMessage("ShowIt",7);
			gameObject.SendMessage("QuestStatus");}
	}
}
