using UnityEngine;
using System.Collections;

public class TriggerMusic : MonoBehaviour {

	public bool waitForSequence=false;
	public bool keepTimeAndVolume=false;
	public float trackVolume;
	public float fadeIn;
	public float fadeOutPrevious;
	public int clip;
	public string playInScene;
	private BGMusic bgmusic;

	void Awake(){
		bgmusic=this.gameObject.GetComponent<BGMusic>();

		}
	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {

		playInScene=Application.loadedLevelName;
		if((playInScene=="Act1S1Title")||(playInScene=="Act1S2TitleRygn")||(playInScene=="Act2TitleRygn")
		   ||(playInScene=="Act3Title")||(playInScene=="Act3PART2TITLE")||(playInScene=="Act4PART1TITLE")||
		   (playInScene=="Act4PART3TITLE")||(playInScene=="MothDied")||(playInScene=="PrologueAct4part1")){
				clip=11;
				bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
				}
		if(playInScene=="Act 1 Scene 1 Remake"){
			clip=10;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="Act 1 Scene 2MONO"){
			clip=2;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="Act 1 Scene 3A"){
			clip=13;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="New Act 2"){
			clip=3;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="New Act 3 Scene 1"){
			clip=12;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="New Act4 Part2 Scene4 room1"){
			clip=6;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="New Act3 PArt2 Scene 1"){
			clip=1;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="New Act4 Part3 Scene3"){
			clip=7;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="New Act4 Part3 Scene1"){
			clip=5;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="New Act4 Part1 Scene1"){
			clip=4;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
			}
		if(playInScene=="THE END"){
			clip=9;
			bgmusic.ChangeMusic(clip,waitForSequence,keepTimeAndVolume,trackVolume,fadeIn,fadeOutPrevious);
		}
	}
}
 /* Scene Name 		| 	clipMusic
 * --------------------------------------
 * MainInterface			New Dawn#
 * Act1Scene1Remake			die lorelei#
 * Act1scene2				beautiful morning#
 * bangka graphic			HOMESICKNESS#
 * ACT2loob					Heart Softening#
 * ACT3part1				LighHalzen#
 * Act3part2				Theme of Narci#
 * AFTERMATH				Massacre#
 * Act4part1HULE			Tension#
 * Title/PROLOGUE/EPILOGUE	Reminiscence#
 * nakakulongAct4			days of past#
 * Portrait Exec Scene		Sorrow#
 * Execution animation		Tension#
 * DAPITAN					Imprisoned Town#
 * 
 * End Credit				Results
 */

