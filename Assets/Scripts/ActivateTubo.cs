using UnityEngine;
using System.Collections;

public class ActivateTubo : MonoBehaviour {

	private TuboChecker tC;

	public int tUbe1 = 0;
	private int tUbe2;
	private int tUbe3;
	private int tUbe4;
	private int tUbe5;
	private int tUbe6;
	private int tUbe7;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//tC = GameObject.Find ("Player").GetComponent<TuboChecker>();
		//tUbe1 = tC.Tube1;
		if(tUbe1 == 0 && tUbe2 == 0 && tUbe3 == 0 && tUbe4 == 0 && tUbe5 == 0 && tUbe6 == 0 && tUbe7 == 0){
			gameObject.SetActive (false);
		} else if (tUbe1 < 0){
			GameObject.FindWithTag ("1t").SetActive (true);
		}
	}
}
