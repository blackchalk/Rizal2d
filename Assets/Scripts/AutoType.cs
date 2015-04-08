using UnityEngine;
using System.Collections;
/*AutoType.cs from unifycommunity
 * edited by r
 * a basic autotyping script that prints the msg by letters every frame.
 * EditMade:Tapping once will stop the coroutine and 
 * proceeds with the complete msg, Tapping twice will load to next lvl/scene.(PressLoadLvl.cs)
	 */
public class AutoType : MonoBehaviour { 
	
	public float letterPause = 0.1f;
	public AudioClip sound;
	public AudioClip newTyping;

	private bool stopped=false;

	private string message;

	void Awake(){
		audio.PlayOneShot(newTyping);
	}
	
	// Use this for initialization
	void Start () {
		message = guiText.text;
		guiText.text = "";
		StartCoroutine("TypeText");
			}
	void Update(){
		if(Input.touchCount>0)
		{
			{
				Touch t = Input.GetTouch(0);
				
				if (t.phase == TouchPhase.Began)
				{
					stopped = true;
					guiText.text=message;
					StopCoroutine("TypeText");
				}
			}
		}
		if(stopped)
		{

			message = guiText.text;
			audio.Stop();
		}
	}
	
public IEnumerator TypeText () {

		foreach (char letter in message.ToCharArray()) {
			guiText.text += letter;
			if (sound)

				audio.PlayOneShot (sound);
			yield return 0;
			yield return new WaitForSeconds (letterPause);
			}

	}
}


