using UnityEngine;
using System.Collections;

public class GalleryManager : MonoBehaviour {
	
	public float fadeSpeed;          // Speed that the screen fades to and from black.
	
	public bool fadeInNow = true;
	
	public bool next;
	public bool prev;
	
	public bool disableNext;
	public bool disablePrev;
	
	public GameObject R;
	public GameObject L;
	
	public Color myColor1;
	public Color myColor2;
	public Color myColor3;
	public Color myColor4;

	public Color myColor1t;
	public Color myColor2t;
	public Color myColor3t;
	public Color myColor4t;
	
	private Color transparent;
	
	float ratio;
	
	public GUITexture Next;
	public GUITexture Previous;
	
	public GUIText Trivia1text;
	public GUITexture Trivia1texture;
	
	public GUIText Trivia2text;
	public GUITexture Trivia2texture;
	
	public GUIText Trivia3text;
	public GUITexture Trivia3texture;
	
	public GUIText Trivia4text;
	public GUITexture Trivia4texture;

	public GUITexture exits;

	public GUIText Locked1;
	public GUIText Locked2;
	public GUIText Locked3;
	public GUIText Locked4;
	
	public int pageNumber;
	public int lastPageNumber;

	public int unlocked1;
	public int unlocked2;
	public int unlocked3;
	public int unlocked4;
	
	void Awake(){

//		unlocked1 = PlayerPrefs.GetInt ("unlocked1");
		unlocked2 = PlayerPrefs.GetInt ("Set2");
		unlocked3 = PlayerPrefs.GetInt ("Set3");
		unlocked4 = PlayerPrefs.GetInt ("Set4");

		transparent = new Color (0, 0, 0, 0);
		
		//changing all to transparent // this shit is killing me.
		Trivia1text.color = transparent;
		Trivia1texture.color = Color.clear;
		
		Trivia2text.color = transparent;
		Trivia2texture.color = Color.clear;
		
		Trivia3text.color = transparent;
		Trivia3texture.color = Color.clear;
		
		Trivia4text.color = transparent;
		Trivia4texture.color = Color.clear;

		Locked1.color = transparent;
		Locked2.color = transparent;
		Locked3.color = transparent;
		Locked4.color = transparent;


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
					//Debug.Log("Next");
					
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
					//Debug.Log("Prev");
					
					prev = true;
					next = false;
					
					disableNext = true;
					disablePrev = true;
					
					StartCoroutine (activateButton(1.5f));
				}
			}

			if(exits.HitTest(Input.mousePosition, Camera.main)){
				Application.LoadLevel("MainInterfaceVersionAug22");
			}
		}
	}
	
	void showHideButton (){
		if (pageNumber >= 2 && pageNumber <= 3) {
			R.SetActive(true);
			L.SetActive(true);
		}
		
		if (pageNumber == 1){
			R.SetActive(true);
			L.SetActive(false);
		}
		
		if (pageNumber == 4){
			R.SetActive(false);
			L.SetActive(true);
		}
	}
	
	void fadeInPages(){
		if(next){
			if(unlocked1 == 0){
				if(pageNumber == 1){
					myColor1t = Color.Lerp (Locked1.color, Color.black, fadeSpeed * Time.deltaTime);
					Locked1.color = myColor1t;
				}
			}

			if(unlocked2 == 0){
				if(pageNumber == 2){
					myColor2t = Color.Lerp (Locked2.color, Color.black, fadeSpeed * Time.deltaTime);
					Locked2.color = myColor2t;
				}
			}

			if(unlocked3 == 0){
				if(pageNumber == 3){
					myColor3t = Color.Lerp (Locked3.color, Color.black, fadeSpeed * Time.deltaTime);
					Locked3.color = myColor3t;
				}
			}

			if(unlocked4 == 0){
				if(pageNumber == 4){
					myColor4t = Color.Lerp (Locked4.color, Color.black, fadeSpeed * Time.deltaTime);
					Locked4.color = myColor4t;
				}
			}

			if(unlocked1 == 1){
			if(pageNumber == 1){
				myColor1 = Color.Lerp (Trivia1text.color, Color.black, fadeSpeed * Time.deltaTime);
				Trivia1texture.color = Color.Lerp (Trivia1texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Trivia1text.color = myColor1;
			}
			}

			if(unlocked2 == 1){
			if(pageNumber == 2){
				myColor2 = Color.Lerp (Trivia2text.color, Color.black, fadeSpeed * Time.deltaTime);
				Trivia2texture.color = Color.Lerp (Trivia2texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Trivia2text.color = myColor2;
			}
			}

			if(unlocked3 == 1){
			if(pageNumber == 3){
				myColor3 = Color.Lerp (Trivia3text.color, Color.black, fadeSpeed * Time.deltaTime);
				Trivia3texture.color = Color.Lerp (Trivia3texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Trivia3text.color = myColor3;
			}
			}

			if(unlocked4 == 1){
			if(pageNumber == 4){
				myColor4 = Color.Lerp (Trivia4text.color, Color.black, fadeSpeed * Time.deltaTime);
				Trivia4texture.color = Color.Lerp (Trivia4texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Trivia4text.color = myColor4;
			}
			}

		}
		
		if(prev){

			if(unlocked1 == 0){
				if(pageNumber == 1){
					myColor1t = Color.Lerp (Locked1.color, Color.black, fadeSpeed * Time.deltaTime);
					Locked1.color = myColor1t;
				}
			}
			
			if(unlocked2 == 0){
				if(pageNumber == 2){
					myColor2t = Color.Lerp (Locked2.color, Color.black, fadeSpeed * Time.deltaTime);
					Locked2.color = myColor2t;
				}
			}
			
			if(unlocked3 == 0){
				if(pageNumber == 3){
					myColor3t = Color.Lerp (Locked3.color, Color.black, fadeSpeed * Time.deltaTime);
					Locked3.color = myColor3t;
				}
			}
			
			if(unlocked4 == 0){
				if(pageNumber == 4){
					myColor4t = Color.Lerp (Locked4.color, Color.black, fadeSpeed * Time.deltaTime);
					Locked4.color = myColor4t;
				}
			}

			if(unlocked1 == 1){
			if(pageNumber == 1){
				myColor1 = Color.Lerp (Trivia1text.color, Color.black, fadeSpeed * Time.deltaTime);
				Trivia1texture.color = Color.Lerp (Trivia1texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Trivia1text.color = myColor1;
			}
			}

			if(unlocked2 == 1){
			if(pageNumber == 2){
				myColor2 = Color.Lerp (Trivia2text.color, Color.black, fadeSpeed * Time.deltaTime);
				Trivia2texture.color = Color.Lerp (Trivia2texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Trivia2text.color = myColor2;
			}
			}

			if(unlocked3 == 1){
			if(pageNumber == 3){
				myColor3 = Color.Lerp (Trivia3text.color, Color.black, fadeSpeed * Time.deltaTime);
				Trivia3texture.color = Color.Lerp (Trivia3texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Trivia3text.color = myColor3;
			}
			}

			if(unlocked4 == 1){
			if(pageNumber == 4){
				myColor4 = Color.Lerp (Trivia4text.color, Color.black, fadeSpeed * Time.deltaTime);
				Trivia4texture.color = Color.Lerp (Trivia4texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Trivia4text.color = myColor4;
			}
			}
		}
	}
	
	void fadeOutPages(){
		if(next){

			if(unlocked1 == 0){
				if(lastPageNumber == 1){
					myColor1t = Color.Lerp (Locked1.color, Color.clear, fadeSpeed * Time.deltaTime);
					Locked1.color = myColor1t;
				}
			}

			if(unlocked2 == 0){
				if(lastPageNumber == 2){
					myColor2t = Color.Lerp (Locked2.color, Color.clear, fadeSpeed * Time.deltaTime);
					Locked2.color = myColor2t;
				}
			}

			if(unlocked3 == 0){
				if(lastPageNumber == 3){
					myColor3t = Color.Lerp (Locked3.color, Color.clear, fadeSpeed * Time.deltaTime);
					Locked3.color = myColor3t;
				}
			}

			if(unlocked4 == 0){
				if(lastPageNumber == 4){
					myColor4t = Color.Lerp (Locked4.color, Color.clear, fadeSpeed * Time.deltaTime);
					Locked4.color = myColor4t;
				}
			}

			if(unlocked1 == 1){
			if(lastPageNumber == 1){
				myColor1 = Color.Lerp (Trivia1text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia1texture.color = Color.Lerp (Trivia1texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia1text.color = myColor1;
			}
			}

			if(unlocked2 == 1){
			if(lastPageNumber == 2){
				myColor2 = Color.Lerp (Trivia2text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia2texture.color = Color.Lerp (Trivia2texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia2text.color = myColor2;
			}
			}

			if(unlocked3 == 1){
			if(lastPageNumber == 3){
				myColor3 = Color.Lerp (Trivia3text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia3texture.color = Color.Lerp (Trivia3texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia3text.color = myColor3;
			}
			}

			if(unlocked4 == 1){
			if(lastPageNumber == 4){
				myColor4 = Color.Lerp (Trivia4text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia4texture.color = Color.Lerp (Trivia4texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia4text.color = myColor4;
			}
			}
			
		}
		
		if(prev){
			
			if(unlocked2 == 0){
				if(lastPageNumber == 2){
					myColor2t = Color.Lerp (Locked2.color, Color.clear, fadeSpeed * Time.deltaTime);
					Locked2.color = myColor2t;
				}
			}
			
			if(unlocked3 == 0){
				if(lastPageNumber == 3){
					myColor3t = Color.Lerp (Locked3.color, Color.clear, fadeSpeed * Time.deltaTime);
					Locked3.color = myColor3t;
				}
			}
			
			if(unlocked4 == 0){
				if(lastPageNumber == 4){
					myColor4t = Color.Lerp (Locked4.color, Color.clear, fadeSpeed * Time.deltaTime);
					Locked4.color = myColor4t;
				}
			}

			if(unlocked1 == 1){
			if(lastPageNumber == 2){
				myColor2 = Color.Lerp (Trivia2text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia2texture.color = Color.Lerp (Trivia2texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia2text.color = myColor2;
			}
			}

			if(unlocked2 == 1){
			if(lastPageNumber == 3){
				myColor3 = Color.Lerp (Trivia3text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia3texture.color = Color.Lerp (Trivia3texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia3text.color = myColor3;
			}
			}

			if(unlocked3 == 1){
			if(lastPageNumber == 4){
				myColor4 = Color.Lerp (Trivia4text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia4texture.color = Color.Lerp (Trivia4texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Trivia4text.color = myColor4;
			}
			}

		}
	}
	
	IEnumerator activateButton(float delay)
	{
		yield return new WaitForSeconds(delay);
		if (pageNumber >= 2 && pageNumber <= 9) {
			disableNext = false;
			disablePrev = false;
		}
		
		if (pageNumber == 1){
			disablePrev = true;
			disableNext = false;
		}
		
		if (pageNumber == 10){
			disableNext = true;
			disablePrev = false;
		}
	}
	
}
