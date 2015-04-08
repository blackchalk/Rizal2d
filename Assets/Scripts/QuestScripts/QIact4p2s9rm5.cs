using UnityEngine;
using System.Collections;

public class QIact4p2s9rm5 : MonoBehaviour {


	private NewAct4Part2 act4part2;
	private NewAct4Part3 act4part3;
	public bool EnablePart2 = true;
	public bool EnablePart3 = false;

// Update is called once per frame
void Update () {
		//act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();
		if(GameObject.Find("Player").GetComponent<NewAct4Part3>().enabled==true){
			EnablePart3 = true;
			EnablePart2 = false;
		}
}
private	void LateUpdate(){ //r changed this access modifier to private

	if(EnablePart2){
		act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();

		if((act4part2.currentLine1==0)&&(act4part2.onQuest1==true)){
		//Debug.Log("onquest1");
		gameObject.SendMessage("ShowIt",21);
		gameObject.SendMessage("QuestStatus");}
		if((act4part2.currentLine1==1)&&(act4part2.onQuest1==true)&&(act4part2.onQuest2==false)){
		//Debug.Log("2nd");
		gameObject.SendMessage("ShowIt",23);
		gameObject.SendMessage("QuestStatus");
		}
		if((act4part2.currentLine1==7)&&(act4part2.onQuest1==true)&&(act4part2.onQuest2==true)){
		//Debug.Log("last");
		gameObject.SendMessage("ShowIt",22);
		gameObject.SendMessage("QuestStatus");
		}//medicine quest is complete
		if((act4part2.currentLine1b==0)&&(act4part2.onCompleteMedicine==true)&&(act4part2.onQuest4==false)){
		//Debug.Log("oncompletemedicine true");
		gameObject.SendMessage("ShowIt",23);
		gameObject.SendMessage("QuestStatus");}
		if((act4part2.currentLine1b==1)&&(act4part2.onCompleteMedicine==true)&&(act4part2.onQuest4==false)){
		gameObject.SendMessage("ShowIt",21);
		gameObject.SendMessage("QuestStatus");
		}
		if((act4part2.currentLine1b==5)&&(act4part2.onCompleteMedicine==true)&&(act4part2.onQuest4==false)){
		gameObject.SendMessage("ShowIt",22);
		gameObject.SendMessage("QuestStatus");

		}//medicine quest is not yet complete
		if((act4part2.otherLine1==0)&&(act4part2.onCompleteMedicine==false)&&(act4part2.onQuest4==false)){
		gameObject.SendMessage("ShowIt",21);
				gameObject.SendMessage("QuestStatus");}
			//teaching finished
		if((act4part2.currentLine1c==0)&&(act4part2.onQuest4)&&(act4part2.onQuest3==false)){
		//Debug.Log("onquest4");
		gameObject.SendMessage("ShowIt",23);
		gameObject.SendMessage("QuestStatus");}
			if((act4part2.currentLine1c==1)&&(act4part2.onQuest4)&&(act4part2.onQuest3==false)){
		gameObject.SendMessage("ShowIt",21);
		gameObject.SendMessage("QuestStatus");}
			if((act4part2.currentLine1c==9)&&(act4part2.onQuest4)&&(act4part2.onQuest3==false)){
		gameObject.SendMessage("ShowIt",22);
		gameObject.SendMessage("QuestStatus");}

		}
		if(act4part2==null){
			return;
		}

		if(EnablePart3){
			act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
			//Debug.Log ("Part3 enabled here");
			this.gameObject.SendMessage("ShowIt",21);
			this.gameObject.SendMessage("QuestStatus");
		}
	}
}



