using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))] //requires the script to have an audiosource into its gameobject-raygon
/*
 * Scene Name 		| 	clipMusic
 * --------------------------------------
 * Act1Scene1Remake			die lorelei
 * Act1scene2				beautiful morning
 * bangka graphic			HOMESICKNESS
 * ACT2loob					Heart Softening
 * ACT3part1				LighHalzen
 * Act3part2				Theme of Narci
 * AFTERMATH				Massacre
 * Act4part1HULE			Tension
 * Title PROLOGUE EPILOGUE	Reminiscence
 * nakakulongAct4			days of past
 * portrait end	binaril		Sorrow
 * bbarilin animation		Tension
 * DAPITAN					Imprisoned Town
 * 
 * 
 * End Credits				Results

 */

public class BGMusic : MonoBehaviour {

	public AudioClip[] clips;
	public int startingClip = 0;
	public int currentClip;
	public int nextClip;
	private bool isFadingOut=false;
	private float fadeOutTime = 1.0f;//
	private bool isFadingIn=false;//
	private float fadeInTime=1.0f;//
	private bool waitSequence = true;
	private bool keepTime = false;//
	private float targetVolume=1.0f;
	private float oldVolume=0.0f;//
	private float fadeOutStart=0.0f;//
	private float fadeInStart=0.0f;//
	
	// Use this for initialization
	void Start () {
		audio.clip = clips[startingClip];
		audio.Play();
		currentClip=startingClip;
	}
	
	// Update is called once per frame
	void Update () {


		if(isFadingOut){ //use for fadeinout
			if(audio.volume>0){
				float elapsOut=Time.time-fadeOutStart;
				float indOut=elapsOut/fadeOutTime;
				audio.volume=oldVolume-(indOut*oldVolume);
			}
		}else{
			isFadingOut = false;
			PlayMusic();
			StartCoroutine(PlayMusic());
		}
		if(isFadingIn){
			if(audio.volume<targetVolume){
				float elapsIn=Time.time-fadeInStart;
				float indIn=elapsIn/fadeInTime;
				audio.volume=indIn;
			}else{
				audio.volume=targetVolume;
				isFadingIn=false;
			}
		}
	}
	public void ChangeMusic(int newClip,bool waitMusicToEnd,bool keepPreviousTime,float trackVolume,float fadein,float fadeOutPrevious)
	{ //sets the track number and if waits to end before playing next song -r
		nextClip = newClip;
		waitSequence = waitMusicToEnd;
		keepTime=keepPreviousTime;
		fadeInTime=fadein;
		if(newClip!=currentClip){
			currentClip=newClip;
			StartCoroutine(PlayMusic());
			if(fadeOutPrevious!=0){
				oldVolume=audio.volume;
				fadeOutStart=Time.time;
				fadeOutTime=fadeOutPrevious;
				isFadingOut=true;
			}
			else{
				StartCoroutine(PlayMusic());
			}
		}
	}
	IEnumerator PlayMusic(){ //plays music
		if(waitSequence)
			yield return new WaitForSeconds(audio.clip.length-(float)(audio.timeSamples/(float)audio.clip.frequency));//waits for the current track to finish before playing
		if(fadeInTime!=0){
			audio.volume=0;
			fadeInStart=Time.time;
			isFadingIn=true;
			}
		float StartingPoint=0.0f;
		if(keepTime){
			StartingPoint=audio.timeSamples;
		audio.clip = clips[nextClip];
		audio.timeSamples=Mathf.RoundToInt(StartingPoint);
		audio.Play ();
//			Debug.Log (""+clips[nextClip]);
		}
	}
}
