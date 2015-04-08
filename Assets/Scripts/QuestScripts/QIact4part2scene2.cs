using UnityEngine;
using System.Collections;

public class QIact4part2scene2 : MonoBehaviour {

	private NewAct4Part2 act4part2;
	private NewAct4Part3 act4part3;

	private Store st;

	private TuboChecker tubocheck;

	public bool enablePart2 = true;
	public bool enablePart3 = false;

	public int tubopref1 = 0;
	public int tubopref2 = 0;
	public int tubopref3 = 0;

	private int completeTubo1;
	private int completeTubo2;
	private int completeTubo3;
	private int completeTubo4;
	private int completeTubo5;
	private int completeTubo6;
	private int completeTubo7;

	public int getSt;
	
	void Awake(){
		//act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();
		//act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();

	}
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		st = GameObject.Find("Store").GetComponent<Store>();

		getSt = st.indicator1;

		if(getSt == 1){
			enablePart2 = false;
			enablePart3 = true;
		}
	}
	
	private	void LateUpdate(){//r changed this access modifier to private
		

		
		if(enablePart2 == true){
			act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();

			Debug.Log ("act4part2 enabled");
//			
//			if((act4part2.currentLine6==0)&&(act4part2.onQuest5)){
//				//Debug.Log("onquest4");
//				gameObject.SendMessage("ShowIt",20);
//				gameObject.SendMessage("QuestStatus");}
//			if((act4part2.currentLine6==1)&&(act4part2.onQuest5)){
//				//Debug.Log("2nd");
//				gameObject.SendMessage("ShowIt",18);
//				gameObject.SendMessage("QuestStatus");
//			}
//			if((act4part2.currentLine6==14)&&(act4part2.onQuest5)){
//				//Debug.Log("last");
//				gameObject.SendMessage("ShowIt",20);
//				gameObject.SendMessage("QuestStatus");
//			}
		}
		if(enablePart3 == true){
			act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
			//tubocheck = GameObject.Find ("Player").GetComponent<TuboChecker>();
			Debug.Log ("act4part3 enabled");
//			act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
			tubopref1 = PlayerPrefs.GetInt("Tubo1");
			tubopref2 = PlayerPrefs.GetInt("Tubo2");
			tubopref3 = PlayerPrefs.GetInt("Tubo3");

			completeTubo1 = act4part3.Tub1;
			completeTubo2 = act4part3.Tub2;
			completeTubo3 =	act4part3.Tub3;
			completeTubo4 = act4part3.Tub4;
			completeTubo5 = act4part3.Tub5;
			completeTubo6 =	act4part3.Tub6;
			completeTubo7 = act4part3.Tub7; 
			
			
			tubocheck = GameObject.Find ("Player").GetComponent<TuboChecker>();
			Debug.Log ("tubocheck enabled");
			//if(tubopref1==1||tubopref2==1||tubopref3==1){
//				gameObject.SendMessage("ShowIt",27);
//				gameObject.SendMessage("QuestStatus");
					if(tubopref1==1){
								gameObject.SendMessage("ShowIt",27);
								gameObject.SendMessage("QuestStatus");
					Debug.Log ("Picked tubo"+tubopref1);

								if(completeTubo2==1){
									gameObject.SendMessage("ShowIt",26);
									gameObject.SendMessage("QuestStatus");
									//MakeFalse();
									Debug.Log ("tubo is fixed"+completeTubo2);
								}
//								else {
//	//							if(completeTubo2==0&&completeTubo2!=1){
//									gameObject.SendMessage("ShowIt",27);
//									gameObject.SendMessage("QuestStatus");
//									Debug.Log ("not yet fixed2"+completeTubo2);}
			}


				if(tubopref3==1){
				gameObject.SendMessage("ShowIt",25);
				gameObject.SendMessage("QuestStatus");
					Debug.Log ("Picked tubo"+tubopref3);
					if(completeTubo3==1){
						gameObject.SendMessage("ShowIt",24);
						gameObject.SendMessage("QuestStatus");
						//MakeFalse();
						Debug.Log ("tubo is fixed"+completeTubo3);
					}
					else {
						//							if(completeTubo2==0&&completeTubo2!=1){
						gameObject.SendMessage("ShowIt",25);
						gameObject.SendMessage("QuestStatus");
						Debug.Log ("not yet fixed3"+completeTubo3);}
					
				}
			if(act4part3==null){
				Debug.Log ("null");
				return;
			}
				}
			//			else if(){}
			
			
			
		//}
	}
	public void MakeFalse(){
		enablePart3 = false;
	}
	public void MakeTrue(){
		enablePart3 = true;
	}
}
