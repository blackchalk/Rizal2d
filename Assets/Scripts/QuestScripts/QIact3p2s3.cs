using UnityEngine;
using System.Collections;

public class QIact3p2s3 : MonoBehaviour {//npc4,3,7
	private NewAct3Part2 act3part2;

	// Use this for initialization
	void Awake () {


	}
	void Start(){
		gameObject.SendMessage("renderStart",false);
	}
	
	// Update is called once per frame
	void Update () {
		act3part2 = GameObject.Find ("Player").GetComponent<NewAct3Part2>();
	}
	void LateUpdate(){
		if((act3part2.currentLine3==0)&&(act3part2.onQuest3)){ //lady dress
			Debug.Log("first");
			gameObject.SendMessage("ShowIt",11);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine3==1)&&(act3part2.onQuest3)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",9);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine3==6)&&(act3part2.onQuest3)){
			Debug.Log("last");
			gameObject.SendMessage("ShowIt",10);
			gameObject.SendMessage("QuestStatus");}//
		if((act3part2.currentLine4==0)&&(act3part2.onQuest4)){//fountain
			Debug.Log("firstonquest8");
			gameObject.SendMessage("ShowIt",14);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine4==1)&&(act3part2.onQuest4)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",12);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine4==18)&&(act3part2.onQuest4)){
			Debug.Log("lastonquest8");
			gameObject.SendMessage("ShowIt",13);
			gameObject.SendMessage("QuestStatus");}//
		if((act3part2.currentLine7==0)&&(act3part2.onQuest8)){//blind man
			Debug.Log("firstonquest4");
			gameObject.SendMessage("ShowIt",17);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine7==1)&&(act3part2.onQuest8)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",15);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine7==18)&&(act3part2.onQuest8)){
			Debug.Log("lastonquest4");
			gameObject.SendMessage("ShowIt",16);
			gameObject.SendMessage("QuestStatus");}
		if(((act3part2.pen==0)&&(act3part2.books==0))&&act3part2.onQuest5){//book and pen 0 extended
			Debug.Log("firstonquest5");
			gameObject.SendMessage("ShowIt",12);
			gameObject.SendMessage("QuestStatus");}
		if(((act3part2.Object2==true)&&(act3part2.Object1==true))&&act3part2.onQuest5){//penbook == 1
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",14);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine4extended==7)&&(act3part2.onQuest5)){//pen book
			Debug.Log("lastonquest8");
			gameObject.SendMessage("ShowIt",13);
			gameObject.SendMessage("QuestStatus");}//
		if((act3part2.currentLine7extended==0)&&(act3part2.onQuest10)){//blind man extended
			Debug.Log("firstonquest4");
			gameObject.SendMessage("ShowIt",17);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine7extended==1)&&(act3part2.onQuest10)){
			Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",15);
			gameObject.SendMessage("QuestStatus");}
		if((act3part2.currentLine7extended==17)&&(act3part2.onQuest10)){
			Debug.Log("lastonquest4");
			gameObject.SendMessage("ShowIt",16);
			gameObject.SendMessage("QuestStatus");}
		
		
	}
}
