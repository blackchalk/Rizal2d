using UnityEngine;
using System.Collections;

public class FadeManager : MonoBehaviour {

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
	public Color myColor5;
	public Color myColor6;
	public Color myColor7;
	public Color myColor8;
	public Color myColor9;
	public Color myColor10;

	private Color transparent;

	float ratio;

	public GUITexture Next;
	public GUITexture Previous;
	public GUITexture MainMenu;

	public GUIText Instruction1text;
	public GUITexture Instruction1texture;

	public GUIText Instruction2text;
	public GUITexture Instruction2texture;

	public GUIText Instruction3text;
	public GUITexture Instruction3texture;

	public GUIText Instruction4text;
	public GUITexture Instruction4texture;

	public GUIText Instruction5text;
	public GUITexture Instruction5texture;

	public GUIText Instruction6text;
	public GUITexture Instruction6texture;

	public GUIText Instruction7text;
	public GUITexture Instruction7texture;

	public GUIText Instruction8text;
	public GUITexture Instruction8atexture;
	public GUITexture Instruction8btexture;
	public GUITexture Instruction8ctexture;

	public GUIText Instruction9text;
	public GUITexture Instruction9texture;

	public GUIText Instruction10text;
	public GUITexture Instruction10texture;

	public int pageNumber;
	public int lastPageNumber;

	public GUITexture windowFrame;

	void Start () {

	}

	void Awake(){

		transparent = new Color (0, 0, 0, 0);

		//changing all to transparent // this shit is killing me.
		Instruction1text.color = transparent;
		Instruction1texture.color = Color.clear;

		Instruction2text.color = transparent;
		Instruction2texture.color = Color.clear;

		Instruction3text.color = transparent;
		Instruction3texture.color = Color.clear;

		Instruction4text.color = transparent;
		Instruction4texture.color = Color.clear;

		Instruction5text.color = transparent;
		Instruction5texture.color = Color.clear;

		Instruction6text.color = transparent;
		Instruction6texture.color = Color.clear;

		Instruction7text.color = transparent;
		Instruction7texture.color = Color.clear;

		Instruction8text.color = transparent;
		Instruction8atexture.color = Color.clear;
		Instruction8btexture.color = Color.clear;
		Instruction8ctexture.color = Color.clear;

		Instruction9text.color = transparent;
		Instruction9texture.color = Color.clear;

		Instruction10text.color = transparent;
		Instruction10texture.color = Color.clear;
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
					////debug.Log("Next");

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
					//debug.Log("Prev");

					prev = true;
					next = false;

					disableNext = true;
					disablePrev = true;

					StartCoroutine (activateButton(1.5f));
				}
			}

			if(MainMenu.HitTest (Input.mousePosition, Camera.main)){
				Application.LoadLevel("MainInterfaceVersionAug22");
			}
		}
	}

	void showHideButton (){
		if (pageNumber >= 2 && pageNumber <= 9) {
			R.SetActive(true);
			L.SetActive(true);
		}
		
		if (pageNumber == 1){
			R.SetActive(true);
			L.SetActive(false);
		}
		
		if (pageNumber == 10){
			R.SetActive(false);
			L.SetActive(true);
		}
	}

	void fadeInPages(){
		if(next){
			if(pageNumber == 1){
				myColor1 = Color.Lerp (Instruction1text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction1texture.color = Color.Lerp (Instruction1texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction1text.color = myColor1;
			}

			if(pageNumber == 2){
				myColor2 = Color.Lerp (Instruction2text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction2texture.color = Color.Lerp (Instruction2texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction2text.color = myColor2;
			}

			if(pageNumber == 3){
				myColor3 = Color.Lerp (Instruction3text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction3texture.color = Color.Lerp (Instruction3texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction3text.color = myColor3;
			}

			if(pageNumber == 4){
				myColor4 = Color.Lerp (Instruction4text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction4texture.color = Color.Lerp (Instruction4texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction4text.color = myColor4;
			}

			if(pageNumber == 5){
				myColor5 = Color.Lerp (Instruction5text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction5texture.color = Color.Lerp (Instruction5texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction5text.color = myColor5;
			}

			if(pageNumber == 6){
				myColor6 = Color.Lerp (Instruction6text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction6texture.color = Color.Lerp (Instruction6texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction6text.color = myColor6;
			}

			if(pageNumber == 7){
				myColor7 = Color.Lerp (Instruction7text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction7texture.color = Color.Lerp (Instruction7texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction7text.color = myColor7;
			}

			if(pageNumber == 8){
				myColor8 = Color.Lerp (Instruction8text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction8atexture.color = Color.Lerp (Instruction8atexture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction8btexture.color = Color.Lerp (Instruction8btexture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction8ctexture.color = Color.Lerp (Instruction8ctexture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction8text.color = myColor8;
			}

			if(pageNumber == 9){
				myColor9 = Color.Lerp (Instruction9text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction9texture.color = Color.Lerp (Instruction9texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction9text.color = myColor9;
			}

			if(pageNumber == 10){
				myColor10 = Color.Lerp (Instruction10text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction10texture.color = Color.Lerp (Instruction10texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction10text.color = myColor10;
			}
		}

		if(prev){
			if(pageNumber == 1){
				myColor1 = Color.Lerp (Instruction1text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction1texture.color = Color.Lerp (Instruction1texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction1text.color = myColor1;
			}

			if(pageNumber == 2){
				myColor2 = Color.Lerp (Instruction2text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction2texture.color = Color.Lerp (Instruction2texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction2text.color = myColor2;
			}

			if(pageNumber == 3){
				myColor3 = Color.Lerp (Instruction3text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction3texture.color = Color.Lerp (Instruction3texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction3text.color = myColor3;
			}

			if(pageNumber == 4){
				myColor4 = Color.Lerp (Instruction4text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction4texture.color = Color.Lerp (Instruction4texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction4text.color = myColor4;
			}

			if(pageNumber == 5){
				myColor5 = Color.Lerp (Instruction5text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction5texture.color = Color.Lerp (Instruction5texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction5text.color = myColor5;
			}

			if(pageNumber == 6){
				myColor6 = Color.Lerp (Instruction6text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction6texture.color = Color.Lerp (Instruction6texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction6text.color = myColor6;
			}

			if(pageNumber == 7){
				myColor7 = Color.Lerp (Instruction7text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction7texture.color = Color.Lerp (Instruction7texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction7text.color = myColor7;
			}

			if(pageNumber == 8){
				myColor8 = Color.Lerp (Instruction8text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction8atexture.color = Color.Lerp (Instruction8atexture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction8btexture.color = Color.Lerp (Instruction8btexture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction8ctexture.color = Color.Lerp (Instruction8ctexture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction8text.color = myColor8;
			}

			if(pageNumber == 9){
				myColor9 = Color.Lerp (Instruction9text.color, Color.black, fadeSpeed * Time.deltaTime);
				Instruction9texture.color = Color.Lerp (Instruction9texture.color, Color.gray, fadeSpeed * Time.deltaTime);
				Instruction9text.color = myColor9;
			}
		}
	}

	void fadeOutPages(){
		if(next){
			if(lastPageNumber == 1){
				myColor1 = Color.Lerp (Instruction1text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction1texture.color = Color.Lerp (Instruction1texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction1text.color = myColor1;
			}

			if(lastPageNumber == 2){
				myColor2 = Color.Lerp (Instruction2text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction2texture.color = Color.Lerp (Instruction2texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction2text.color = myColor2;
			}

			if(lastPageNumber == 3){
				myColor3 = Color.Lerp (Instruction3text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction3texture.color = Color.Lerp (Instruction3texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction3text.color = myColor3;
			}

			if(lastPageNumber == 4){
				myColor4 = Color.Lerp (Instruction4text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction4texture.color = Color.Lerp (Instruction4texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction4text.color = myColor4;
			}

			if(lastPageNumber == 5){
				myColor5 = Color.Lerp (Instruction5text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction5texture.color = Color.Lerp (Instruction5texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction5text.color = myColor5;
			}

			if(lastPageNumber == 6){
				myColor6 = Color.Lerp (Instruction6text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction6texture.color = Color.Lerp (Instruction6texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction6text.color = myColor6;
			}

			if(lastPageNumber == 7){
				myColor7 = Color.Lerp (Instruction7text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction7texture.color = Color.Lerp (Instruction7texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction7text.color = myColor7;
			}

			if(lastPageNumber == 8){
				myColor8 = Color.Lerp (Instruction8text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction8atexture.color = Color.Lerp (Instruction8atexture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction8btexture.color = Color.Lerp (Instruction8btexture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction8ctexture.color = Color.Lerp (Instruction8ctexture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction8text.color = myColor8;
			}

			if(lastPageNumber == 9){
				myColor9 = Color.Lerp (Instruction9text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction9texture.color = Color.Lerp (Instruction9texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction9text.color = myColor9;
			}

		}

		if(prev){
			if(lastPageNumber == 2){
				myColor2 = Color.Lerp (Instruction2text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction2texture.color = Color.Lerp (Instruction2texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction2text.color = myColor2;
			}

			if(lastPageNumber == 3){
				myColor3 = Color.Lerp (Instruction3text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction3texture.color = Color.Lerp (Instruction3texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction3text.color = myColor3;
			}

			if(lastPageNumber == 4){
				myColor4 = Color.Lerp (Instruction4text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction4texture.color = Color.Lerp (Instruction4texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction4text.color = myColor4;
			}

			if(lastPageNumber == 5){
				myColor5 = Color.Lerp (Instruction5text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction5texture.color = Color.Lerp (Instruction5texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction5text.color = myColor5;
			}

			if(lastPageNumber == 6){
				myColor6 = Color.Lerp (Instruction6text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction6texture.color = Color.Lerp (Instruction6texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction6text.color = myColor6;
			}

			if(lastPageNumber == 7){
				myColor7 = Color.Lerp (Instruction7text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction7texture.color = Color.Lerp (Instruction7texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction7text.color = myColor7;
			}

			if(lastPageNumber == 8){
				myColor8 = Color.Lerp (Instruction8text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction8atexture.color = Color.Lerp (Instruction8atexture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction8btexture.color = Color.Lerp (Instruction8btexture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction8ctexture.color = Color.Lerp (Instruction8ctexture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction8text.color = myColor8;
			}

			if(lastPageNumber == 9){
				myColor9 = Color.Lerp (Instruction9text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction9texture.color = Color.Lerp (Instruction9texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction9text.color = myColor9;
			}

			if(lastPageNumber == 10){
				myColor10 = Color.Lerp (Instruction10text.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction10texture.color = Color.Lerp (Instruction10texture.color, Color.clear, fadeSpeed * Time.deltaTime);
				Instruction10text.color = myColor10;
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
