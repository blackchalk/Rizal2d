using UnityEngine;
using System.Collections;

public class QuestIndicatorAct3s4b : MonoBehaviour {//this is for act3scene 4b sole //onquest4

	public GameObject[] aObject;
	private NewAct3 act3Check;
	//private QuestIndicatorAct3s1 act3a;
	public int nData = 0;


	void Awake(){
			
		act3Check = GameObject.Find ("Player").GetComponent<NewAct3>();
		//act3a = GameObject.Find ("QUEST_INDICATOR").GetComponent<QUEST>
		//NotificationCentre.AddObserver(this,"QuestStatus");

		//get a list of gameobject with tag qIndicator
		var aObjects = GameObject.FindGameObjectsWithTag("qIndicator");
		//redefine the list to array
		var qObject = new GameObject[aObjects.Length];
		//save the qobjects into the array for easy access when deactivated
		for(int i=0;i<aObjects.Length;i++){
		qObject[i]=aObjects[i];					
		Debug.Log("object ="+qObject[i].name+"'s current state in scene is"+
	          qObject[i].activeInHierarchy+" and object0 is"+qObject[i]);}

		aObject[0].renderer.enabled=false;
		aObject[1].renderer.enabled=false;
		aObject[2].renderer.enabled=false;
		
	}
private	void LateUpdate(){ //raygon changed this access modifier to private
		
		if((act3Check.currentLine4==0)&&(act3Check.onQuest4==true)){
			ShowIt(2);
			QuestStatus();}
		if((act3Check.currentLine4==1)&&(act3Check.onQuest4==true)){
			ShowIt(0);
			QuestStatus();}
		if((act3Check.currentLine4==14)&&(act3Check.onQuest4==true)){
			ShowIt(1);
			QuestStatus();}

		

		
	}
	
private void QuestStatus(){ //also here 9:58pm

//		Hashtable myHash = new Hashtable(); //this part is essential for strict
//		myHash = note.data; //type casting of hashtables.
//		//ValueType thisValue = (ValueType)myHashtable[theKey];
//		int nData = (int)myHash[note.data];

		Debug.Log("your nData is value:"+nData+"\tobject:"+aObject[nData].name);
		switch(nData){
		case 0:
			aObject[0].renderer.enabled=true;
			aObject[1].renderer.enabled=false;
			aObject[2].renderer.enabled=false;
			break;
		case 1:
			aObject[0].renderer.enabled=false;
			aObject[1].renderer.enabled=true;
			aObject[2].renderer.enabled=false;
			break;
		case 2:
			aObject[0].renderer.enabled=false;
			aObject[1].renderer.enabled=false;
			aObject[2].renderer.enabled=true;
			break;
		
		
	}
}
	public void ShowIt(int n){//SHOWS THE DESIRED SWITCH CASE/LABEL
		Debug.Log("CURRENT CASE LABEL:"+nData);
		nData = n;
		return;}
}
