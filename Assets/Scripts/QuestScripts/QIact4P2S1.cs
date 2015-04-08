using UnityEngine;
using System.Collections;

public class QIact4P2S1 : MonoBehaviour {
	private NewAct4Part2 act4part2;
	private NewAct4Part3 act4part3;
	private TuboChecker tubocheck;
	
	public bool enablePart2 = true;
	public bool enablePart3 = false;

	public int tubopref1 = 0;
	public int tubopref2 = 0;
	public int tubopref3 = 0;
	
	private int completeTubo1;
	private int completeTubo2;
	private int completeTubo3;
	
	void Awake(){
		act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();
		act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
		tubocheck = GameObject.Find ("Player").GetComponent<TuboChecker>();
	}
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}
	
	private	void LateUpdate(){//r changed this access modifier to private
		
		if(act4part3.GetComponent<NewAct4Part3>().enabled == true){
			enablePart2 = false;
			enablePart3 = true;
		}
		
				if(enablePart2){
					act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();
					Debug.Log ("act4part2 enabled");
					
					if((act4part2.currentLine6==0)&&(act4part2.onQuest5)){
						//Debug.Log("onquest4");
						gameObject.SendMessage("ShowIt",20);
						gameObject.SendMessage("QuestStatus");}
					if((act4part2.currentLine6==1)&&(act4part2.onQuest5)){
						//Debug.Log("2nd");
						gameObject.SendMessage("ShowIt",18);
						gameObject.SendMessage("QuestStatus");
					}
					if((act4part2.currentLine6==14)&&(act4part2.onQuest5)){
						//Debug.Log("last");
						gameObject.SendMessage("ShowIt",20);
						gameObject.SendMessage("QuestStatus");
					}
				if(enablePart2==null)
				return;

		
				}
		if(enablePart3){
			act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
			tubopref1 = PlayerPrefs.GetInt("Tubo1");
			tubopref2 = PlayerPrefs.GetInt("Tubo2");
			tubopref3 = PlayerPrefs.GetInt("Tubo3");
			
			completeTubo1 = act4part3.Tub1;
			completeTubo2 = act4part3.Tub1;
			completeTubo3 =	act4part3.Tub1;
			
			
			tubocheck = GameObject.Find ("Player").GetComponent<TuboChecker>();
			Debug.Log ("tubocheck enabled");
//			if(tubopref1==1||tubopref2==1||tubopref3==1){
//				gameObject.SendMessage("ShowIt",29);
//				gameObject.SendMessage("QuestStatus");
				if(tubopref1==1){
					//Debug.Log("onquest4");
					gameObject.SendMessage("ShowIt",29);
					gameObject.SendMessage("QuestStatus");
						if(completeTubo1==1){
							gameObject.SendMessage("ShowIt",28);
							gameObject.SendMessage("QuestStatus");
							//MakeFalse();
						}
					
				}
			if(tubopref2==1||tubopref3==1){
				gameObject.SendMessage("ShowIt",1);
				gameObject.SendMessage("QuestStatus");
			}
			//}
		}
	}
	public void MakeFalse(){
		enablePart3 = false;
	}
	public void MakeTrue(){
		enablePart3 = true;
	}
}