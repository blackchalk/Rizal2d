using UnityEngine;
using System.Collections;

public class IndicateConditionNewAct2 : MonoBehaviour {
	
	private NewAct2 act2Check;
	private QuestIndicatorLogicNewAct2 act2b;

	void Update(){
		act2Check = GameObject.Find ("Player").GetComponent<NewAct2>();
		act2b = GameObject.Find ("Quest_Indicator_Logic").GetComponent<QuestIndicatorLogicNewAct2>();

		//ifs
		if((act2Check.onQuest1a==true)&&(act2Check.currentLine1==0)){
			act2b.ShowIt(3);
			act2b.ShowQuest();}
		if((act2Check.currentLine1==1)&&(act2Check.onQuest1b==false)){
				act2b.ShowIt(4);
				act2b.ShowQuest();}//student
		if((act2Check.currentLine1==6)&&(act2Check.onQuest1b==true)){
				act2b.ShowIt(6);
				act2b.ShowQuest();}
		if((act2Check.onQuest1b==true)&&(act2Check.currentLine==1)){
				act2b.ShowIt(8);//book
				act2b.ShowQuest();}
		if(act2Check.currentLine==2){
				act2b.ShowIt(7);
				act2b.ShowQuest();}
		if((act2Check.currentLine2==0)&&(act2Check.onQuest2==true)){
				act2b.ShowIt(11);
				act2b.ShowQuest();}//npc2
		if((act2Check.currentLine2==1)&&(act2Check.onQuest2==true)){
			act2b.ShowIt(9);
			act2b.ShowQuest();}//
		if((act2Check.currentLine2==5)&&(act2Check.onTransition1==true)){
			act2b.ShowIt(10);
			act2b.ShowQuest();}//
		if((act2Check.hideTransition1==true)&&(act2Check.currentLine2==5)){
			act2b.ShowIt(12);
			act2b.ShowQuest();}
		if(act2Check.transLine1==3){
			act2b.ShowIt(13);
			act2b.ShowQuest();}//door
		if((act2Check.onQuest5==true)&&(act2Check.transLine2==0)){
			act2b.ShowIt(15);
			act2b.ShowQuest();}//workshop
		if((act2Check.onQuest6==true)&&(act2Check.transLine2==2)){
			act2b.ShowIt(16);
			act2b.ShowQuest();//workshop
			}
		if((act2Check.Object2==false)&&(act2Check.onQuest6==true)){
			act2b.ShowIt(18);
			act2b.ShowQuest();//workshop
			}
		if((act2Check.Object2==true)&&(act2Check.onQuest6==true)){
			act2b.ShowIt(20);
			act2b.ShowQuest();//station
			}
		if((act2Check.Object2==true)&&(act2Check.hitcount>=11)){
			act2b.ShowIt(19);
			act2b.ShowQuest();//station
			}
		if((act2Check.onQuest7==true)&&(act2Check.NPC4==false)){
			act2b.ShowIt(23);
			act2b.ShowQuest();//station
			}
		if((act2Check.onQuest7==true)&&(act2Check.NPC4==true)){
			act2b.ShowIt(21);
			act2b.ShowQuest();//station
			}
		if((act2Check.currentLine4==8)&&(act2Check.onQuest8==true)){
			act2b.ShowIt(22);
			act2b.ShowQuest();//station
			}
		}//end library studen

	}
