using UnityEngine;
using System.Collections;

public class CreditsManager : MonoBehaviour {

	public float fadeSpeed;          // Speed that the screen fades to and from black.
	
	public bool fadeInNow = true;
	
	public bool next;
	public bool prev;
	
	public bool disableNext;
	public bool disablePrev;
	
	public GameObject R;
	public GameObject L;
	
	public Color myColor1tt;
	public Color myColor2tt;
	public Color myColor3tt;
	public Color myColor4tt;
	public Color myColor5tt;
	public Color myColor6tt;
	
	private Color transparent;
	
	float ratio;
	
	public GUITexture Next;
	public GUITexture Previous;

	public GUITexture Exitxz;
	
	public GUIText reference1text;
	public GUIText reference2text;
	public GUIText reference3text;
	public GUIText reference4text;
	public GUIText reference5text;
	public GUIText reference6text;
	
	public int pageNumber;
	public int lastPageNumber;
	
	void Awake(){
		
		transparent = new Color (0, 0, 0, 0);
		
		//changing all to transparent // this shit is killing me.
		reference1text.color = transparent;
		reference2text.color = transparent;
		reference3text.color = transparent;
		reference4text.color = transparent;
		reference5text.color = transparent;
		reference6text.color = transparent;

	}
	
	void Update () {
		
		//ratio = fadeSpeed * Time.deltaTime;
		
		fadeInPages();
		fadeOutPages();
		
		showHideButton ();
		
		if (Input.GetMouseButtonDown (0)) {
			if(disableNext == false){
				if (Next.HitTest (Input.mousePosition, Camera.main)) {
					pageNumber++;
					lastPageNumber = pageNumber - 1;
					Debug.Log("Next");
					
					next = true;
					prev = false;
					
					disableNext = true;
					disablePrev = true;
					
					StartCoroutine (activateButton(1.5f));
				}
			}
			
			if(disablePrev == false){
				if(Previous.HitTest (Input.mousePosition, Camera.main)){
					pageNumber--;
					lastPageNumber = pageNumber + 1;
					Debug.Log("Prev");
					
					prev = true;
					next = false;
					
					disableNext = true;
					disablePrev = true;
					
					StartCoroutine (activateButton(1.5f));
				}
			}

			if(Exitxz.HitTest (Input.mousePosition, Camera.main)){
				Application.LoadLevel("MainInterfaceVersionAug22");
			}
		}
	}
	
	void showHideButton (){
		if (pageNumber == 2) {
			R.SetActive(true);
			L.SetActive(true);
		}
		
		if (pageNumber == 1){
			R.SetActive(true);
			L.SetActive(false);
		}
		
		if (pageNumber == 3){
			R.SetActive(false);
			L.SetActive(true);
		}
	}
	
	void fadeInPages(){

		if(next){
			if(pageNumber == 1){
				myColor1tt = Color.Lerp (reference1text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference1text.color = myColor1tt;
				
				myColor2tt = Color.Lerp (reference2text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference2text.color = myColor2tt;
			}

			if(pageNumber == 2){
				myColor3tt = Color.Lerp (reference3text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference3text.color = myColor3tt;
				
				myColor4tt = Color.Lerp (reference4text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference4text.color = myColor4tt;
			}

			if(pageNumber == 3){
				myColor5tt = Color.Lerp (reference5text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference5text.color = myColor5tt;
				
				myColor6tt = Color.Lerp (reference6text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference6text.color = myColor6tt;
			}
		}

		if(prev){
			if(pageNumber == 1){
				myColor1tt = Color.Lerp (reference1text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference1text.color = myColor1tt;
				
				myColor2tt = Color.Lerp (reference2text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference2text.color = myColor2tt;
			}

			if(pageNumber == 2){
				myColor3tt = Color.Lerp (reference3text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference3text.color = myColor3tt;
				
				myColor4tt = Color.Lerp (reference4text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference4text.color = myColor4tt;
			}

			if(pageNumber == 3){
				myColor5tt = Color.Lerp (reference5text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference5text.color = myColor5tt;
				
				myColor6tt = Color.Lerp (reference6text.color, Color.black, fadeSpeed * Time.deltaTime);
				reference6text.color = myColor6tt;
			}
		}
	}
	
	void fadeOutPages(){
		if(next){
			if(lastPageNumber == 1){
				myColor1tt = Color.Lerp (reference1text.color, Color.clear, fadeSpeed * Time.deltaTime);
				reference1text.color = myColor1tt;

				myColor2tt = Color.Lerp (reference2text.color, Color.clear, fadeSpeed * Time.deltaTime);
				reference2text.color = myColor2tt;
			}

			if(lastPageNumber == 2){
				myColor3tt = Color.Lerp (reference3text.color, Color.clear, fadeSpeed * Time.deltaTime);
				reference3text.color = myColor3tt;
				
				myColor4tt = Color.Lerp (reference4text.color, Color.clear, fadeSpeed * Time.deltaTime);
				reference4text.color = myColor4tt;
			}
		}
		
		if(prev){
			if(lastPageNumber == 2){
				myColor3tt = Color.Lerp (reference3text.color, Color.clear, fadeSpeed * Time.deltaTime);
				reference3text.color = myColor3tt;

				myColor4tt = Color.Lerp (reference4text.color, Color.clear, fadeSpeed * Time.deltaTime);
				reference4text.color = myColor4tt;
			}

			if(lastPageNumber == 3){
				myColor5tt = Color.Lerp (reference5text.color, Color.clear, fadeSpeed * Time.deltaTime);
				reference5text.color = myColor5tt;
				
				myColor6tt = Color.Lerp (reference6text.color, Color.clear, fadeSpeed * Time.deltaTime);
				reference6text.color = myColor6tt;
			}
		}
	}
	
	IEnumerator activateButton(float delay)
	{
		yield return new WaitForSeconds(delay);
		if (pageNumber == 2) {
			disableNext = false;
			disablePrev = false;
		}
		
		if (pageNumber == 1){
			disablePrev = true;
			disableNext = false;
		}
		
		if (pageNumber == 3){
			disableNext = true;
			disablePrev = false;
		}
	}

}
