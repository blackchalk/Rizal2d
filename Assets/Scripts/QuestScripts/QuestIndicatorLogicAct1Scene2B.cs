using UnityEngine;
using System.Collections;
//REMINDERS:
//USED IN ACT1S2+NEWACT2+
//DONTDESTROY;
//
public class QuestIndicatorLogicAct1Scene2B: MonoBehaviour {

	public GameObject[] aObject;

	//private Act1Scene1Quest act1Check;
	public int nData = 0;

	void Awake(){

		//NotificationCentre.AddObserver(this,"ShowQuest");
	}
	// Use this for initialization
	void Start () {
		aObject[0].renderer.enabled=false;//act1s2b
		aObject[1].renderer.enabled=false;
		aObject[2].renderer.enabled=false;
//		aObject[3].renderer.enabled=false;//newact2
//		aObject[4].renderer.enabled=false;
//		aObject[5].renderer.enabled=false;
//		aObject[6].renderer.enabled=false;//newact2
//		aObject[7].renderer.enabled=false;
//		aObject[8].renderer.enabled=false;
//		aObject[9].renderer.enabled=false;//newact2
//		aObject[10].renderer.enabled=false;
//		aObject[11].renderer.enabled=false;
//		aObject[12].renderer.enabled=false;
//		aObject[13].renderer.enabled=false;
//		aObject[14].renderer.enabled=false;
//		aObject[15].renderer.enabled=false;//newact2
//		aObject[16].renderer.enabled=false;
//		aObject[17].renderer.enabled=false;
//		aObject[18].renderer.enabled=false;//newact2
//		aObject[19].renderer.enabled=false;
//		aObject[20].renderer.enabled=false;
//		aObject[21].renderer.enabled=false;//newact2
//		aObject[22].renderer.enabled=false;
//		aObject[23].renderer.enabled=false;
	}
	void Update(){
		//get a list of gameobject with tag qIndicator
		var aObjects = GameObject.FindGameObjectsWithTag("qIndicator");
		//redefine the list to array
		var qObject = new GameObject[aObjects.Length];
		//save the qobjects into the array for easy access when deactivated
		for(int i=0;i<aObjects.Length;i++){
			qObject[i]=aObjects[i];					
//			Debug.Log("MARKER "+qObject[i].name+"'s current state in scene is"+
//			          qObject[i].activeInHierarchy+" and object0 is"+qObject[i]);
		}
	}
	
 public void ShowQuest(){
	//func THAT handles the rendering of Quest Markers
//	Debug.Log("your nData is value:"+nData);
	switch(nData){
	case 0://CASE BELOW THIS LINE IS FOR ACT1S2
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
//		Debug.Log("CURRENT CASE LABEL:"+nData);
		nData = n;
		return;}
}
