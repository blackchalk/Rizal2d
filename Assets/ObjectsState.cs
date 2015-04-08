using UnityEngine;
using System.Collections;

public class ObjectsState : MonoBehaviour {


		private string name;
//		private GameObject aObject; //for aux object
		public int currentState=1;                     // this will get updated in Start
		public AudioClip currentSound;
		//internal var currentAudioDelay : float = 0.0;
		private AnimationClip currentAnimationClip;
		//internal var currentAnimationDelay : float = 0.0;
		public int initialState = 1;
		public int iElement;

	// Use this for initialization
	void Start () {
				// load the initial values
				currentState = initialState; // this allows override of starting state only
				if(initialState==0){
					gameObject.SetActive(false);}

	
	}

	// Update is called once per frame
	void Update () {
	
	}
	public void ProcessObject(int newState){
	
			currentState = newState; //update the current state
	}
}
