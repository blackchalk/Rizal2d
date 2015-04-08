using UnityEngine;
using System.Collections;

public class QIact4p2s4rm1 : MonoBehaviour {

	private NewAct4Part3 act4part3;
	private NewAct4Part2 act4part2;
	public bool EnablePart2 = true;
	public bool EnablePart3 = false;
	
	void Awake(){
		//act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("Player").GetComponent<NewAct4Part3>().enabled==true){
			EnablePart3 = true;
			EnablePart2 = false;
		}
	}
	private	void LateUpdate(){ //r changed this access modifier to private
		if(EnablePart3){
		act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
		if((act4part3.currentDia1==0)&&(act4part3.onQuest1)){
			////Debug.Log("onquest1");
			gameObject.SendMessage("ShowIt",26);
			gameObject.SendMessage("QuestStatus");}
		if((act4part3.currentDia1==1)&&(act4part3.onQuest1)){
			////Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",24);
			gameObject.SendMessage("QuestStatus");
		}
		if((act4part3.currentDia1==3)&&(act4part3.onQuest1)){
			////Debug.Log("last");
			gameObject.SendMessage("ShowIt",1);
			gameObject.SendMessage("QuestStatus");
		}//
		if((act4part3.currentLine1==0)&&(act4part3.onQuest3)){
			////Debug.Log("onquest1");
			gameObject.SendMessage("ShowIt",27);
			gameObject.SendMessage("QuestStatus");}
		if((act4part3.currentLine1==1)&&(act4part3.onQuest3)){
			////Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",29);
			gameObject.SendMessage("QuestStatus");
		}
		if((act4part3.currentLine1==3)&&(act4part3.onQuest3)){
			////Debug.Log("last");
			gameObject.SendMessage("ShowIt",28);
			gameObject.SendMessage("QuestStatus");
		}//
			if(act4part3==null){
				//Debug.Log ("null");
				return;
			}
		}
		if(EnablePart2){
			act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();
			//Debug.Log ("Part2 enabled here");
			this.gameObject.SendMessage("ShowIt",1);
			this.gameObject.SendMessage("QuestStatus");
			if(act4part2==null){
				//Debug.Log ("null");
				return;
			}
		}
	}
}
