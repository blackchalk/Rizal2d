using UnityEngine;
using System.Collections;

public class NewAct4FinalPart2 : MonoBehaviour {
	
	public AudioClip[] clip;//r array of audiosfx
	public GameObject Fin;
	public GameObject Particle;

	public Object oks;
	public Object resets;

	public Storage storage;

	public GUITexture Love;
	public GUITexture Family;
	public GUITexture Dreams;
	public GUITexture Philippines;
	public GUITexture Sadness;
	public GUITexture Life;
	public GUITexture God;
	public GUITexture Farewell;
	public GUITexture Patriot;
	public GUITexture Hope;

	public GUIText Reset;
	public GUIText OK;
	public GUIText Finish;

	public GUITexture Change;

	public int Total = 0;

	//Correct Answers
	public bool family = false;
	public bool philippines = false;
	public bool farewell = false;
	public bool hope = false;
	public bool patriot = false;

	//Indicator
	public int position = 1;

	public bool disableThis = true;
	public bool disableFinish = false;

	



	void Awake(){
		storage = GameObject.Find ("Storage").GetComponent<Storage> ();
		Fin.SetActive (false);
		Particle.SetActive (false);

			}

	// Use this for initialization
	void Start () {

	}

	void checkAnswers (){
		if(position == 6 || position == 0){
			if(family == true && philippines == true && farewell == true && hope == true && patriot == true){
				//Debug.Log("Correct!");
				releaseFinish();
				audio.PlayOneShot(clip[1]);
			} else {
				//Debug.Log("Wrong!");
			}
		} else {
			//Debug.Log("Please Pick 5 words before pressing OK");
		}
	}

	void releaseFinish(){
		Fin.SetActive (true);
		Particle.SetActive (true);
		Destroy (oks);
		Destroy (resets);
		disableThis = false;
		disableFinish = true;
	}

	void resetAll(){
		position = 1;
		family = false;
		philippines = false;
		farewell = false;
		hope = false;
		patriot = false;

		Love.pixelInset = new Rect (-348, 170, 118, 48);
		Family.pixelInset = new Rect (-348, 95, 118, 48);
		Dreams.pixelInset = new Rect (-348, 30, 118, 48);
		Philippines.pixelInset = new Rect (-348, -45, 118, 48);
		Sadness.pixelInset = new Rect (-348, -115, 118, 48);

		Life.pixelInset = new Rect (-148, 170, 118, 48);
		God.pixelInset = new Rect (-148, 95, 118, 48);
		Farewell.pixelInset = new Rect (-148, 30, 118, 48);
		Patriot.pixelInset = new Rect (-148, -45, 118, 48);
		Hope.pixelInset = new Rect (-148, -135, 118, 78);
	}

	void positionIndicator (){

		if(position == 1){
			Change.pixelInset = new Rect (175, 170, 118, 48);
			position = 2;
		} else if (position == 2){
			Change.pixelInset = new Rect (175, 95, 118, 48);
			position = 3;
		} else if (position == 3){
			Change.pixelInset = new Rect (175, 30, 118, 48);
			position = 4;
		} else if (position == 4){
			Change.pixelInset = new Rect (175, -45, 118, 48);
			position = 5;
		} else if (position == 5){
			Change.pixelInset = new Rect (175, -115, 118, 48);
			position++;
		} else {
			position = 0;
		}

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {
			Touch t = Input.GetTouch (0);
			/*
			if (t.phase == TouchPhase.Began) {
				if (bt.HitTest (t.position, Camera.main)) {

				}
			}
			*/
		}

		if (Input.GetMouseButtonDown (0)) {
			//1st Column
			if (Love.HitTest (Input.mousePosition, Camera.main)) {
				Change = Love.GetComponent<GUITexture>();
				positionIndicator();
				audio.PlayOneShot(clip[2]);
			}

			if (Family.HitTest (Input.mousePosition, Camera.main)) {
				Change = Family.GetComponent<GUITexture>();
				positionIndicator();
				if(position != 0){
				family = true;
					audio.PlayOneShot(clip[2]);
				}
			}

			if (Dreams.HitTest (Input.mousePosition, Camera.main)) {
				Change = Dreams.GetComponent<GUITexture>();
				positionIndicator();
				audio.PlayOneShot(clip[2]);
				
			}

			if (Philippines.HitTest (Input.mousePosition, Camera.main)) {
				Change = Philippines.GetComponent<GUITexture>();
				positionIndicator();
				if(position != 0){
				philippines = true;
					audio.PlayOneShot(clip[2]);
				}
			}

			if (Sadness.HitTest (Input.mousePosition, Camera.main)) {
				Change = Sadness.GetComponent<GUITexture>();
				positionIndicator();
				audio.PlayOneShot(clip[2]);
				
			}

			//2nd Column
			if (Life.HitTest (Input.mousePosition, Camera.main)) {
				Change = Life.GetComponent<GUITexture>();
				positionIndicator();
				audio.PlayOneShot(clip[2]);
				
			}

			if (God.HitTest (Input.mousePosition, Camera.main)) {
				Change = God.GetComponent<GUITexture>();
				positionIndicator();
				audio.PlayOneShot(clip[2]);
				
			}

			if (Farewell.HitTest (Input.mousePosition, Camera.main)) {
				Change = Farewell.GetComponent<GUITexture>();
				positionIndicator();
				if(position != 0){
				farewell = true;
					audio.PlayOneShot(clip[2]);
				}
			}

			if (Patriot.HitTest (Input.mousePosition, Camera.main)) {
				Change = Patriot.GetComponent<GUITexture>();
				positionIndicator();
				if(position != 0){
				patriot = true;
					audio.PlayOneShot(clip[2]);
				}
			}

			if (Hope.HitTest (Input.mousePosition, Camera.main)) {
				Change = Hope.GetComponent<GUITexture>();
				positionIndicator();
				if(position != 0){
				hope = true;
					audio.PlayOneShot(clip[2]);
				}
			}
			if(disableThis){
			if(Reset.HitTest(Input.mousePosition, Camera.main)){
				resetAll();
					audio.PlayOneShot(clip[0]);
			}
			}

			if(disableThis){
			if(OK.HitTest(Input.mousePosition, Camera.main)){
				checkAnswers();
					audio.PlayOneShot(clip[0]);
			}
			}

			if(disableFinish){
			if(Finish.HitTest(Input.mousePosition, Camera.main)){
				//Debug.Log("Change Scene");
				storage.newer = 1;
				Application.LoadLevel("New Act4 Part3 Scene1");
					audio.PlayOneShot(clip[1]);
			}
			}

		}
	}

}
