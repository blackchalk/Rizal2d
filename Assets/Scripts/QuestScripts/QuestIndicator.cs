using UnityEngine;
using System.Collections;

public class QuestIndicator : MonoBehaviour {//this is for act1scene1remake sole

	public GameObject[] aObject;
	private Act1Scene1Quest act1Check;
	public int nData = 0;


	void Awake(){
		act1Check = GameObject.Find ("Player").GetComponent<Act1Scene1Quest>();
		//checks if the tagged qindicator are in scene
		var aObjects = GameObject.FindGameObjectsWithTag("qIndicator");
		//redefine the list to array
		var qObject = new GameObject[aObjects.Length];
		//save the qobjects into the array for easy access when deactivated
		for(int i=0;i<aObjects.Length;i++){
		qObject[i]=aObjects[i];					
//		Debug.Log("object ="+qObject[i].name+"'s current state in this scene is"+
//	          qObject[i].activeInHierarchy+"and object is"+qObject[i]);
			}
	}
private	void LateUpdate(){ //raygon changed this access modifier to private
		
		
		if((act1Check.Book == 1)||
		   ((act1Check.Book==1)&&(act1Check.MatchSet==1)&&(act1Check.LampSet==1)&&
		 	(act1Check.currentLine1==6)&&(act1Check.currentLine2==6)&&
			 (act1Check.onQuest2==true)))
				{
			nData=2;
			QuestStatus();
		}
		if(((act1Check.onQuest1 == false)&&(act1Check.currentLine2==0))
		   ||((act1Check.currentLine2 == 2)&&(act1Check.Book==1)))
			{
			nData=0;
			QuestStatus();
		}
		if(((act1Check.currentLine1 >= 1)&&(act1Check.Book==0))
		   ||((act1Check.currentLine1==6)&&(act1Check.currentLine2==6)
		   &&(act1Check.onQuest2==true)&&(act1Check.Book==1)))
			{
			nData=1;
			QuestStatus();
		}	
	}
	
private void QuestStatus(){ //r created jan9:58pm
/*		Hashtable myHash = new Hashtable(); //this part is essential for strict
		myHash = note.data; //type casting of hashtables.
		//ValueType thisValue = (ValueType)myHashtable[theKey];
		int nData = (int)myHash[note.data];*/

		//Debug.Log("your nData is value:"+nData+"\tobject:"+aObject[nData].name); //prints the array to be displayed
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
}
