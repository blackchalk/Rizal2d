//using UnityEngine;
//using System.Collections;
//
//public class ObjectLookup : MonoBehaviour {
//
//private Act1Scene1Quest act1Check;
//public string[] lookupState1; //array of states 1, 2 and 3
//public string[] lookupState2;
//public string[] lookupState3;
////public bool onquest;
//private int newState;
////	var repliesState1 : String[];
////	var repliesState2 : String[];
////	var repliesState3 : String[];
////	var genericReplies : String[];
//
//public int state = 1;
//
//private string[] currentStateArray; //var to hold the current array to process
////private String[] currentReplyArray;
//
//void Awake(){
//act1Check = GameObject.Find("Player").GetComponent<Act1Scene1Quest>();
//}
//
//// Use this for initialization
//void Start () {}//closes the start func
//
//public void LookUpState(GameObject trigObject, int currentState){ //currentgameobject, current state of this,
//
//state = currentState; //assign current state to the state variable
//
//switch (state) { // use the state to assign the corresponding array
//	
//case 1:
//	currentStateArray = lookupState1;    //lookupstate 1
//	//currentReplyArray = repliesState1;
//	break;
//	
//case 2:
//	currentStateArray = lookupState2;
//	//currentReplyArray = repliesState2;
//	break;
//	
//case 3:
//	currentStateArray = lookupState3;
//	//currentReplyArray = repliesState3;
//	break;
//}//closes the switch
////}//closes the if statement
//Debug.Log("Results for state :" + state );
//// go through the array by element
//foreach (string contents in currentStateArray) {
////view the contents of the current element in currentStateArray
//Debug.Log ("contents: " + contents);
////split the contents of the current element into a temporary string array
//char[] delim = new char[]{','};
//string[] readString = contents.Split(delim,System.StringSplitOptions.RemoveEmptyEntries);
////} //this will get uncommented later
//// now read the first two split out pieces (elements) back out
//Debug.Log ("elements in array for state :" + state + " = " + readString.Length);
//Debug.Log("first element is = " + readString[0]);
//Debug.Log ("location = " + readString[1]);
//			string h = readString[0];
//			Debug.Log("string 1st element is : "+h);
//			//looking for match
//			switch(h){
//			case "1"://trigger
//				if((act1Check.onQuest1==false)||((act1Check.onQuest1==false)&&(act1Check.onQuest2=true)))
//					currentState = 1;
//					SendMessage("ProcessObject",newState);
//					Debug.Log ("changed currentstate to"+currentState);
//				break;
//			case "2"://trigger	
//				if(((act1Check.onQuest1==true)||(act1Check.onQuest2==true))
//					&&(((act1Check.LampSet==0)&&(act1Check.MatchSet==1))||(act1Check.LampSet==1)&&(act1Check.MatchSet==0)))
//					currentState = 2;
//				SendMessage("ProcessObject",newState,SendMessageOptions.DontRequireReceiver);
//				Debug.Log ("changed currentstate to"+currentState);
//				//currentState = 2;
//				break;
//			case "3"://trigger
//				if((act1Check.Book==1)||((act1Check.LampSet==1)&&(act1Check.MatchSet==1)))
//					currentState = 3;
//				SendMessage("ProcessObject",newState,SendMessageOptions.DontRequireReceiver);
//				Debug.Log ("changed currentstate to"+currentState);
//				break;
//
//			default:
//				currentState = 0;
//				SendMessage("ProcessObject",newState,SendMessageOptions.DontRequireReceiver);
//				Debug.Log ("changed currentstate to"+currentState);
//				break;
//			}
////check for a cursor match with element 0 of the split
////if (readString[0]== cvalue){ // if there is a match...
//////get the new state, element 1 of the split, then convert the string to an int
////	int newstate = int.Parse(readString[1]);
//////transition the object into the new state over in the Interactor script
////SendMessage("ProcessObject",newState,SendMessageOptions.DontRequireReceiver); //raygon here check it!!!!!!!!!!!!
//
////now read throught the remainder in pairs, iterate	throught the array starting at element 2 and incrementing by 2
////as long as the counting variable i is less than the length of the array
//for (int i=2; i < readString.Length; i= i + 2) { //iterate
//	Debug.Log ("auxiliary object = " + readString[i]);
//	Debug.Log (readString[i]  +  "'s new state = " + readString[i+1]);
//	//assign the first piece of data in the pair to a temp variable for processing
//		string tempS = readString[i];
//				Debug.Log("TempS is :"+tempS+":manage find");
//		GameObject auxObject = GameObject.Find(tempS);
//	//check for special cases here
////					if(tempS.Substring(2,1) == "_"){// if there is a special case
////						string s = tempS.Substring(0,1); //put this to a variable s for case
////						int s2 = int.Parse(tempS.Substring(1,1)); // convert the second character to an integer
////
////						auxObject = GameObject.Find (tempS.Substring(3));// find the object by name & activate
////						bool bypass = false;//set a flag if the object shouldn't be transitioned into its new state
////					
//newState = int.Parse(readString[i+1]);
//Debug.Log("newstate to be passed="+newState);		
//auxObject.GetComponent<Interactor>().SendMessage("ProcessObject",newState,SendMessageOptions.DontRequireReceiver);
////					}//specialcase
//}// iterate
//}//ifs
//}//lookup function
//////	void QuestMatching(bool isMatch){
//////		if(isMatch){
//////			onquest=true;}
//////		
//////		else {
//////			onquest=false;
//////			
//////		}
//////	}//questmatching}
//}//class
//
