using UnityEngine;
using System.Collections;

public class TuboChecker : MonoBehaviour {

	private NewAct4Part3 identify;

	public bool T1 = false;
	public bool T2 = false;
	public bool T3 = false;
	public bool T4 = false;
	public bool T5 = false;
	public bool T6 = false;
	public bool T7 = false;
	//private bool T1a = false;

	public int Tubo1 = 0;
	public int Tubo2 = 0;
	public int Tubo3 = 0;

	private int A = 0;
	private int B = 0;
	private int C = 0;
	private int D = 0;
	private int E = 0;
	private int F = 0;
	private int G = 0;
	
	public bool start = false;

	//tickermessage
	private TickerMessage tickerMsg; //r
	private QuestUnlocked newQuest;

	// Use this for initialization

	void Awake(){
		identify = GameObject.Find("Player").GetComponent<NewAct4Part3>();
		tickerMsg = GameObject.Find("DisplayTicker").GetComponent<TickerMessage>(); //r
		newQuest = GameObject.Find ("GUIQUnlock").GetComponent<QuestUnlocked>();
	}

	// Update is called once per frame
	void Update () {
		tChecker ();
	
	}

	public void check(){
		start = true;
	}

	public void checkStop(){
		start = false;
	}

	void tChecker(){

		if(start){

			Tubo1 = PlayerPrefs.GetInt ("Tubo1");
			Tubo2 = PlayerPrefs.GetInt ("Tubo2");
			Tubo3 = PlayerPrefs.GetInt ("Tubo3");

			if(Tubo1 == 1){
				//TuboCounter(3);
				T1 = identify.t1;
				T2 = identify.t2;
				T7 = identify.t7;
				if(T1 == true){
					if(identify.iT1 == true){
						PlayerPrefs.SetInt ("A", 1);
						checkStop();
						identify.t1 = false;
						A = 1;

						PlayerPrefs.SetInt ("Tube1", 1);
						newQuest.displayEnd("Success!");
						identify.audio.PlayOneShot(identify.clip[1]);
						//////bbbbbbb
					}
				}

				if (T2 == true){
					if(identify.iT2 == true){
						PlayerPrefs.SetInt ("B", 1);
						checkStop();
						identify.t2 = false;
						B = 1;
						PlayerPrefs.SetInt ("Tube2", 1);
						newQuest.displayEnd("Success!");
						identify.audio.PlayOneShot(identify.clip[1]);
					}
				}

				if (T7 == true){
					if(identify.iT7 == true){
						PlayerPrefs.SetInt ("G", 1);
						checkStop();
						identify.t7 = false;
						G = 1;
						PlayerPrefs.SetInt ("Tube7", 1);
						newQuest.displayEnd("Success!");
						identify.audio.PlayOneShot(identify.clip[1]);
					} 
				}

				if(T1 == false && T2 == false && T7 == false){
					//d2
					checkStop();
					newQuest.displayEnd("It doesn't match!");
					identify.audio.PlayOneShot(identify.clip[2]);
//					Debug.Log ("Wrongs7!");
				}

			} else {

				if(A == 0){
					identify.iT1 = false;

				}

				if(B == 0){
					identify.iT2 = false;
				}

				if(G == 0){
					identify.iT7 = false;
				}
			} 

			if (Tubo2 == 1){
//				TuboCounter(1);
				T4 = identify.t4;
				if(T4 == true){
					if(identify.iT4 == true){
						PlayerPrefs.SetInt ("D", 1);
						checkStop();
						identify.t4 = false;
						D = 1;
						PlayerPrefs.SetInt ("Tube4", 1);
						newQuest.displayEnd("Success!");
						identify.audio.PlayOneShot(identify.clip[1]);
					} 
				}

				if(T4 == false){
					//d2
					//Debug.Log ("Wrongs4!");
					newQuest.displayEnd("It doesn't match!");
					identify.audio.PlayOneShot(identify.clip[2]);
					checkStop();

				}

			} else {
				if(D == 0){
					identify.t4 = false;
				}
			} 

			if (Tubo3 == 1){
//				TuboCounter(3);
				T3 = identify.t3;
				T5 = identify.t5;
				T6 = identify.t6;
				if(T3 == true){
					if(identify.iT3 == true){
						PlayerPrefs.SetInt ("C", 1);
						checkStop();
						identify.t3 = false;
						C = 1;
						PlayerPrefs.SetInt("Tube3", 1);
						newQuest.displayEnd("Success!");
						identify.audio.PlayOneShot(identify.clip[1]);
					} 
				}

				if(T5 == true){
					if(identify.iT5 == true){
						PlayerPrefs.SetInt ("E", 1);
						checkStop();
						identify.t5 = false;
						E = 1;
						PlayerPrefs.SetInt("Tube5", 1);
						newQuest.displayEnd("Success!");
						identify.audio.PlayOneShot(identify.clip[1]);
					}
				}

				if(T6 == true){
					if(identify.iT6 == true){
						PlayerPrefs.SetInt ("F", 1);
						checkStop();
						identify.t6 = false;
						F = 1;
						PlayerPrefs.SetInt("Tube6", 1);
						newQuest.displayEnd("Success!");
						identify.audio.PlayOneShot(identify.clip[1]);
					}
				}

				if(T3 == false && T5 == false && T6 == false){
					//d2
					//Debug.Log ("Wrongs6!");
					newQuest.displayEnd("It doesn't match!");
					identify.audio.PlayOneShot(identify.clip[2]);
					checkStop();
				}

			} else {
				if(C == 0){
					identify.iT3 = false;
				}

				if(E == 0){
					identify.iT5 = false;
				}

				if(F == 0){
					identify.iT6 = false;
				}
			}

		}
	}
	void changeGUITexture(bool toBeDisplayed,string label)//r changes the quest holder
	{
		GameObject.Find("GUITexture_"+label).guiTexture.enabled = toBeDisplayed;
	}
//	public void TuboCounter(int numMatches)
//	{
//		numMatches--;
//		if(A==1||B==1||G==1){
//			numMatches--;}
//		if(D==1){
//			numMatches--;
//		}
//		if(C==1||E==1||F==1){
//			numMatches--;}
//
//		tickerMsg.displayStart("FIND tubes\nthat MATCH\nyour PIPE\nor CHOOSE\nagain at\nthe Warehouse");
//		//newQuest.displayEnd("Good Job! You still have "+numMatches+" pipe/s to fix");
//
//	}

}
