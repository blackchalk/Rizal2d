using UnityEngine;
using System.Collections;

public class QIact4Part2Scene3 : MonoBehaviour {
	
	private NewAct4Part2 act4part2;
	private NewAct4Part3 act4part3;
	private TuboChecker tubocheck;
	private Store st;

	public GameObject Tubo3pipe5red;
	public GameObject Tubo3pipe6red;

	public GameObject Tubo2pipe4red;
	public GameObject Tubo2pipe4gray;

	public GameObject Tubo3pipe5gray;
	public GameObject Tubo3pipe6gray;

	public GameObject Tubo1pipe7red;
	public GameObject Tubo1pipe7gray;

	public GameObject school;

	public bool enablePart2 =true;
	public bool enablePart3 = false;
	
	public int tubopref1 = 0;
	public int tubopref2 = 0;
	public int tubopref3 = 0;
	
	public bool completeTubo1;
	public bool completeTubo2;
	public bool completeTubo3;
	public bool completeTubo4;
	public bool completeTubo5;
	public bool completeTubo6;
	public bool completeTubo7;

	public int getSt;

	
	void Awake(){
		//act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();




	}
	// Use this for initialization
	void Start () {

		school.SetActive(false);


		
		Tubo3pipe5red.SetActive(false);
		Tubo3pipe6red.SetActive(false);;
		Tubo3pipe5gray.SetActive(false);;
		Tubo3pipe6gray.SetActive(false);;
		
		Tubo2pipe4red.SetActive(false);;
		Tubo2pipe4gray.SetActive(false);;

		Tubo1pipe7red.SetActive(false);;
		Tubo1pipe7gray.SetActive(false);;
		
	}
	void Update(){
		st = GameObject.Find ("Store").GetComponent<Store>();
		getSt = st.indicator1;


		if(getSt == 1){
			enablePart3 = true;
		}

		if(enablePart3 == true){
			if(getSt == 1){
				enablePart2 = false;
				enablePart3 = true;
			}
		}
	}

	void LateUpdate(){


		if(enablePart2){
			act4part2 = GameObject.Find ("Player").GetComponent<NewAct4Part2>();
			if(act4part2.onQuest3){
				school.SetActive(true);
			}

			if(act4part2==null){
				school.SetActive(false);
				return;
			}


		}


		if(enablePart3){
			act4part3 = GameObject.Find ("Player").GetComponent<NewAct4Part3>();
			tubocheck = GameObject.Find ("Player").GetComponent<TuboChecker>();

			completeTubo1 = act4part3.iT1;
			completeTubo2 = act4part3.iT2;
			completeTubo3 =	act4part3.iT3;
			completeTubo4 = act4part3.iT4;
			completeTubo5 = act4part3.iT5;
			completeTubo6 =	act4part3.iT6;
			completeTubo7 = act4part3.iT7; 

			tubopref1 = PlayerPrefs.GetInt("Tubo1");
			tubopref2 = PlayerPrefs.GetInt("Tubo2");
			tubopref3 = PlayerPrefs.GetInt("Tubo3");

			if(tubopref1==1){
				Tubo1pipe7red.SetActive(true);
					if(completeTubo7==true){
						Tubo1pipe7gray.SetActive(true);
						Tubo1pipe7red.SetActive(false);
					}

			}
			if(tubopref2==1){
				Tubo2pipe4red.SetActive(true);
				if(completeTubo4==true){
					Tubo2pipe4gray.SetActive(true);
					Tubo2pipe4red.SetActive(false);
				}
			}
			if(tubopref3==1){
				Tubo3pipe5red.SetActive(true);
				Tubo3pipe6red.SetActive(true);

					if(completeTubo5==true){
						Tubo3pipe5gray.SetActive(true);
						Tubo3pipe5red.SetActive(false);
					}
					if(completeTubo6==true){
						Tubo3pipe6gray.SetActive(true);
						Tubo3pipe6red.SetActive(false);
				}
				
			}
			if(act4part3==null){
				Debug.Log ("act4part3 disabled");
				return;
			}
		}

	}

}