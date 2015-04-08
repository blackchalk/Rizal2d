using UnityEngine;
using System.Collections;

public class QIact4P2S7rm4 : MonoBehaviour {

	private NewAct4Part2 act4part2;
	private NewAct4Part3 act4part3;
	public bool EnablePart2 = true;
	public bool EnablePart3 = false;
	
	void Awake(){
		//act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();
	}
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("Player").GetComponent<NewAct4Part3>().enabled==true){
			EnablePart3 = true;
			EnablePart2 = false;
		}
	}
	private	void LateUpdate(){ //r changed this access modifier to private
		
	if(EnablePart2){
		act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();

		if((act4part2.currentLine4==0)&&(act4part2.onQuest2)){
			//Debug.Log("onquest4");
			gameObject.SendMessage("ShowIt",14);
			gameObject.SendMessage("QuestStatus");}
		if((act4part2.currentLine4==1)&&(act4part2.onQuest2)){
			//Debug.Log("2nd");
			gameObject.SendMessage("ShowIt",12);
			gameObject.SendMessage("QuestStatus");
		}
		if((act4part2.currentLine4==12)&&(act4part2.onQuest2)){
			//Debug.Log("last");
			gameObject.SendMessage("ShowIt",13);
			gameObject.SendMessage("QuestStatus");
		}
			if(act4part2==null){
				Debug.Log ("null");
				return;
			}
		}
		if(EnablePart3){
			act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
			Debug.Log ("Part3 enabled here");
			this.gameObject.SendMessage("ShowIt",29);
			this.gameObject.SendMessage("QuestStatus");
		}
	}
}
