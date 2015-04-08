using UnityEngine;
using System.Collections;

public class QIact3part2 : MonoBehaviour {

	public GameObject[] aObject;
	public int nData;
	public bool render = false;


	void Awake(){
		//get a list of gameobject with tag qIndicator
		var aObjects = GameObject.FindGameObjectsWithTag("qIndicator");
		//redefine the list to array
		var qObject = new GameObject[aObjects.Length];
		//save the qobjects into the array for easy access when deactivated
		for(int i=0;i<aObjects.Length;i++){
			qObject[i]=aObjects[i];					
//			Debug.Log("object ="+qObject[i].name+"'s current state in scene is"+
//			          qObject[i].activeInHierarchy+" and object0 is"+qObject[i]);
		}
	
	}
	void Start(){
		aObject[0].renderer.enabled=render;
		aObject[1].renderer.enabled=render;
		aObject[2].renderer.enabled=render;//1stquest
		aObject[3].renderer.enabled=render;
		aObject[4].renderer.enabled=render;
		aObject[5].renderer.enabled=render;//girlonquest2
		aObject[6].renderer.enabled=render;
		aObject[7].renderer.enabled=render;
		aObject[8].renderer.enabled=render;//guyhouse
		aObject[9].renderer.enabled=render;
		aObject[10].renderer.enabled=render;
		aObject[11].renderer.enabled=render;//
		aObject[12].renderer.enabled=render;
		aObject[13].renderer.enabled=render;
		aObject[14].renderer.enabled=render;//
		aObject[15].renderer.enabled=render;
		aObject[16].renderer.enabled=render;
		aObject[17].renderer.enabled=render;//
		aObject[18].renderer.enabled=render;
		aObject[19].renderer.enabled=render;
		aObject[20].renderer.enabled=render;//
		aObject[21].renderer.enabled=render;
		aObject[22].renderer.enabled=render;
		aObject[23].renderer.enabled=render;//
		aObject[24].renderer.enabled=render;
		aObject[25].renderer.enabled=render;
		aObject[26].renderer.enabled=render;//
		aObject[27].renderer.enabled=render;
		aObject[28].renderer.enabled=render;
		aObject[29].renderer.enabled=render;//
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void QuestStatus(){ //also here 12:47pm 28jan2015

		
		//		Hashtable myHash = new Hashtable(); //this part is essential for strict
		//		myHash = note.data; 				//type casting of hashtables.
		//		//ValueType thisValue = (ValueType)myHashtable[theKey];
		//		int nData = (int)myHash[note.data];
		
		//Debug.Log("your nData is value:"+nData+"\tobject:"+aObject[nData].name);
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

			aObject[3].renderer.enabled=render;
			aObject[4].renderer.enabled=render;
			aObject[5].renderer.enabled=render;//girlonquest2
			aObject[6].renderer.enabled=render;
			aObject[7].renderer.enabled=render;
			aObject[8].renderer.enabled=render;//guyhouse
			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 3:
			aObject[3].renderer.enabled=true;
			aObject[4].renderer.enabled=false;
			aObject[5].renderer.enabled=false;

			aObject[6].renderer.enabled=render;
			aObject[7].renderer.enabled=render;
			aObject[8].renderer.enabled=render;//guyhouse
			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//

			break;
		case 4:
			aObject[3].renderer.enabled=false;
			aObject[4].renderer.enabled=true;
			aObject[5].renderer.enabled=false;

			aObject[6].renderer.enabled=render;
			aObject[7].renderer.enabled=render;
			aObject[8].renderer.enabled=render;//guyhouse
			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 5:
			aObject[3].renderer.enabled=false;
			aObject[4].renderer.enabled=false;
			aObject[5].renderer.enabled=true;

			aObject[6].renderer.enabled=render;
			aObject[7].renderer.enabled=render;
			aObject[8].renderer.enabled=render;//guyhouse
			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 6:
			aObject[6].renderer.enabled=true;
			aObject[7].renderer.enabled=false;
			aObject[8].renderer.enabled=false;
			aObject[3].renderer.enabled=render;
			aObject[4].renderer.enabled=render;
			aObject[5].renderer.enabled=render;//girlonquest2
			break;
		case 7:
			aObject[6].renderer.enabled=false;
			aObject[7].renderer.enabled=true;
			aObject[8].renderer.enabled=false;
			aObject[3].renderer.enabled=render;
			aObject[4].renderer.enabled=render;
			aObject[5].renderer.enabled=render;//girlonquest2
			break;
		case 8:
			aObject[6].renderer.enabled=false;
			aObject[7].renderer.enabled=false;
			aObject[8].renderer.enabled=true;
			aObject[3].renderer.enabled=render;
			aObject[4].renderer.enabled=render;
			aObject[5].renderer.enabled=render;//girlonquest2
			break;
		case 9://girlonquest3
			aObject[9].renderer.enabled=true;
			aObject[10].renderer.enabled=false;
			aObject[11].renderer.enabled=false;

			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 10:
			aObject[9].renderer.enabled=false;
			aObject[10].renderer.enabled=true;
			aObject[11].renderer.enabled=false;

			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 11:
			aObject[9].renderer.enabled=false;
			aObject[10].renderer.enabled=false;
			aObject[11].renderer.enabled=true;

			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 12://guyonquest4
			aObject[12].renderer.enabled=true;
			aObject[13].renderer.enabled=false;
			aObject[14].renderer.enabled=false;

			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 13:
			aObject[12].renderer.enabled=false;
			aObject[13].renderer.enabled=true;
			aObject[14].renderer.enabled=false;
			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 14:
			aObject[12].renderer.enabled=false;
			aObject[13].renderer.enabled=false;
			aObject[14].renderer.enabled=true;

			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			break;
		case 15://
			aObject[15].renderer.enabled=true;
			aObject[16].renderer.enabled=false;
			aObject[17].renderer.enabled=false;

			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			break;
		case 16:
			aObject[15].renderer.enabled=false;
			aObject[16].renderer.enabled=true;
			aObject[17].renderer.enabled=false;

			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			break;
		case 17:
			aObject[15].renderer.enabled=false;
			aObject[16].renderer.enabled=false;
			aObject[17].renderer.enabled=true;

			aObject[9].renderer.enabled=render;
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			break;
		case 18://becker house
			aObject[18].renderer.enabled=true;
			aObject[19].renderer.enabled=false;
			aObject[20].renderer.enabled=false;


			aObject[21].renderer.enabled=render;
			aObject[22].renderer.enabled=render;
			aObject[23].renderer.enabled=render;//

			break;
		case 19:
			aObject[18].renderer.enabled=false;
			aObject[19].renderer.enabled=true;
			aObject[20].renderer.enabled=false;


			aObject[21].renderer.enabled=render;
			aObject[22].renderer.enabled=render;
			aObject[23].renderer.enabled=render;//
			break;
		case 20:
			aObject[18].renderer.enabled=false;
			aObject[19].renderer.enabled=false;
			aObject[20].renderer.enabled=true;


			aObject[21].renderer.enabled=render;
			aObject[22].renderer.enabled=render;
			aObject[23].renderer.enabled=render;//
			break;
		case 21://becker house
			aObject[21].renderer.enabled=true;
			aObject[22].renderer.enabled=false;
			aObject[23].renderer.enabled=false;

			aObject[18].renderer.enabled=render;
			aObject[19].renderer.enabled=render;
			aObject[20].renderer.enabled=render;//

			break;
		case 22:
			aObject[21].renderer.enabled=false;
			aObject[22].renderer.enabled=true;
			aObject[23].renderer.enabled=false;

			aObject[18].renderer.enabled=render;
			aObject[19].renderer.enabled=render;
			aObject[20].renderer.enabled=render;//
	
			break;
		case 23:
			aObject[21].renderer.enabled=false;
			aObject[22].renderer.enabled=false;
			aObject[23].renderer.enabled=true;

			aObject[18].renderer.enabled=render;
			aObject[19].renderer.enabled=render;
			aObject[20].renderer.enabled=render;//

			break;
		case 24://elfili
			aObject[18].renderer.enabled=render;
			aObject[19].renderer.enabled=render;
			aObject[20].renderer.enabled=render;//
			aObject[21].renderer.enabled=render;
			aObject[22].renderer.enabled=render;
			aObject[23].renderer.enabled=render;//
			aObject[24].renderer.enabled=true;
			aObject[25].renderer.enabled=false;
			aObject[26].renderer.enabled=false;
			aObject[27].renderer.enabled=render;
			aObject[28].renderer.enabled=render;
			aObject[29].renderer.enabled=render;//
			break;
		case 25:
			aObject[24].renderer.enabled=false;
			aObject[25].renderer.enabled=true;
			aObject[26].renderer.enabled=false;
			aObject[27].renderer.enabled=render;
			aObject[28].renderer.enabled=render;
			aObject[29].renderer.enabled=render;//
			break;
		case 26:
			aObject[18].renderer.enabled=render;
			aObject[19].renderer.enabled=render;
			aObject[20].renderer.enabled=render;//
			aObject[21].renderer.enabled=render;
			aObject[22].renderer.enabled=render;
			aObject[23].renderer.enabled=render;//
			aObject[24].renderer.enabled=false;
			aObject[25].renderer.enabled=false;
			aObject[26].renderer.enabled=true;
			aObject[27].renderer.enabled=render;
			aObject[28].renderer.enabled=render;
			aObject[29].renderer.enabled=render;//
			break;
		case 27://onquest13
			aObject[10].renderer.enabled=render;
			aObject[11].renderer.enabled=render;//
			aObject[12].renderer.enabled=render;
			aObject[13].renderer.enabled=render;
			aObject[14].renderer.enabled=render;//
			aObject[15].renderer.enabled=render;
			aObject[16].renderer.enabled=render;
			aObject[17].renderer.enabled=render;//
			aObject[18].renderer.enabled=render;
			aObject[19].renderer.enabled=render;
			aObject[20].renderer.enabled=render;//
			aObject[21].renderer.enabled=render;
			aObject[22].renderer.enabled=render;
			aObject[23].renderer.enabled=render;//
			aObject[24].renderer.enabled=render;
			aObject[25].renderer.enabled=render;
			aObject[26].renderer.enabled=render;//
			aObject[27].renderer.enabled=true;
			aObject[28].renderer.enabled=false;
			aObject[29].renderer.enabled=false;
			break;
		case 28:
			aObject[20].renderer.enabled=render;//
			aObject[21].renderer.enabled=render;
			aObject[22].renderer.enabled=render;
			aObject[23].renderer.enabled=render;//
			aObject[24].renderer.enabled=render;
			aObject[25].renderer.enabled=render;
			aObject[26].renderer.enabled=render;//
			aObject[27].renderer.enabled=false;
			aObject[28].renderer.enabled=true;
			aObject[29].renderer.enabled=false;
			break;
		case 29:
			aObject[20].renderer.enabled=render;//
			aObject[21].renderer.enabled=render;
			aObject[22].renderer.enabled=render;
			aObject[23].renderer.enabled=render;//
			aObject[24].renderer.enabled=render;
			aObject[25].renderer.enabled=render;
			aObject[26].renderer.enabled=render;//
			aObject[27].renderer.enabled=false;
			aObject[28].renderer.enabled=false;
			aObject[29].renderer.enabled=true;
			break;
			
		}
	}
	public void ShowIt(int n){//SHOWS THE DESIRED SWITCH CASE/LABEL
		//Debug.Log("CURRENT CASE LABEL:"+nData);
		nData = n;
		//return;
	}
	public void renderStart(bool f){
		render = f;
	return;}

	public void SpecialCases(bool f){ // ACT 4 FINAL PART1.CS OR AKA ACT 4 PART 3 SCENE 1
		render = f;
		aObject[0].renderer.enabled=render;
		aObject[1].renderer.enabled=render;
		aObject[2].renderer.enabled=render;//1stquest
	}
}
