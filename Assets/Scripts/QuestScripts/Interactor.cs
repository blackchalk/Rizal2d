//using UnityEngine;
//using System.Collections;
//
//public class Interactor : MonoBehaviour {
//
//	private Act1Scene1Quest act1Check;
//	private QuestUnlocked questCheck;
//
//
//
//	public bool quest; // temporary cursor for testing LookupState”
//	private string name;
//	//public GameObject player; //control center obj
//	private GameObject aObject; //for aux object
//	public int currentState=1;                     // this will get updated in Start
//	private int currentLocation;             // see notes
//	private int currentVisibility;           //see notes
//	private string currentObjectName;        // short description”
//	private sbyte currentObjectDescription; // full description
//	private AudioClip currentSound;
//	//internal var currentAudioDelay : float = 0.0;
//	private AnimationClip currentAnimationClip;
//	//internal var currentAnimationDelay : float = 0.0;
//
//	//public int numTest; //here quest and npc
//	public int initialState = 1;
//
//	//Object metadata
//	public int[] location;                 // see notes
//	public int[] visibility;                 // see notes
//	public string[] objectName;              // name/label of the object in this state
//	public string[] description;             // description of the object in this state
//	public AnimationClip[] animationClip;    // the animation that will play when picked
//	//var animationDelay : float[];           // the time delay before the animation plays
////	var soundClip : AudioClip[];            // the sound that gets played when picked
////	var audioDelay : float[];               // the time delay before the audio plays”
////	var loopAnimation : AnimationClip[];    //animation that loops after main animation
////	var loopSoundFX : AudioClip[];          // sound that goes with it
////	public boolean postLoop	= false;         // flag to know if it has a looping animation to follow
////	public boolean animates = true;          // var to know if it animates at all
//	public GameObject aniObject;             // object that holds the animation component for this object
//
//	//pick and mouseoverinfo
////	private boolean picked = false;  // so you can temporarily prevent mouseover action
////	private boolean mousedown; //so you will know when this is true
////	private boolean processing = false; //so you can suspend mouseover actions, etc.
////
//	void Awake(){
//		questCheck = GameObject.Find("GUIQUnlock").GetComponent<QuestUnlocked>();
//		act1Check = GameObject.Find("Player").GetComponent<Act1Scene1Quest>();
//	}
//
//	// Use this for initialization
//	void Start () { 
//
//		// load the initial values
//		currentState = initialState; // this allows override of starting state only
//		//currentObjectName = objectName[currentState];
//		//currentObjectDescription = description[currentState];
//		currentLocation = location[currentState];
//		currentVisibility = visibility[currentState];
//		if(initialState==0){
//			gameObject.SetActive(false);}
//		if(location[currentState]==0){
//			this.gameObject.SetActive(false);}
//		if(location[currentState]==1){
//			this.gameObject.SetActive(true);}
//
//
//
//	}//end of Start()
//
//	void Update(){
//
//
//
//	}
//
//	void OnTriggerEnter2D(Collider2D co) {
//
//		Debug.Log ("Collider name activated=" + this.gameObject.name+"with tags :"+this.gameObject.tag);
//		Debug.Log ("current state: "+currentState);
//		//send the picked object, its current state, [and the cursor [its texture name]]
//		//that picked it directly to the LookUpState function for processing
//		if((co.gameObject.tag=="NPC1")||(co.gameObject.tag=="object1")||(co.gameObject.tag=="object1")||(co.gameObject.tag=="object1")){
//			GetComponent<ObjectLookup>().LookUpState(this.gameObject,currentState);
//				if(location[currentState]==2)
//				return;
//		}
//		GetComponent<ObjectLookup>().LookUpState(this.gameObject,currentState);
//
//	}//end ontriggerenter2d
//
//
//
////	void Visibility(int nextState){
////		currentState = nextState;
////
////		currentLocation = location[currentState] ;
////	}
//
//	void ProcessObject(int newState){
//
//		currentState = newState; //update the current state
//		// update more of the data with the new state
//		//currentObjectName = objectName[currentState];
//		//currentObjectDescription = description[currentState];
//		currentLocation = location[currentState];
//		currentVisibility = visibility[currentState];
//		//HandleVisibility();
//
//	}
//	public void CheckForActive(string name){
//			//check if the object is active before assigning to auxobject
//			if (GameObject.Find(name)){
//			GameObject auxObject = GameObject.Find(name);
//			return;}
//	}//end checkforactive
//
//
//}//end class
