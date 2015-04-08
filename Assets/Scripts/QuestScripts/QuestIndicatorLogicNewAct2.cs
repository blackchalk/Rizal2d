using UnityEngine;
using System.Collections;
//REMINDERS:
//USED IN ACT1S2+NEWACT2+
//DONTDESTROY;
//
public class QuestIndicatorLogicNewAct2: MonoBehaviour {

	public GameObject[] aObject;

	//private Act1Scene1Quest act1Check;
	public int nData = 0;

	// Use this for initialization
	void Start () {
		aObject[0].renderer.enabled=false;//act1s2b
		aObject[1].renderer.enabled=false;
		aObject[2].renderer.enabled=false;
		aObject[3].renderer.enabled=false;//newact2
		aObject[4].renderer.enabled=false;
		aObject[5].renderer.enabled=false;
		aObject[6].renderer.enabled=false;//newact2
		aObject[7].renderer.enabled=false;
		aObject[8].renderer.enabled=false;
		aObject[9].renderer.enabled=false;//newact2
		aObject[10].renderer.enabled=false;
		aObject[11].renderer.enabled=false;
		aObject[12].renderer.enabled=false;
		aObject[13].renderer.enabled=false;
		aObject[14].renderer.enabled=false;
		aObject[15].renderer.enabled=false;//newact2
		aObject[16].renderer.enabled=false;
		aObject[17].renderer.enabled=false;
		aObject[18].renderer.enabled=false;//newact2
		aObject[19].renderer.enabled=false;
		aObject[20].renderer.enabled=false;
		aObject[21].renderer.enabled=false;//newact2
		aObject[22].renderer.enabled=false;
		aObject[23].renderer.enabled=false;
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
	Debug.Log("your nData is value:"+nData);
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
		case 3://CASE BELOW THIS LINE IS FOR ACT1S2
			aObject[3].renderer.enabled=true;
			aObject[4].renderer.enabled=false;
			aObject[5].renderer.enabled=false;
			break;
		case 4:
			aObject[3].renderer.enabled=false;
			aObject[4].renderer.enabled=true;
			aObject[5].renderer.enabled=false;
			break;
		case 5:
			aObject[3].renderer.enabled=false;
			aObject[4].renderer.enabled=false;
			aObject[5].renderer.enabled=true;
			break;
		case 6://CASE BELOW THIS LINE IS FOR ACT1S2
			aObject[6].renderer.enabled=true;
			aObject[7].renderer.enabled=false;
			aObject[8].renderer.enabled=false;
			break;
		case 7:
			aObject[6].renderer.enabled=false;
			aObject[7].renderer.enabled=true;
			aObject[8].renderer.enabled=false;
			break;
		case 8:
			aObject[6].renderer.enabled=false;
			aObject[7].renderer.enabled=false;
			aObject[8].renderer.enabled=true;
			break;
		case 9://CASE BELOW THIS LINE IS FOR ACT1S2
			aObject[9].renderer.enabled=true;
			aObject[10].renderer.enabled=false;
			aObject[11].renderer.enabled=false;
			break;
		case 10:
			aObject[9].renderer.enabled=false;
			aObject[10].renderer.enabled=true;
			aObject[11].renderer.enabled=false;
			break;
		case 11:
			aObject[9].renderer.enabled=false;
			aObject[10].renderer.enabled=false;
			aObject[11].renderer.enabled=true;
			break;
		case 12:
			aObject[12].renderer.enabled=true;
			aObject[13].renderer.enabled=false;
			aObject[14].renderer.enabled=false;
			break;
		case 13:
			aObject[12].renderer.enabled=false;
			aObject[13].renderer.enabled=true;
			aObject[14].renderer.enabled=false;
			break;
		case 14://CASE BELOW THIS LINE IS FOR ACT1S2
			aObject[12].renderer.enabled=false;
			aObject[13].renderer.enabled=false;
			aObject[14].renderer.enabled=true;
			break;
		case 15:
			aObject[15].renderer.enabled=true;
			aObject[16].renderer.enabled=false;
			aObject[17].renderer.enabled=false;
			break;
		case 16:
			aObject[15].renderer.enabled=false;
			aObject[16].renderer.enabled=true;
			aObject[17].renderer.enabled=false;
			break;
		case 17:
			aObject[15].renderer.enabled=false;
			aObject[16].renderer.enabled=false;
			aObject[17].renderer.enabled=true;
			break;
		case 18:
			aObject[18].renderer.enabled=true;
			aObject[19].renderer.enabled=false;
			aObject[20].renderer.enabled=false;
			break;
		case 19:
			aObject[18].renderer.enabled=false;
			aObject[19].renderer.enabled=true;
			aObject[20].renderer.enabled=false;
			break;
		case 20://CASE BELOW THIS LINE IS FOR ACT1S2
			aObject[18].renderer.enabled=false;
			aObject[19].renderer.enabled=false;
			aObject[20].renderer.enabled=true;
			break;
		case 21:
			aObject[21].renderer.enabled=true;
			aObject[22].renderer.enabled=false;
			aObject[23].renderer.enabled=false;
			break;
		case 22:
			aObject[21].renderer.enabled=false;
			aObject[22].renderer.enabled=true;
			aObject[23].renderer.enabled=false;
			break;
		case 23:
			aObject[21].renderer.enabled=false;
			aObject[22].renderer.enabled=false;
			aObject[23].renderer.enabled=true;
			break;	
		}
	}
	public void ShowIt(int n){//SHOWS THE DESIRED SWITCH CASE/LABEL
		//Debug.Log("CURRENT CASE LABEL:"+nData);
		nData = n;
		return;}
}
