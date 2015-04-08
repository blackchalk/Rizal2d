using UnityEngine;
using System.Collections;

public class QIact4scene1 : MonoBehaviour {

	public GameObject[] aObject;
	public int nData = 0;
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

	// Use this for initialization
	void Start () {
		aObject[0].renderer.enabled=render;
		aObject[1].renderer.enabled=render;
		aObject[2].renderer.enabled=render;//1stquest
		aObject[3].renderer.enabled=render;
		aObject[4].renderer.enabled=render;
		aObject[5].renderer.enabled=render;//girlonquest2
		aObject[6].renderer.enabled=render;
		aObject[7].renderer.enabled=render;
		aObject[8].renderer.enabled=render;//guyhouse
//		aObject[9].renderer.enabled=render;
//		aObject[10].renderer.enabled=render;
//		aObject[11].renderer.enabled=render;//
//		aObject[12].renderer.enabled=render;
//		aObject[13].renderer.enabled=render;
//		aObject[14].renderer.enabled=render;//
//		aObject[15].renderer.enabled=render;
//		aObject[16].renderer.enabled=render;
//		aObject[17].renderer.enabled=render;//
//		aObject[18].renderer.enabled=render;
//		aObject[19].renderer.enabled=render;
//		aObject[20].renderer.enabled=render;//
//		aObject[21].renderer.enabled=render;
//		aObject[22].renderer.enabled=render;
//		aObject[23].renderer.enabled=render;//
//		aObject[24].renderer.enabled=render;
//		aObject[25].renderer.enabled=render;
//		aObject[26].renderer.enabled=render;//
//		aObject[27].renderer.enabled=render;
//		aObject[28].renderer.enabled=render;
//		aObject[29].renderer.enabled=render;//
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
			break;
		case 3:
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

			aObject[0].renderer.enabled=render;
			aObject[1].renderer.enabled=render;
			aObject[2].renderer.enabled=render;//
			break;
		case 6:
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
			
			aObject[0].renderer.enabled=render;
			aObject[1].renderer.enabled=render;
			aObject[2].renderer.enabled=render;//
			break;
		}
	}
	public void ShowIt(int n){//SHOWS THE DESIRED SWITCH CASE/LABEL
		//Debug.Log("CURRENT CASE LABEL:"+nData);
		nData = n;
		return;}
	public void renderStart(bool f){
		render = f;
		return;}
}